using Collider.Specifications;

namespace Collider;

public class CollisionEngine
{
    private readonly IEnumerable<ICollisionSpecification> _collisionSpecifications;

    public CollisionEngine(IEnumerable<ICollisionSpecification> collisionSpecifications)
    {
        _collisionSpecifications = collisionSpecifications;
    }

    public bool CheckCollision(ICollidable obj1, ICollidable obj2)
        => _collisionSpecifications.Any(specification => specification.IsSatisfiedBy(obj1, obj2));
}

public class Person : Rectangle
{
    public Person(float x, float y, float width, float height) : base(x, y, width, height)
    {
    }
}

public class Ball : Circle
{
    public Ball(float x, float y, float radius) : base(x, y, radius)
    {
    }
}