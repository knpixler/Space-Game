using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing_grounds
{
    public class Itemized
    {
        public int ItemPrice(int itemfetch, int currentplanet, int buysell)
        {
            if (itemfetch == 1)
            {
                //Steel
                if (currentplanet == 5)
                {
                    if (buysell == 1)
                    {
                        int steel11 = 10; //11 = planet 1 buy  (1)
                        return steel11;
                    }
                    else if (buysell == 2)
                    {
                        int steel12 = 8;  //12 = planet 1 sell (2)
                        return steel12;
                    }
                }
                else if (currentplanet == 2)
                {
                    if (buysell == 1)
                    {
                        int steel21 = 12; //21 = planet 2 buy  (1)
                        return steel21;
                    }
                    else if (buysell == 2)
                    {
                        int steel22 = 9;  //22 = planet 2 sell (2)
                        return steel22;
                    }
                }
            }
            else if (itemfetch == 2)
            {
                //Aluminum
                if (currentplanet == 1)
                {
                    if (buysell == 1)
                    {
                        int alum11 = 5;
                        return alum11;
                    }
                    else if (buysell == 2)
                    {
                        int alum12 = 4;
                        return alum12;
                    }
                }
                else if (currentplanet == 5)
                {
                    if (buysell == 1)
                    {
                        int alum41 = 7;
                        return alum41;
                    }
                    else if (buysell == 2)
                    {
                        int alum42 = 6;
                        return alum42;
                    }
                }
            }
            else if (itemfetch == 3)
            {
                //Copper
                if (currentplanet == 1)
                {
                    if (buysell == 1)
                    {
                        int copp11 = 7;
                        return copp11;
                    }
                    else if (buysell == 2)
                    {
                        int copp12 = 5;
                        return copp12;
                    }
                }
                else if (currentplanet == 4)
                {
                    if (buysell == 1)
                    {
                        int copp41 = 9;
                        return copp41;
                    }
                    else if (buysell == 2)
                    {
                        int copp42 = 8;
                        return copp42;
                    }
                }
            }
            else if (itemfetch == 4)
            {
                //Gold
                if (currentplanet == 1)
                {
                    if (buysell == 1)
                    {
                        int gold11 = 80;
                        return gold11;
                    }
                    else if (buysell == 2)
                    {
                        int gold12 = 70;
                        return gold12;
                    }
                }
                else if (currentplanet == 5)
                {
                    if (buysell == 1)
                    {
                        int gold31 = 50;
                        return gold31;
                    }
                    else if (buysell == 2)
                    {
                        int gold32 = 40;
                        return gold32;
                    }
                }
            }
            else if (itemfetch == 5)
            {
                //Tritium Cans
                if (currentplanet == 2)
                {
                    if (buysell == 1)
                    {
                        int trit21 = 250;
                        return trit21;
                    }
                    else if (buysell == 2)
                    {
                        int trit22 = 200;
                        return trit22;
                    }
                }
                else if (currentplanet == 3)
                {
                    if (buysell == 1)
                    {
                        int trit31 = 300;
                        return trit31;
                    }
                    else if (buysell == 2)
                    {
                        int trit32 = 275;
                        return trit32;
                    }
                }
            }
            else if (itemfetch == 6)
            {
                //Diamonds
                if (currentplanet == 2)
                {
                    if (buysell == 1)
                    {
                        int diam21 = 80;
                        return diam21;
                    }
                    else if (buysell == 2)
                    {
                        int diam22 = 70;
                        return diam22;
                    }
                }
                else if (currentplanet == 3)
                {
                    if (buysell == 1)
                    {
                        int diam31 = 125;
                        return diam31;
                    }
                    else if (buysell == 2)
                    {
                        int diam32 = 75;
                        return diam32;
                    }
                }
            }
            else if (itemfetch == 7)
            {
                //Antimatter
                if (currentplanet == 2)
                {
                    if (buysell == 1)
                    {
                        int anti21 = 1500;
                        return anti21;
                    }
                    else if (buysell == 2)
                    {
                        int anti22 = 1250;
                        return anti22;
                    }
                }
                else if (currentplanet == 4)
                {
                    if (buysell == 1)
                    {
                        int anti41 = 1750;
                        return anti41;
                    }
                    else if (buysell == 2)
                    {
                        int anti42 = 1600;
                        return anti42;
                    }
                }
            }
            else if (itemfetch == 8)
            {
                //Ice
                if (currentplanet == 3)
                {
                    if (buysell == 1)
                    {
                        int ice31 = 2;
                        return ice31;
                    }
                    else if (buysell == 2)
                    {
                        int ice32 = 1;
                        return ice32;
                    }
                }
                else if (currentplanet == 4)
                {
                    if (buysell == 1)
                    {
                        int ice41 = 10;
                        return ice41;
                    }
                    else if (buysell == 2)
                    {
                        int ice42 = 5;
                        return ice42;
                    }
                }
            }
            else if (itemfetch == 9)
            {
                //Hydrogen
                if (currentplanet == 1)
                {
                    if (buysell == 1)
                    {
                        int hydrogen11 = 250;
                        return hydrogen11;
                    }
                    else if (buysell == 2)
                    {
                        int hydrogen22 = 225;
                        return hydrogen22;
                    }
                }
                else if (currentplanet == 4)
                {
                    if (buysell == 1)
                    {
                        int hydrogen41 = 150;
                        return hydrogen41;
                    }
                    else if (buysell == 2)
                    {
                        int hydrogen42 = 200;
                        return hydrogen42;
                    }
                }
            }
            else if (itemfetch == 10)
            {
                //Magnesium
                if (currentplanet == 5)
                {
                    if (buysell == 1)
                    {
                        int mag51 = 25;
                        return mag51;
                    }
                    else if (buysell == 2)
                    {
                        int mag52 = 20;
                        return mag52;
                    }
                }
                else if (currentplanet == 3)
                {
                    if (buysell == 1)
                    {
                        int mag31 = 27;
                        return mag31;
                    }
                    else if (buysell == 2)
                    {
                        int mag32 = 30;
                        return mag32;
                    }
                }
            }

            return 0;
        }
        public string ItemString(int itemfetch)
        {
            string itemN;
            if (itemfetch == 1)
            {
                itemN = "Steel";
                return itemN;
            }
            else if (itemfetch == 2)
            {
                itemN = "Aluminum";
                return itemN;
            }
            else if (itemfetch == 3)
            {
                itemN = "Copper";
                return itemN;
            }
            else if (itemfetch == 4)
            {
                itemN = "Gold";
                return itemN;
            }
            else if (itemfetch == 5)
            {
                itemN = "Tritium Cans";
                return itemN;
            }
            else if (itemfetch == 6)
            {
                itemN = "Diamonds";
                return itemN;
            }
            else if (itemfetch == 7)
            {
                itemN = "Antimatter";
                return itemN;
            }
            else if (itemfetch == 8)
            {
                itemN = "Ice";
                return itemN;
            }
            else if (itemfetch == 9)
            {
                itemN = "Hyrdogen";
                return itemN;
            }
            else if (itemfetch == 10)
            {
                itemN = "Magnesium";
                return itemN;
            }
            return null;
        }


        public (double, int) ItemCostBuy(int itemfetch, double currentbal, int itemprice, string itemN, int buysell)
        {
            int qty;
            
            int i = 0;
            while (i != 1)
            {
                Console.WriteLine($"How many of item {itemN} would you like to purchase?");
                Console.Write("I would like to buy: ");
                while (!int.TryParse(Console.ReadLine(), out qty))
                {
                    Console.WriteLine("Invalid number Try again.");
                    Console.Write("I would like to buy: ");
                }

                if (qty * itemprice <= currentbal)
                {
                    Console.WriteLine("It was a pleasure doing business with you.");
                    double salesfinal = 0 - (qty * itemprice);
                    Console.WriteLine($"That will be {Math.Abs(salesfinal)}, thank you for your business.");
                    Console.Clear();
                    i++;
                    

                    return (salesfinal, qty);
                    
                }
                else if (qty * itemprice > currentbal)
                {
                    Console.WriteLine($"You dont have enough to buy that many! you only have {currentbal}!");
                }
            }
            return (0.0,0);
        }
        public (double, int) ItemCostSell(int itemfetch, double currentbal, int itemprice, string itemN, int buysell, int currentamm)
        {
            int qty;

            int i = 0;
            while (i != 1)
            {
                Console.WriteLine($"How many of item {itemN} would you like to sell?");
                Console.Write("I would like to sell: ");
                while (!int.TryParse(Console.ReadLine(), out qty))
                {
                    Console.WriteLine("Invalid number Try again.");
                    Console.Write("I would like to sell: ");
                }

                if (qty <= currentamm)
                {
                    Console.WriteLine("It was a pleasure doing business with you.");
                    double salesfinal = (qty * itemprice);
                    Console.WriteLine($"That will be {Math.Abs(salesfinal)}, thank you for your business.");
                    i++;


                    return (salesfinal, qty);

                }
                else if (qty > currentamm)
                {
                    Console.WriteLine($"You dont have enough to sell!!! you only have {currentamm} {itemN}!");
                }
            }
            return (0.0, 0);
        }
    }

}
