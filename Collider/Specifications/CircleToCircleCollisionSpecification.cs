namespace Collider.Specifications;

public class CircleToCircleCollisionSpecification : ICollisionSpecification
{
    public bool IsSatisfiedBy(ICollidable obj1, ICollidable obj2)
    {
        if (obj1 is not Circle circle1 || obj2 is not Circle circle2)
        {
            return false;
        }
        
        return Math.Sqrt(Math.Pow(circle1.Center.X - circle2.Center.X, 2) + Math.Pow(circle1.Center.Y - circle2.Center.Y, 2)) < circle1.Radius + circle2.Radius;
    }
}
