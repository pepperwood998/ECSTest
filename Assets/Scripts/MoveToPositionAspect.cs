using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

public readonly partial struct MoveToPositionAspect : IAspect
{
    private readonly Entity entity;

    private readonly LocalTransform transform;
    private readonly RefRO<Speed> speed;
    private readonly RefRO<TargetPosition> targetPosition;

    public void Move()
    {
        var direction = math.normalize(targetPosition.ValueRO.Value - transform.Position);
        transform.Position += speed.ValueRO.Value * direction * SystemAPI.Time.DeltaTime;
    }
}
