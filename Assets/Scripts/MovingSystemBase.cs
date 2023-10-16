using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

public partial class MovingSystemBase : SystemBase
{
    protected override void OnUpdate()
    {
        Entities
            .ForEach((in MoveToPositionAspect moveToPositionAspect) => 
            {
                var direction = math.normalize(targetPosition.Value - transform.Position);
                transform.Position += speed.Value * direction * SystemAPI.Time.DeltaTime;
            })
            .Schedule();
    }
}
