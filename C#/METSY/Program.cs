using System;

namespace METSY_ENTERTAINMENT_CONTROL_PROGRAM
{
    class Program
    {
        static int timer = 0;

        static bool boot = false;

        static bool load = false;

        static string key;

        static bool insert = false;

        static int display = 0;

        const char _block = '■';

        static Random rnd = new Random();

        static void Main(string[] args)
        {
            boot = true;

            Console.Title = "METSY_ENTERTAINMENT_CONTROL_PROGRAM";

            if (boot == true)
            {
                Booting();
            }

            if (load == true)
            {
                //Warning Message
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Required Information:");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("This control application is provided and created");
                System.Threading.Thread.Sleep(50);
                Console.WriteLine("by Metsy Entertainment and");
                System.Threading.Thread.Sleep(50);
                Console.WriteLine("must be used solely and exclusively for the configuration of networks");
                System.Threading.Thread.Sleep(50);
                Console.WriteLine("of the respective restaurants and animatronic configuration.");
                System.Threading.Thread.Sleep(50);
                Console.WriteLine("For security reasons, the program will always ask for the user key ");
                System.Threading.Thread.Sleep(50);
                Console.WriteLine("every time the program is");
                System.Threading.Thread.Sleep(50);
                Console.WriteLine("activated.");
                System.Threading.Thread.Sleep(50);
                Console.WriteLine("If you are not part of any authorized personnel of Metsy ");
                System.Threading.Thread.Sleep(50);
                Console.WriteLine("Entertainment themed restaurants, please disable this");
                System.Threading.Thread.Sleep(50);
                Console.WriteLine("program and return it to any authorized personnel or delete it from");
                System.Threading.Thread.Sleep(50);
                Console.WriteLine("you computer.");
                System.Threading.Thread.Sleep(50);
                Console.WriteLine("For more information consult the restaurant's official website:");
                Console.WriteLine("https://metsyworld/help/staff/userkey");
                Console.ReadKey();
                Console.Clear();

                //Key Input in string format
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("========================================================================================================================");
                Console.WriteLine("                                            PLEASE INSERT YOU USER KEY                                                  ");
                Console.WriteLine("========================================================================================================================");
                Console.Write(">>");
                key = Console.ReadLine();
                insert = true;
                Console.Clear();

                //Verify the string input
                switch(key)
                {
                    case("9a84Df1"):
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(" ");
                        Console.WriteLine("========================================================================================================================");
                        Console.WriteLine("                                                WELCOME USER: " + key + "!                                             ");
                        Console.WriteLine("                                                CURRENT VERSION: 12.0.2                                          ");
                        Console.WriteLine("========================================================================================================================");
                        Console.ReadKey();
                        Console.Clear();
                        IntMenu();
                    break;

                    default:
                        key = " ";
                        Endsystem();
                        display = 10;
                        timer = 0;
                    break;
                }
                



            }

            //Program start bar
            static void Booting()
            {
                Console.Write("Booting the system:");
                while (timer < 90)
                {
                    Console.Clear();
                    int per = rnd.Next(1, 15);
                    timer = timer + per;
                    string bar = new string(_block, timer / 10);
                    Console.Write("Booting the system:");
                    Console.Write("[");
                    Console.Write(bar);
                    Console.Write("]");
                    Console.Write(" " + timer + "%");
                    System.Threading.Thread.Sleep(1000);
                }

                            
                while (timer >= 90 && timer < 100)
                {
                    Console.Clear();
                    timer = timer + 1;
                    string bar = new string(_block, timer / 10);
                    Console.Write("Booting the system:");
                    Console.Write("[");
                    Console.Write(bar);
                    Console.Write("]");
                    Console.Write(" " + timer + "%");
                    System.Threading.Thread.Sleep(1000);
                }

                if (timer >= 100)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(" DONE!");
                    System.Threading.Thread.Sleep(500);
                    Console.Clear();
                    load = true;
                    boot = false;
                    timer = 0;
                }
            }
            //Starts when the string input is wrong
            static void Endsystem()
            {
                    display = 10;
                    if(insert == true)
                    {
                        
                         while(key == " " && timer < 10)
                         {
                             timer = timer + 1;
                             display = display - 1;
                             Console.ForegroundColor = ConsoleColor.DarkRed;
                             Console.WriteLine("========================================================================================================================");
                             Console.WriteLine("                                WRONG USER KEY SHUTING DOWN THE SYSTEM IN : " + display + " SECONDS                     ");
                             Console.WriteLine("========================================================================================================================");
                             System.Threading.Thread.Sleep(1000);
                            Console.Clear();
                         }
                         
                         if(key == " " && timer == 10)
                         {
                             System.Environment.Exit(0);
                         }
                 
                    }
           
            }

            //Program main menu
            static void IntMenu()
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("========================================================================================================================");
                System.Threading.Thread.Sleep(250);
                Console.WriteLine("                                       WELCOME TO THE METSY'S CONTROL APPLICATION!                                                       ");
                System.Threading.Thread.Sleep(250);
                Console.WriteLine(" ");
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("What would you like to do today?");
                System.Threading.Thread.Sleep(250);
                Console.WriteLine(" ");
                System.Threading.Thread.Sleep(250);
                Console.WriteLine("1 ---------------------------------------------------------------- ANIMATRONIC CONTROL / REPORT ACTIVITY ");
                System.Threading.Thread.Sleep(250);
                Console.WriteLine(" ");
                System.Threading.Thread.Sleep(250);
                Console.WriteLine(" ");
            }
            
        }
    }

}