using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testtttt_matrix2
{
    class Program
    {
        static int Counter;
        static Random randomPosition = new Random();
        static Random randomNumber = new Random();



        static int flowSpeed = 200;
        static int fastFlow = flowSpeed + 60; //время удаление// 240
        static int textFlow = flowSpeed + 40; //время ускорения//240

        /*static ConsoleColor basecolor = ConsoleColor.DarkGreen;
         static ConsoleColor cyancolor = ConsoleColor.Cyan;
         static ConsoleColor fadedcolor = ConsoleColor.White;*/
        static ConsoleColor basecolor = ConsoleColor.DarkGreen;
        static ConsoleColor cyancolor = ConsoleColor.DarkGreen;
        static ConsoleColor fadedcolor = ConsoleColor.DarkGreen;



        static String endText = "ApostaL_oxsar";

        static char Asciicharacters
        {
            get
            {
                int t = randomPosition.Next(10);

                if (t <= 5) return (char)('0' + randomPosition.Next(10));
                else if (t <= 6) return (char)('а' + randomPosition.Next(32));
                else if (t <= 8) return (char)('А' + randomPosition.Next(32));
                else return (char)(randomPosition.Next(32, 255));

            }
        }
        static void Main()
        {

            Console.ForegroundColor = basecolor;
            Console.WindowLeft = Console.WindowTop = 0;
            Console.WindowHeight = Console.BufferHeight = Console.LargestWindowHeight;
            Console.WindowWidth = Console.BufferWidth = Console.LargestWindowWidth;
            Console.SetWindowPosition(0, 0);
            Console.CursorVisible = false;

            int whidth, height;
            int[] y;
            Initialize(out whidth, out height, out y);

            while (true)
            {

                Counter++;
                ColumnUpdate(whidth, height, y);
                if (Counter > (1 * flowSpeed))
                Counter = 0;
            }
        }

        public static int YPositionFields(int yPosition, int height)
        {
            if (yPosition < 0) return yPosition + height;
            else if (yPosition < height) return yPosition;
            else return 0;

        }

        private static void Initialize(out int width, out int height, out int[] y)
        {
            height = Console.WindowHeight;
            width = Console.WindowWidth - 1;
            y = new int[width];
            Console.Clear();

            for (int x = 0; x < width; ++x)
            {
                y[x] += randomPosition.Next(height);
            }
        }

        private static void ColumnUpdate(int width, int height, int[] y) //count <600
        {
            int x
                , k3 = 5
                , k4 = 9;
            if (Counter <= flowSpeed)//0-200
            {
                y[0] = YPositionFields(y[0] + 1, height);
                for (x = 0; x < width; ++x)
                {
                    if (x % 10 == k3) Console.ForegroundColor = cyancolor;
                    else if (x % 10 == k4) Console.ForegroundColor = fadedcolor;
                    else Console.ForegroundColor = basecolor;

                    Console.SetCursorPosition(x, y[x]);
                    Console.Write(Asciicharacters);

                    int temp = y[x] - 2;
                    Console.SetCursorPosition(x, YPositionFields(temp, height));
                    Console.Write(Asciicharacters);

                    int temp1 = y[x] - 20;
                    Console.SetCursorPosition(x, YPositionFields(temp1, height));
                    Console.Write(' ');
                    y[x] = YPositionFields(y[x] + 1, height);
                }
            }
            else if (Counter >= flowSpeed && Counter < textFlow) //200-240
            {
                y[0] = YPositionFields(y[0] + 1, height);
                for (x = 0; x < width; ++x)
                {
                    if (x % 10 == k3) Console.ForegroundColor = cyancolor;
                    else if (x % 10 == k4) Console.ForegroundColor = fadedcolor;
                    else Console.ForegroundColor = basecolor;

                    y[x] = YPositionFields(y[x] + 1, height);

                    Console.SetCursorPosition(x, y[x]);
                    Console.Write(Asciicharacters);

                }
            }
            else if (Counter >= fastFlow /*&& Counter < 300*/) //240-360
            {
                y[0] = YPositionFields(y[0] + 1, height);
                for (x = 0; x < width; ++x)
                {
                    int temp = y[x] - 20;
                    Console.SetCursorPosition(x, YPositionFields(temp, height));
                    Console.Write(' ');

                    y[x] = YPositionFields(y[x] + 1, height);
                }
            }
            /*else if (Counter >= 300)
            {
                Console.SetCursorPosition(width / 2 - 76, height / 2);
                Console.Write("        ____     _        __                                   __                   __                            __                          ");
                Console.SetCursorPosition(width / 2 - 76, height / 2 + 1);
                Console.Write("       / __  |  (_)  ____/ /   _____           ____   ____    / /  __  __  _____   / /_   ____ _   __  __  ___   / /_   _____   __  __  ____ _");
                Console.SetCursorPosition(width / 2 - 76, height / 2 + 2);
                Console.Write("      / /_/ /  / /  / __  /   / ___/          / __ | / __ |  / /  / / / / / ___/  / __ | / __ `/  / / / / / _ | / __/  / ___/  / / / / / __ `/");
                Console.SetCursorPosition(width / 2 - 76, height / 2 + 3);
                Console.Write("     / ____/  / /  / /_/ /   / /             / /_/ // /_/ / / /  / /_/ / / /__   / / / // /_/ /  / /_/ / /  __// /_   (__  )  / /_/ / / /_/ / ");
                Console.SetCursorPosition(width / 2 - 76, height / 2 + 4);
                Console.Write("    /_/      /_/   |__,_/   /_/             / .___/ |____/ /_/   |__,_/  |___/  /_/ /_/ |__,_/   |__, /  |___/ |__/  /____/   |__, /  |__,_/  ");
                Console.SetCursorPosition(width / 2 - 76, height / 2 + 5);
                Console.Write("                                           /_/                                                  /____/                       /____/           ");

            }*/
        }
    }
}