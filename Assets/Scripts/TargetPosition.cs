using Unity.Entities;
using Unity.Mathematics;

public struct TargetPosition : IComponentData
{
    public float3 Value;
}

public class TargetPositionBaker : Baker<TargetPositionAuthoring>
{
    public override void Bake(TargetPositionAuthoring authoring)
    {
        AddComponent(GetEntity(TransformUsageFlags.Dynamic), new TargetPosition()
        {
            Value = authoring.Value,
        });
    }
}
