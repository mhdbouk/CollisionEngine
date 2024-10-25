using Collider.Specifications;
using System.Drawing;

namespace Collider;

public interface ICollidable
{
    bool CollidesWith(ICollidable other, CollisionEngine engine);
}

public abstract class Shape : ICollidable
{
    public bool CollidesWith(ICollidable other, CollisionEngine engine)
        => engine.CheckCollision(this, other);
    public abstract void Move(float x, float y);
}

public abstract class Circle : Shape
{
    public PointF Center { get; private set; }
    public float Radius { get; private set; }

    public Circle(float x, float y, float radius)
    {
        Center = new PointF(x, y);
        Radius = radius;
    }
    
    public override void Move(float x, float y)
    {
        Center = Center with { X = Center.X + x, Y = Center.Y + y };
    }
}

public abstract class Rectangle : Shape
{
    public RectangleF Bounds { get; private set; }

    public Rectangle(float x, float y, float width, float height)
    {
        Bounds = new RectangleF(x, y, width, height);
    }

    public override void Move(float x, float y)
    {
        Bounds = Bounds with { X = Bounds.X + x, Y = Bounds.Y + y };
    }
}
