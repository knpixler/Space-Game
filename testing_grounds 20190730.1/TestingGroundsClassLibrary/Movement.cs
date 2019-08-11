using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Media;

namespace testing_grounds
{
    public class Movement
    {
        public int ShipMove(int currentplanet)
        {

            //int currentplanet = 5;
            Console.WindowHeight = 32;
            Console.WindowWidth = 64;
            int screenwidth = Console.WindowWidth;
            int screenheight = Console.WindowHeight;
            Random randomnummer = new Random();
            int score = 5;

            pixel ship = new pixel();

            //this is where the ship starts make this the current planet position - 1 or 2 pixels for xpos




            string movement = "RIGHT";
            List<int> xposlijf = new List<int>();
            List<int> yposlijf = new List<int>();

            //THIS IS THE BERRY start POSITIONING.
            //int berry1x = randomnummer.Next(0, screenwidth);
            //int berry1y = randomnummer.Next(0, screenheight);

            int berry1x = screenwidth / 4;
            int berry1y = screenheight / 4;

            int berry2x = (3 * (screenwidth / 4));
            int berry2y = (3 * (screenheight / 4));

            int berry3x = (2 * (screenwidth / 4));
            int berry3y = (2 * (screenheight / 4));

            int berry4x = (screenwidth / 4);
            int berry4y = (3 * (screenheight / 4));

            int berry5x = (6 * (screenheight / 4));
            int berry5y = (screenwidth / 8);

            if (currentplanet == 1)
            {
                ship.xpos = (screenwidth / 4) + 1;
                ship.ypos = (screenheight / 4) + 1;
                ship.schermkleur = ConsoleColor.Red;
            }
            else if (currentplanet == 2)
            {
                ship.xpos = (3 * (screenwidth / 4)) + 1;
                ship.ypos = (3 * (screenheight / 4)) + 1;
                ship.schermkleur = ConsoleColor.Red;
            }
            else if (currentplanet == 3)
            {
                ship.xpos = (2 * (screenwidth / 4)) + 1;
                ship.ypos = (2 * (screenheight / 4)) + 1;
                ship.schermkleur = ConsoleColor.Red;
            }
            else if (currentplanet == 4)
            {
                ship.xpos = (screenwidth / 4) + 1;
                ship.ypos = (3 * (screenheight / 4)) + 1;
                ship.schermkleur = ConsoleColor.Red;
            }
            else if (currentplanet == 5)
            {
                ship.xpos = (6 * (screenheight / 4)) + 1;
                ship.ypos = (screenwidth / 8) + 1;
                ship.schermkleur = ConsoleColor.Red;
            }


            DateTime tijd = DateTime.Now;
            DateTime tijd2 = DateTime.Now;
            string buttonpressed = "no";

            // We only draw the border once. It doesn't change.
            DrawBorder(screenwidth, screenheight);

            while (true)
            {
                ClearConsole(screenwidth, screenheight);
                if (ship.xpos == screenwidth - 1)
                {
                    ship.xpos = 1;
                }
                if (ship.xpos == 0)
                {
                    ship.xpos = screenwidth - 2;
                }
                if (ship.ypos == screenheight - 1)
                {
                    ship.ypos = 1;
                }
                if (ship.ypos == 0)
                {
                    ship.ypos = screenheight - 2;
                }



                //  THIS IS WHERE THE SHIP HITS THE BERRY

                Console.ForegroundColor = ConsoleColor.Green;
                if (berry1x == ship.xpos && berry1y == ship.ypos)
                {
                    currentplanet = 1;
                    Console.Clear();
                    Console.WriteLine("You are now on earth");
                    Thread.Sleep(1000);
                    break;
                }
                if (berry2x == ship.xpos && berry2y == ship.ypos)
                {
                    currentplanet = 2;
                    Console.Clear();
                    Console.WriteLine("You are now on Jupiter");
                    Thread.Sleep(1000);
                    break;
                }
                if (berry3x == ship.xpos && berry3y == ship.ypos)
                {
                    currentplanet = 3;
                    Console.Clear();
                    Console.WriteLine("You are now on Pluto");
                    Thread.Sleep(1000);
                    break;
                }
                if (berry4x == ship.xpos && berry4y == ship.ypos)
                {
                    currentplanet = 4;
                    Console.Clear();
                    Console.WriteLine("You are now at the Sun Lounge");
                    Thread.Sleep(1000);
                    break;
                }
                if (berry5x == ship.xpos && berry5y == ship.ypos)
                {
                    currentplanet = 5;
                    Console.Clear();
                    Console.WriteLine("You are now on Mars");
                    Thread.Sleep(1000);
                    break;
                }




                //THIS MOVES THE SHIP
                Console.SetCursorPosition(ship.xpos, ship.ypos);
                Console.ForegroundColor = ship.schermkleur;
                Console.Write("■");

                //writes the berry
                Console.SetCursorPosition((berry1x + 1), berry1y);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Earth");
                Console.SetCursorPosition(berry1x, berry1y);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("■");

                Console.SetCursorPosition((berry2x + 1), berry2y);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Jupiter");
                Console.SetCursorPosition(berry2x, berry2y);
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("■");

                Console.SetCursorPosition((berry3x + 1), berry3y);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Pluto");
                Console.SetCursorPosition(berry3x, berry3y);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("■");

                Console.SetCursorPosition((berry4x + 1), berry4y);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("The Sun Lounge");
                Console.SetCursorPosition(berry4x, berry4y);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("■");

                Console.SetCursorPosition((berry5x + 1), berry5y);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Mars");
                Console.SetCursorPosition(berry5x, berry5y);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("■");


                //THIS MOVES THE SHIP
                Console.CursorVisible = false;
                tijd = DateTime.Now;
                buttonpressed = "no";

                while (true)
                {
                    tijd2 = DateTime.Now;
                    if (tijd2.Subtract(tijd).TotalMilliseconds > 250) { break; }
                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo toets = Console.ReadKey(true);
                        //Console.WriteLine(toets.Key.ToString());
                        if (toets.Key.Equals(ConsoleKey.UpArrow) && movement != "DOWN" && buttonpressed == "no")
                        {
                            movement = "UP";
                            buttonpressed = "yes";
                            //(new SoundPlayer(@"c:\Users\knpix\OneDrive\Desktop\SPACEGAME BACKUP LOG\testing_grounds 20190730.1\Slow_Motion_Warp-CouchMango-1259869864.wav")).PlaySync();

                        }
                        if (toets.Key.Equals(ConsoleKey.DownArrow) && movement != "UP" && buttonpressed == "no")
                        {
                            movement = "DOWN";
                            buttonpressed = "yes";
                            //(new SoundPlayer(@"c:\Users\knpix\OneDrive\Desktop\SPACEGAME BACKUP LOG\testing_grounds 20190730.1\Slow_Motion_Warp-CouchMango-1259869864.wav")).PlaySync();

                        }
                        if (toets.Key.Equals(ConsoleKey.LeftArrow) && movement != "RIGHT" && buttonpressed == "no")
                        {
                            movement = "LEFT";
                            buttonpressed = "yes";
                            //(new SoundPlayer(@"c:\Users\knpix\OneDrive\Desktop\SPACEGAME BACKUP LOG\testing_grounds 20190730.1\Slow_Motion_Warp-CouchMango-1259869864.wav")).PlaySync();

                        }
                        if (toets.Key.Equals(ConsoleKey.RightArrow) && movement != "LEFT" && buttonpressed == "no")
                        {
                            movement = "RIGHT";
                            buttonpressed = "yes";
                            //(new SoundPlayer(@"c:\Users\knpix\OneDrive\Desktop\SPACEGAME BACKUP LOG\testing_grounds 20190730.1\Slow_Motion_Warp-CouchMango-1259869864.wav")).PlaySync();

                        }
                    }
                }
                xposlijf.Add(ship.xpos);
                yposlijf.Add(ship.ypos);
                switch (movement)
                {
                    case "UP":
                        ship.ypos--;
                        break;
                    case "DOWN":
                        ship.ypos++;
                        break;
                    case "LEFT":
                        ship.xpos--;
                        break;
                    case "RIGHT":
                        ship.xpos++;
                        break;
                }
                if (xposlijf.Count() > score)
                {
                    xposlijf.RemoveAt(0);
                    yposlijf.RemoveAt(0);
                }
            }
                    //(new SoundPlayer(@"c:\Users\knpix\OneDrive\Desktop\SPACEGAME BACKUP LOG\testing_grounds 20190730.1\Slow_Motion_Warp-CouchMango-1259869864.wav")).PlaySync();



