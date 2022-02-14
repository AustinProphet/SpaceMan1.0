using System;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome Spaceperson! Please Select An Option Below.");
            Console.WriteLine("1) Input Name");
            Console.WriteLine("2) Input Space Agency");
            Console.WriteLine("3) Blast Off!");
            Console.WriteLine("4) Remain Earthbound");
            Console.Write("\r\nSelect an option: ");
            switch (Console.ReadLine())
            {
                case "1":
                    //capture user input for Space Name;
                    return true;
                case "2":
                    //capture user input for Space Agency;
                    return true;
                case "3":
                    //move to gather needed items menu;
                    return true;
                case "4":
                    //output "exit text"
                    return false;
                default:
                    return true;
            }
}