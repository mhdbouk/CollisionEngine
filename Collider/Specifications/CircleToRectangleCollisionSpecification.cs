namespace Collider.Specifications;

public class CircleToRectangleCollisionSpecification : ICollisionSpecification
{
    public bool IsSatisfiedBy(ICollidable obj1, ICollidable obj2)
    {
        if (obj1 is Circle circle && obj2 is Rectangle rectangle)
        {
            return IsSatisfiedBy(circle, rectangle);
        }

        if (obj1 is Rectangle rectangle2 && obj2 is Circle circle2)
        {
            return IsSatisfiedBy(circle2, rectangle2);
        }

        return false;
    }
    
    private bool IsSatisfiedBy(Circle circle, Rectangle rectangle)
    {
        // 1. Find the closest point on the rectangle to the circle's center
        var closestX = Math.Max(rectangle.Bounds.Left, Math.Min(circle.Center.X, rectangle.Bounds.Right));
        var closestY = Math.Max(rectangle.Bounds.Top, Math.Min(circle.Center.Y, rectangle.Bounds.Bottom));

        // 2. Calculate the distance between the circle's center and the closest point
        var distanceX = circle.Center.X - closestX;
        var distanceY = circle.Center.Y - closestY;

        // 3. Check if the distance is less than the circle's radius using Pythagorean theorem
        return Math.Sqrt(distanceX * distanceX + distanceY * distanceY) <= circle.Radius;
    }
}
