using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace testing_grounds
{
    public class Player
    {
        double OldBal = 1000;
        int turns = 1;
        int steel = 0, alum = 0, copp = 0, gold = 0, trit = 0, diam = 0, anti = 0, ice = 0, hyd = 0, mag = 0;

        public static void WelcomeInstruction()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("                                         Welcome to Space Trader!!!\n                                    Created by: Michael and Kevin Pixler\n                    Your mission, should you choose to accept it, is to become space rich!!!\n       Travel the planets and trade resources to fill your wallet with more than 50,000 SPACE BUCKS!!!");
            Console.ResetColor();
        }

        public static void CharChoose()
        {
            Console.WriteLine("\n\n\n                                           Choose your character:");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("                                 Press 1 for Elon Tusk the space elephant");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("                                 Press 2 for Elong Neck the space giraffe");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("                                 Press 3 for Elonore Muskrat the space muskrat");
            Console.ResetColor();

            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.Clear();

                Console.WriteLine("Please choose a valid number");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Choose your character");
                Console.WriteLine("Press 1 for Elon Tusk the space elephant");
                Console.WriteLine("Press 2 for Elong Neck the space giraffe");
                Console.WriteLine("Press 3 for Elonore Muskrat the space muskrat");
                Console.ResetColor();

            }
            if (choice == 1)
            {
                Console.WriteLine("You chose Elon Tusk the space elephant");
            }
            else if (choice == 2)
            {
                Console.WriteLine("You chose Elong Neck the space giraffe");
            }
            else if (choice == 3)
            {
                Console.WriteLine("You chose Elonore Muskrat the space muskrat");
            }
            Console.WriteLine("Warping to Earth!");
            Thread.Sleep(2000);

            return;
        }

        public int Turns()
        {
            turns++;
            return turns;
        }

        public double Wallet(double update)
        {
            double CurrentBal;
            CurrentBal = update + OldBal;
            OldBal = CurrentBal;
            return CurrentBal;
        }
        
       public int InventoryUpdate(int qty, int itemfetch, string itemN, int buysell)
        {
            if (buysell == 1)
            {
                if (itemfetch == 1)
                {
                    steel += qty;
                    Console.WriteLine($"You now have a total of {steel} {itemN}!");
                }
                else if (itemfetch == 2)
                {
                    alum += qty;
                    Console.WriteLine($"You now have a total of {alum} {itemN}!");
                }
                else if (itemfetch == 3)
                {
                    copp += qty;
                    Console.WriteLine($"You now have a total of {copp} {itemN}!");
                }
                else if (itemfetch == 4)
                {
                    gold += qty;
                    Console.WriteLine($"You now have a total of {gold} {itemN}!");
                }
                else if (itemfetch == 5)
                {
                    trit += qty;
                    Console.WriteLine($"You now have a total of {trit} {itemN}!");
                }
                else if (itemfetch == 6)
                {
                    diam += qty;
                    Console.WriteLine($"You now have a total of {diam} {itemN}!");
                }
                else if (itemfetch == 7)
                {
                    anti += qty;
                    Console.WriteLine($"You now have a total of {anti} {itemN}!");
                }
                else if (itemfetch == 8)
                {
                    ice += qty;
                    Console.WriteLine($"You now have a total of {ice} {itemN}!");
                }
                else if (itemfetch == 9)
                {
                    hyd += qty;
                    Console.WriteLine($"You now have a total of {hyd} {itemN}!");
                }
                else if (itemfetch == 10)
                {
                    mag += qty;
                    Console.WriteLine($"You now have a total of {mag} {itemN}!");
                }
            }
            else if (buysell == 2)
            {
                if (itemfetch == 1)
                {
                    steel -= qty;
                    Console.WriteLine($"You now have a total of {steel} {itemN}!");
                }
                else if (itemfetch == 2)
                {
                    alum -= qty;
                    Console.WriteLine($"You now have a total of {alum} {itemN}!");
                }
                else if (itemfetch == 3)
                {
                    copp -= qty;
                    Console.WriteLine($"You now have a total of {copp} {itemN}!");
                }
                else if (itemfetch == 4)
                {
                    gold -= qty;
                    Console.WriteLine($"You now have a total of {gold} {itemN}!");
                }
                else if (itemfetch == 5)
                {
                    trit -= qty;
                    Console.WriteLine($"You now have a total of {trit} {itemN}!");
                }
                else if (itemfetch == 6)
                {
                    diam -= qty;
                    Console.WriteLine($"You now have a total of {diam} {itemN}!");
                }
                else if (itemfetch == 7)
                {
                    anti -= qty;
                    Console.WriteLine($"You now have a total of {anti} {itemN}!");
                }
                else if (itemfetch == 8)
                {
                    ice -= qty;
                    Console.WriteLine($"You now have a total of {ice} {itemN}!");
                }
                else if (itemfetch == 9)
                {
                    hyd -= qty;
                    Console.WriteLine($"You now have a total of {hyd} {itemN}!");
                }
                else if (itemfetch == 10)
                {
                    mag -= qty;
                    Console.WriteLine($"You now have a total of {mag} {itemN}!");
                }
            }
            else if (buysell == 5)
            {
                if (itemfetch == 1)
                {
                    return steel;
                }
                else if (itemfetch == 2)
                {
                    return alum;
                }
                else if (itemfetch == 3)
                {
                    return copp;
                }
                else if (itemfetch == 4)
                {
                    return gold;
                }
                else if (itemfetch == 5)
                {
                    return trit;
                }
                else if (itemfetch == 6)
                {
                    return diam;
                }
                else if (itemfetch == 7)
                {
                    return anti;
                }
                else if (itemfetch == 8)
                {
                    return ice;
                }
                else if (itemfetch == 9)
                {
                    return hyd;
                }
                else if (itemfetch == 10)
                {
                    return mag;
                }

            }
            else if (itemfetch == 9)
            {
                Console.WriteLine("Heres a list of your current inventory.");
                Console.WriteLine("");
                Console.WriteLine($"1. Steel        - {steel}");
                Console.WriteLine($"2. Aluminum     - {alum}");
                Console.WriteLine($"3. Copper       - {copp}");
                Console.WriteLine($"4. Gold         - {gold}");
                Console.WriteLine($"5. Tritium Cans - {trit}");
                Console.WriteLine($"6. Diamonds     - {diam}");
                Console.WriteLine($"7. Antimatter   - {anti}");
                Console.WriteLine($"8. Ice          - {ice}");
                Console.WriteLine($"9. Hydrogen     - {hyd}");
                Console.WriteLine($"10. Magnesium   - {mag}");


            }
            return 0;
        }
    }
}