            //Console.WriteLine(currentplanet);
            return currentplanet;
            //Console.SetCursorPosition(screenwidth / 5, screenheight / 2);
            //Console.WriteLine("Game over, Score: " + score);
            //Console.SetCursorPosition(screenwidth / 5, screenheight / 2 + 1);
        }

        private static void ClearConsole(int screenwidth, int screenheight)
        {
            var blackLine = string.Join("", new byte[screenwidth - 2].Select(b => " ").ToArray());
            Console.ForegroundColor = ConsoleColor.Black;
            for (int i = 1; i < screenheight - 1; i++)
            {
                Console.SetCursorPosition(1, i);
                Console.Write(blackLine);
            }
        }

        private static void DrawBorder(int screenwidth, int screenheight)
        {
            var horizontalBar = string.Join("", new byte[screenwidth].Select(b => "■").ToArray());

            Console.SetCursorPosition(0, 0);
            Console.Write(horizontalBar);
            Console.SetCursorPosition(0, screenheight - 1);
            Console.Write(horizontalBar);

            for (int i = 0; i < screenheight; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("■");
                Console.SetCursorPosition(screenwidth - 1, i);
                Console.Write("■");
            }
        }

        class pixel
        {
            public int xpos { get; set; }
            public int ypos { get; set; }
            public ConsoleColor schermkleur { get; set; }
        }
    }
}
