namespace Collider.Specifications;

public interface ICollisionSpecification
{
    bool IsSatisfiedBy(ICollidable obj1, ICollidable obj2);
}