using System;

class Program {
    static void Main(string[] args) {
        List<Shape> shapes = new List<Shape>();
        Square square = new Square("blue", 4);
        shapes.Add(square);
        Rectangle rectangle = new Rectangle("red", 3, 4);
        shapes.Add(rectangle);
        Circle circle = new Circle("yellow", 8);
        shapes.Add(circle);

        foreach(Shape i in shapes){
            Console.WriteLine($"color: {i.getColor()}");
            Console.WriteLine($"area: {i.getArea()}");
        }
    }
}