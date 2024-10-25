namespace Collider.Specifications;

public class RectangleToRectangleCollisionSpecification : ICollisionSpecification
{
    public bool IsSatisfiedBy(ICollidable obj1, ICollidable obj2)
    {
        if (obj1 is not Rectangle rectangle1 || obj2 is not Rectangle rectangle2)
        {
            return false;
        }
        
        return rectangle1.Bounds.IntersectsWith(rectangle2.Bounds);
    }
}
