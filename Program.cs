using System;

namespace RoomCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string keepGoing;
            
            Console.WriteLine("Welcome to the Room Calculator!");
            //loop
            do
            { 
                Console.WriteLine("Please enter the length of the room:");
                double Length = double.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the width of the room:");
                double Width = double.Parse(Console.ReadLine());


                double Perimeter = Length + Width + Length + Width;
                Console.WriteLine($"The perimeter of the Snug Room is {Perimeter}.");

                double Area = Width * Length;
                Console.WriteLine($"The area of the Snug Room is {Area}.");

                double Paint = Perimeter / 5;
                double Carpet = Area / 5;
                Console.WriteLine($"You would need {Paint} cans of paint and {Carpet} carpet tiles for the room.");

                //volume
                Console.WriteLine("Would you like to know the volume of the room? (yes/no)");
                string volume = Console.ReadLine();
                if (volume == "YES" || volume == "yes")
                {

                    Console.WriteLine("What is the hieght of the room?");
                    double hieght = double.Parse(Console.ReadLine());
                    double roomVolume = hieght * Length * Width;
                    Console.WriteLine($"The volume of the room is {roomVolume}");
                }

                    Console.WriteLine("Would you like to calculate another room? (yes/no)");
                    //assign and read
                    keepGoing = Console.ReadLine();
                

            } while (keepGoing == "yes" || keepGoing == "YES");
        }
    }
}
