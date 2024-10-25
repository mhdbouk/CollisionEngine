// See https://aka.ms/new-console-template for more information

using Collider;
using Collider.Specifications;

Console.WriteLine("Hello, World!");

var person = new Person(150, 150, 100, 150);
var ball = new Ball(179, 254, 50);

var engine = new CollisionEngine([new RectangleToRectangleCollisionSpecification(), new CircleToCircleCollisionSpecification(), new CircleToRectangleCollisionSpecification()]);

Console.WriteLine("Person collides with ball: " + person.CollidesWith(ball, engine));

ball.Move(15, 10);

Console.WriteLine("Person collides with ball: " + person.CollidesWith(ball, engine));