using System;
using System.Collections.Generic;

namespace Boxing_Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an empty List of type object

            // List <object> objects = new List <object>();

            // // Add the following values to the list: 7, 28, -1, true, "chair"
            // objects.Add( 7 );
            // objects.Add( 28 );
            // objects.Add( -1 );
            // objects.Add( true );
            // objects.Add( "chair" );

            // int sum = 0;

            // // Loop through the list and print all values(Hint: Type Inference might help here!)

            // foreach (var item in objects)
            // {
            //     Console.WriteLine(item);
            
            // // Add all values that are Int type together and output the sum

            // if (item is int)
            // {
            // sum += (int) item; 
            // }
            // }

            // Console.WriteLine("The sum of the ints in this objects List is" + " " + sum);


            // Create an empty List of type object

            var objects = new List <object>

            // Add the following values to the list: 7, 28, -1, true, "chair"

            {
                7, 28, -1, true, "chair"
            };
            int sum = 0;

            // // Loop through the list and print all values(Hint: Type Inference might help here!)
            // // Add all values that are Int type together and output the sum

            foreach (var item in objects)
            {
                Console.WriteLine(item);
            if (item is int)
            {
            sum += (int) item; 
            }
            }

            Console.WriteLine("The sum of the ints in this objects List is" + " " + sum);
        }
    }
}
