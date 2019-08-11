using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing_grounds
{
    public class Planets
    {
        public void Welcome(int currentplanet)
        {
            Console.WriteLine("-----------------------------------------------------");
            if (currentplanet == 1)
            {

                Console.WriteLine($"Welcome to Earth");
                Console.WriteLine(" ");
                Console.WriteLine("We currently buy and sell: ");
                Console.WriteLine("                 Buy price          Sell price");
                Console.WriteLine("1. Hydrogen            225                250");
                Console.WriteLine("2. Aluminum            4                  5");
                Console.WriteLine("3. Copper              5                  7");
                Console.WriteLine("4. Gold                70                 80");
            }
            else if (currentplanet == 2)
            {
                Console.WriteLine($"Welcome to Jupiter");
                Console.WriteLine(" ");
                Console.WriteLine("We currently buy and sell: ");
                Console.WriteLine("                 Buy price          Sell price");
                Console.WriteLine("1. Tritium Cans       200                 250");
                Console.WriteLine("2. Steel              9                   12");
                Console.WriteLine("3. Diamonds           70                  80");
                Console.WriteLine("4. Antimatter         1250                1500");
            }
            else if (currentplanet == 3)
            {
                Console.WriteLine($"Welcome to Pluto");
                Console.WriteLine(" ");
                Console.WriteLine("We currently buy and sell: ");
                Console.WriteLine("                 Buy price          Sell price");
                Console.WriteLine("1. Diamonds            75                  125");
                Console.WriteLine("2. Ice                 1                   2");
                Console.WriteLine("3. Magnesium           27                  30");
                Console.WriteLine("4. Tritium Cans        275                 300");
            }
            else if (currentplanet == 4)
            {
                Console.WriteLine($"Welcome to The Sun Lounge");
                Console.WriteLine(" ");
                Console.WriteLine("We currently buy and sell: ");
                Console.WriteLine("                 Buy price          Sell price");
                Console.WriteLine("1. Ice                 5                 10");
                Console.WriteLine("2. Antimatter          1600              1750");
                Console.WriteLine("3. Hydrogen            200               150");
                Console.WriteLine("4. Copper              8                 9");
            }
            else if (currentplanet == 5)
            {
                Console.WriteLine($"Welcome to Mars");
                Console.WriteLine(" ");
                Console.WriteLine("We currently buy and sell: ");
                Console.WriteLine("                 Buy price          Sell price");
                Console.WriteLine("1. Magnesium           20                 25");
                Console.WriteLine("2. Steel               8                  10");
                Console.WriteLine("3. Aluminum            6                  7");
                Console.WriteLine("4. Gold                40                 50");

            }
        }

        public int BuySell()
        {
            //Console.WriteLine("Would you like to buy or sell?");
            //Console.WriteLine("Type '1' to buy");
            //Console.WriteLine("Type '2' to sell");
            //Console.Write("I would like to: ");
            int buysell = 0;
            int i = 0;
            
            while (i != 1)
            {
                Console.WriteLine("A shopkeeper asks if you would like to buy, sell or leave the planet?");
                Console.WriteLine("Type '1' to buy");
                Console.WriteLine("Type '2' to sell");
                Console.WriteLine("Type '3' to leave");
                Console.WriteLine("Type '4' to see your inventory");

                Console.Write("I would like to: ");
                string ans = Console.ReadLine();
                if (ans == "1")
                {
                    buysell = 1;
                    i++;
                    return buysell;
                }
                else if (ans == "2")
                {
                    buysell = 2;
                    i++;
                    return buysell;
                }
                else if (ans == "3")
                {
                    buysell = 3;
                    i++;
                    return buysell;
                }
                else if (ans == "4")
                {
                    buysell = 4;
                    i++;
                    return buysell;
                }
                else if (ans != "1" || ans != "2" || ans != "3" || ans != "4")
                {
                    Console.WriteLine("Invalid input please try again.");
                    
                }
            }
            return 0;
        }
        public int PlanetChoose(int currentplanet)
        {

            if (currentplanet == 1)
            {
                Console.WriteLine("Choose the number of a planet:");
                Console.WriteLine("2. Jupiter");
                Console.WriteLine("3. Pluto");
                Console.WriteLine("4. Sun Lounge");
                Console.WriteLine("5. Mars");
                Console.Write("I would like to go to planet number: ");
                string choice2 = Console.ReadLine();
                if (choice2 == "2" || choice2 == "3" || choice2 == "4" || choice2 == "5")
                {
                    currentplanet = (Convert.ToInt32(choice2));
                }
                else if (choice2 != "2" || choice2 != "3" || choice2 != "4" || choice2 != "5")
                {
                    Console.Clear();
                    Console.WriteLine("that wasnt one of the choices so you would like to stay!!!");
                }

                    return currentplanet;
            }
            else if (currentplanet == 2)
            {
                Console.WriteLine("Choose the number of a planet:");
                Console.WriteLine("1. Earth");
                Console.WriteLine("3. Pluto");
                Console.WriteLine("4. Sun Lounge");
                Console.WriteLine("5. Mars");
                Console.Write("I would like to go to planet number: ");
                string choice2 = Console.ReadLine();
                if (choice2 == "1" || choice2 == "3" || choice2 == "4" || choice2 == "5")
                {
                    currentplanet = (Convert.ToInt32(choice2));
                }
                else if (choice2 != "1" || choice2 != "3" || choice2 != "4" || choice2 != "5")
                {
                    Console.Clear();
                    Console.WriteLine("that wasnt one of the choices so you would like to stay!!!");
                }

                return currentplanet;
            }
            else if (currentplanet == 3)
            {
                Console.WriteLine("Choose the number of a planet:");
                Console.WriteLine("1. Earth");
                Console.WriteLine("2. Jupiter");
                Console.WriteLine("4. Sun Lounge");
                Console.WriteLine("5. Mars");
                Console.Write("I would like to go to planet number: ");
                string choice2 = Console.ReadLine();
                if (choice2 == "2" || choice2 == "1" || choice2 == "4" || choice2 == "5")
                {
                    currentplanet = (Convert.ToInt32(choice2));
                }
                else if (choice2 != "2" || choice2 != "1" || choice2 != "4" || choice2 != "5")
                {
                    Console.Clear();
                    Console.WriteLine("that wasnt one of the choices so you would like to stay!!!");
                }

                return currentplanet;

            }
            else if (currentplanet == 4)
            {
                Console.WriteLine("Choose the number of a planet:");
                Console.WriteLine("1. Earth");
                Console.WriteLine("2. Jupiter");
                Console.WriteLine("3. Pluto");
                Console.WriteLine("5. Mars");
                Console.Write("I would like to go to planet number: ");
                string choice2 = Console.ReadLine();
                if (choice2 == "2" || choice2 == "3" || choice2 == "1" || choice2 == "5")
                {
                    currentplanet = (Convert.ToInt32(choice2));
                }
                else if (choice2 != "2" || choice2 != "3" || choice2 != "1" || choice2 != "5")
                {
                    Console.Clear();
                    Console.WriteLine("that wasnt one of the choices so you would like to stay!!!");
                }

                return currentplanet;
            }
            else if (currentplanet == 5)
            {
                Console.WriteLine("Choose the number of a planet:");
                Console.WriteLine("1. Earth");
                Console.WriteLine("2. Jupiter");
                Console.WriteLine("3. Pluto");
                Console.WriteLine("4. Sun Lounge");
                Console.Write("I would like to go to planet number: ");
                string choice2 = Console.ReadLine();
                if (choice2 == "2" || choice2 == "3" || choice2 == "1" || choice2 == "4")
                {
                    currentplanet = (Convert.ToInt32(choice2));
                }
                else if (choice2 != "2" || choice2 != "3" || choice2 != "1" || choice2 != "4")
                {
                    Console.Clear();
                    Console.WriteLine("that wasnt one of the choices so you would like to stay!!!");
                }

                return currentplanet;
            }


            return 0;

        }
        public int PlanetBuy(int currentplanet)
        {
            
            int i = 0;
            int itemfetch;

            while (i != 1)
            {
                Console.WriteLine("Please pick an item number of what you would like to buy: ");
                Console.Write("I would like item number: ");
                string choice3 = Console.ReadLine();
                if (currentplanet == 1)
                {
                    if (choice3 == "1")
                    {
                        itemfetch = 9;
                        i++;
                        return itemfetch;

                    }
                    else if (choice3 == "2")
                    {
                        itemfetch = 2;
                        i++;
                        return itemfetch;
                    }
                    else if (choice3 == "3")
                    {
                        itemfetch = 3;
                        i++;
                        return itemfetch;
                    }
                    else if (choice3 == "4")
                    {
                        itemfetch = 4;
                        i++;
                        return itemfetch;
                    }
                    else if (choice3 != "1")
                    {
                        Console.WriteLine("invalid input please try again.");
                    }
                }
                else if (currentplanet == 2)
                {
                    if (choice3 == "1")
                    {
                        itemfetch = 5;
                        i++;
                        return itemfetch;

                    }
                    else if (choice3 == "2")
                    {
                        itemfetch = 1;
                        i++;
                        return itemfetch;
                    }
                    else if (choice3 == "3")
                    {
                        itemfetch = 6;
                        i++;
                        return itemfetch;
                    }
                    else if (choice3 == "4")
                    {
                        itemfetch = 7;
                        i++;
                        return itemfetch;
                    }
                    else if (choice3 != "1")
                    {
                        Console.WriteLine("invalid input please try again.");
                    }
                }
                else if (currentplanet == 3)
                {
                    if (choice3 == "1")
                    {
                        itemfetch = 6;
                        i++;
                        return itemfetch;

                    }
                    else if (choice3 == "2")
                    {
                        itemfetch = 8;
                        i++;
                        return itemfetch;
                    }
                    else if (choice3 == "3")
                    {
                        itemfetch = 10;
                        i++;
                        return itemfetch;
                    }
                    else if (choice3 == "4")
                    {
                        itemfetch = 5;
                        i++;
                        return itemfetch;
                    }
                    else if (choice3 != "1")
                    {
                        Console.WriteLine("invalid input please try again.");
                    }
                }
                else if (currentplanet == 4)
                {
                    if (choice3 == "1")
                    {
                        itemfetch = 8;
                        i++;
                        return itemfetch;

                    }
                    else if (choice3 == "2")
                    {
                        itemfetch = 7;
                        i++;
                        return itemfetch;
                    }
                    else if (choice3 == "3")
                    {
                        itemfetch = 9;
                        i++;
                        return itemfetch;
                    }
                    else if (choice3 == "4")
                    {
                        itemfetch = 3;
                        i++;
                        return itemfetch;
                    }
                    else if (choice3 != "1")
                    {
                        Console.WriteLine("invalid input please try again.");
                    }
                }
                else if (currentplanet == 5)
                {
                    if (choice3 == "1")
                    {
                        itemfetch = 10;
                        i++;
                        return itemfetch;

                    }
                    else if (choice3 == "2")
                    {
                        itemfetch = 1;
                        i++;
                        return itemfetch;
                    }
                    else if (choice3 == "3")
                    {
                        itemfetch = 2;
                        i++;
                        return itemfetch;
                    }
                    else if (choice3 == "4")
                    {
                        itemfetch = 4;
                        i++;
                        return itemfetch;
                    }
                    else if (choice3 != "1")
                    {
                        Console.WriteLine("invalid input please try again.");
                    }
                }

            }
            return 0;
        }

        public int PlanetSell(int currentplanet)
        {

            int i = 0;
            int itemfetch;

            while (i != 1)
            {
                Console.WriteLine("Please pick an item number of what you would like to Sell: ");
                Console.Write("I would like to sell item number: ");
                string choice3 = Console.ReadLine();
                if (currentplanet == 1)
                {
                    if (choice3 == "1")
                    {
                        itemfetch = 9;
                        i++;
                        return itemfetch;

                    }
                    else if (choice3 == "2")
                    {
                        itemfetch = 2;
                        i++;
                        return itemfetch;
                    }
                    else if (choice3 == "3")
                    {
                        itemfetch = 3;
                        i++;
                        return itemfetch;
                    }
                    else if (choice3 == "4")
                    {
                        itemfetch = 4;
                        i++;
                        return itemfetch;
                    }
                    else if (choice3 != "1")
                    {
                        Console.WriteLine("invalid input please try again.");
                    }
                }
                else if (currentplanet == 2)
                {
                    if (choice3 == "1")
                    {
                        itemfetch = 5;
                        i++;
                        return itemfetch;

                    }
                    else if (choice3 == "2")
                    {
                        itemfetch = 1;
                        i++;
                        return itemfetch;
                    }
                    else if (choice3 == "3")
                    {
                        itemfetch = 6;
                        i++;
                        return itemfetch;
                    }
                    else if (choice3 == "4")
                    {
                        itemfetch = 7;
                        i++;
                        return itemfetch;
                    }
                    else if (choice3 != "1")
                    {
                        Console.WriteLine("invalid input please try again.");
                    }
                }
                else if (currentplanet == 3)
                {
                    if (choice3 == "1")
                    {
                        itemfetch = 6;
                        i++;
                        return itemfetch;

                    }
                    else if (choice3 == "2")
                    {
                        itemfetch = 8;
                        i++;
                        return itemfetch;
                    }
                    else if (choice3 == "3")
                    {
                        itemfetch = 4;
                        i++;
                        return itemfetch;
                    }
                    else if (choice3 == "4")
                    {
                        itemfetch = 5;
                        i++;
                        return itemfetch;
                    }
                    else if (choice3 != "1")
                    {
                        Console.WriteLine("invalid input please try again.");
                    }
                }
                else if (currentplanet == 4)
                {
                    if (choice3 == "1")
                    {
                        itemfetch = 8;
                        i++;
                        return itemfetch;

                    }
                    else if (choice3 == "2")
                    {
                        itemfetch = 7;
                        i++;
                        return itemfetch;
                    }
                    else if (choice3 == "3")
                    {
                        itemfetch = 9;
                        i++;
                        return itemfetch;
                    }
                    else if (choice3 == "4")
                    {
                        itemfetch = 3;
                        i++;
                        return itemfetch;
                    }
                    else if (choice3 != "1")
                    {
                        Console.WriteLine("invalid input please try again.");
                    }
                }
                else if (currentplanet == 5)
                {
                    if (choice3 == "1")
                    {
                        itemfetch = 10;
                        i++;
                        return itemfetch;

                    }
                    else if (choice3 == "2")
                    {
                        itemfetch = 5;
                        i++;
                        return itemfetch;
                    }
                    else if (choice3 == "3")
                    {
                        itemfetch = 2;
                        i++;
                        return itemfetch;
                    }
                    else if (choice3 == "4")
                    {
                        itemfetch = 4;
                        i++;
                        return itemfetch;
                    }
                }

            }
            return 0;
        }

        public string PName(int currentplanet)
        {
            if (currentplanet == 1)
            {
                return "Earth";
            }
            else if (currentplanet == 2)
            {
                return "Jupiter";
            }
            else if (currentplanet == 3)
            {
                return "Pluto";
            }
            else if (currentplanet == 4)
            {
                return "The Sun Lounge";
            }
            else if (currentplanet == 5)
            {
                return "Mars";
            }
            return "o";
        }
    }
}

