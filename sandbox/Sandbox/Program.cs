using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

class Program
{

    // public static void Greeting()
    // {
    //     Console.WriteLine("Hello Bob");
    // }

    // public static int AddNumbers(int n1, int n2)
    // {
    //     Console.WriteLine("Bob");
    //     return n1 + n2;
    // }


    // public static void passByValue(int a)
    // {
    //     a++;
    //     Console.WriteLine($"In the value function {a}");
    // }

    // public static void passByRef(ref int x)
    // {
    //     x ++;
    //     Console.WriteLine($"In the ref function {x}");
    //     // return x;
    // }

    // public static void passByOut(out int y)
    // {
    //     y= 10;
    //     y++;
    //     // return y;
    // }

    static void Main(string[] args)
    {


        Console.WriteLine("Circle");

        Circle myCircle = new Circle();

        myCircle.SetRadius(10);
        Console.WriteLine(myCircle.GetRadius());
        myCircle._radius = 900;

        Circle myCircle2 = new Circle();

        myCircle2.SetRadius(9999999999);
        Console.WriteLine(myCircle2.GetRadius());

        Console.WriteLine(myCircle2.GetCircumference());
        
        Console.WriteLine(myCircle2.GetArea());
        Console.WriteLine(myCircle2.GetDiameter());


        // int x = 20;
        // Console.WriteLine($"In the main 1: {x}");

        // passByValue(x);
        // Console.WriteLine($"In the main 2: {x}");

        // passByRef(ref x);
        // Console.WriteLine($"In the main 3: {x}");

        // int z;
        // passByOut(out z);
        // Console.WriteLine(z);




        // TODO Dictionary<int, string> myFriends=new Dictionary<int, string>();



        // Greeting();

        // int total = AddNumbers(10, 20);

        // Console.WriteLine(total);
        // Console.WriteLine("Hello Sandbox World!");

        // int age;

        // Console.Write("Please input your age: ");
        // // string response = Console.ReadLine();
        // // age = int.Parse(response);
        // age = int.Parse(Console.ReadLine());

        // Console.WriteLine($"Your age is: {age}");
        // int x = 20;
        // double z = 12.23;

        // //* && = and, || = or

        // if (age <= 100 && x<= 30 || z < 6)
        // {
        //     Console.WriteLine("You are cool");
        // }
        // else if (age <= 150)
        // {
        //     Console.WriteLine("You are sort of cool");
        // }
        // else
        // {
        //     Console.WriteLine("Wow you have had a lot of birthdays.");
        // }



        // for(int i = 0; i < 10; i+=3)
        // {
        //     Console.WriteLine(i);
        // }

        // int y = 10;
        // int z = y++;
        // Console.WriteLine(z);
        // Console.WriteLine(y);

        // int j = 0;

        // for(j = 100000; j >= -100000; j-= 10000)
        
        //     Console.WriteLine(j);
        //     Console.WriteLine(j + 10099);



        // bool done = false;

        // while (! done)
        // {
        //     Console.WriteLine("Please input your age: ");
        //     int age = int.Parse(Console.ReadLine());
        //     if (age >= 0 && age <= 125)
        //     {
        //         done = true;
        //         Console.WriteLine("Thank You");
        //     }
        //     else
        //     {
        //         Console.WriteLine("Please input a valid age.");
        //     }
        // }
        

        // bool done;

        // do
        // {
        //     Console.WriteLine("Please input your age: ");
        //     int age = int.Parse(Console.ReadLine());
        //     if (age >= 0 && age <= 125)
        //     {
        //         done = true;
        //         Console.WriteLine("Thank You");
        //     }
        //     else
        //     {
        //         done = false;
        //         Console.WriteLine("Please input a valid age.");
        //     }
        // } while(! done);


    // List<int> myData = new List<int>();
    // myData.Add(10);
    // myData.Add(11);
    // myData.Add(12);
    // myData.Add(13);
    // myData.Add(14);
    // myData.Add(15);

    // Console.WriteLine(myData.Count);

    // foreach(int i in myData)
    // {
    //     Console.WriteLine(i);
    // }



    // List<string> myFriends = ["Bob", "Betty", "Jeannie"];
    // myFriends.Add("Bubba");
    // myFriends.Add("23423");
    // //! myFriends.Add(23423);



    // int[] myData = [1, 2, 3];
    // int[] DataRef=myData;


    











    }
}