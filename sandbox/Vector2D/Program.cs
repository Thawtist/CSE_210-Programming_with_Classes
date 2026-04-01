using System.Numerics;

class Program
{
    public static void Main(string[] args)
    {
        Vector2D vector2D_1 = new Vector2D(10, 11);
        Vector2D vector2D_2 = new Vector2D(5, 5);

        Console.WriteLine(vector2D_1.GetVector2DDisplayString());

        Vector2D vector2D_3 = vector2D_1 + vector2D_2;
        Console.WriteLine(vector2D_3.GetVector2DDisplayString());

        Vector2D vector2D_4 = vector2D_1 - vector2D_2;
        Console.WriteLine(vector2D_4.GetVector2DDisplayString());

        if (vector2D_1 != vector2D_2)
        {
            Console.WriteLine("Vectors are not equal");
        }
        // else
        // {
        //     Console.WriteLine("Vectors are not equal");
        // }



    }
}