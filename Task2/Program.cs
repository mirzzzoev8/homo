Rectangle rectangle = new Rectangle();
rectangle.Width = Convert.ToDouble(Console.ReadLine());
rectangle.Height = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine(rectangle.Area());
public class Rectangle
{
    public double Width;
    public double Height;
    public double Area(){
        return Width * Height;
    }
}