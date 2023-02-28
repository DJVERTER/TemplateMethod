using TemplateMethod.Square;

var triangle = new TriangleSquare(10, 15);
var circle = new CircleSquare(20);
var rectangle = new RectangleSquare(2, 3);  

var shapes = new ISquare[] { triangle, circle, rectangle };
DisplaySquare(shapes);
Console.ReadKey();

static void DisplaySquare(ISquare[] shapes)
{
    foreach (var shape in shapes)
    {
        shape.Calculate();
    }
}