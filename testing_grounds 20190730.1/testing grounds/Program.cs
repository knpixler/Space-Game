using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using TestingGroundsClassLibrary;


namespace testing_grounds
{
    class Program
    {
        static void Main(string[] args)
        {
            var play = new Player();
            var plan = new Planets();
            var item = new Itemized();
            var move = new Movement();

            //gold from pluto not updating wallaet balance on buy
            Player.WelcomeInstruction();


            //Ship.Picture();
           Player.CharChoose();
           Ship.Warp();
            double currentbal = 1000;
            int currentplanet = 1;
            double update = 0;

            while (currentbal < 50000)
            {
                play.Turns();
                
                
                plan.Welcome(currentplanet);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Your current wallet balance is {currentbal}");
                Console.ResetColor();

                var buysell = plan.BuySell();
                if (buysell == 3)
                {
                    Console.Clear();
                    //currentplanet = plan.PlanetChoose(currentplanet);
                    currentplanet = move.ShipMove(currentplanet);
                    Console.WindowWidth = 128;
                    var Pname = plan.PName(currentplanet);
                    Console.WriteLine($"Landing on {Pname}");
                    Thread.Sleep(1000);
                    Ship.Warp();
                }
                else if (buysell == 1)
                {
                    var itemfetch = plan.PlanetBuy(currentplanet);
                    var itemprice = item.ItemPrice(itemfetch, currentplanet, buysell);
                    var itemN = item.ItemString(itemfetch);
                    var (salesfinal, qty) = item.ItemCostBuy(itemfetch, currentbal, itemprice, itemN, buysell);
                    update = salesfinal;
                    play.InventoryUpdate(qty, itemfetch, itemN, buysell);
                    currentbal = play.Wallet(update);
                    
                    Console.WriteLine($"Wallet Balance is now "+ currentbal);
                   
                }
                else if (buysell == 2)
                {
                    var itemfetch = plan.PlanetSell(currentplanet);
                    var itemprice = item.ItemPrice(itemfetch, currentplanet, buysell);
                    int qty = 0;
                    double salesfinal;
                    buysell = 5;
                    var itemN = item.ItemString(itemfetch);
                    var currentamm = play.InventoryUpdate(qty, itemfetch, itemN, buysell);
                    buysell = 2;
                    (salesfinal, qty) = item.ItemCostSell(itemfetch, currentbal, itemprice, itemN, buysell, currentamm);
                    play.InventoryUpdate(qty, itemfetch, itemN, buysell);
                    update = salesfinal;
                    currentbal = play.Wallet(update);
                    Console.WriteLine($"Wallet Balance is now " + currentbal);

                }
                else if (buysell == 4)
                {
                    int itemfetch = 9, qty = 0;
                    string itemN = "";
                    play.InventoryUpdate(qty, itemfetch, itemN, buysell);
                }
            }
            Console.WriteLine("CONGRATULATIONS!!! YOU'VE WON!!! YOU'RE SPACE RICH!!!\n(press ENTER to exit)");
            Console.Read();

            //add more here for the game end. Current balance 
        }

    }
}
