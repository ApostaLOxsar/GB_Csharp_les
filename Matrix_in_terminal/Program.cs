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
        static int fastFlow = flowSpeed + 180; //
        static int textFlow = flowSpeed + 500; //время ускорения

        static ConsoleColor basecolor = ConsoleColor.DarkGreen;
        static ConsoleColor cyancolor = ConsoleColor.Cyan;
        static ConsoleColor fadedcolor = ConsoleColor.White;


        static String endText = "ApostaL_oxsar";

        static char Asciicharacters
        {
            /*get
            {
                int t = randomPosition.Next(10);

                if (t <= 2) return (char)('0' + randomPosition.Next(10));
                else if (t <= 4) return (char)(c);
                else if (t <= 6) return (char)(c);
                else return (char)(randomPosition.Next(32, 255));

            }
            */
            /*
            get
            {
                int t = randomPosition.Next(10);

                if (t <= 2) return (char)('0' + randomPosition.Next(0x0C00, 0x0C04));
                else if (t <= 4) return (char)('1' + randomPosition.Next(0x0C05, 0x0C14));
                else if (t <= 6) return (char)('A' + randomPosition.Next(0x0C15, 0x0C39));
                else return (char)(randomPosition.Next(32, 255));

            }*/
            get
            {
                int t = randomPosition.Next(10);

                if (t <= 2) return (char)('0' + randomPosition.Next(10));
                else if (t <= 4) return (char)('а' + randomPosition.Next(32));
                else if (t <= 6) return (char)('А' + randomPosition.Next(32));
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
                if (Counter > (2 * flowSpeed))
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

        private static void ColumnUpdate(int width, int height, int[] y)
        {
            int x
                , k3 = 5
                , k4 = 9;
            if (Counter < flowSpeed)//0-200
            {
                for (x = 0; x < width; ++x)
                {
                    if (x % 10 == k3) Console.ForegroundColor = cyancolor;
                    else if (x % 10 == k4) Console.ForegroundColor = fadedcolor;
                    else Console.ForegroundColor = basecolor;

                    /*if (x % 10 == 1) Console.ForegroundColor = fadedcolor;
                    else Console.ForegroundColor = basecolor;

                    if (x % 10 == 9) Console.ForegroundColor = fadedcolor;
                    else Console.ForegroundColor = basecolor;*/

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
            else if (Counter > flowSpeed && Counter < textFlow) //200-200
            {
                for (x = 0; x < width; ++x)
                {
                    if (x % 10 == k3) Console.ForegroundColor = cyancolor;
                    else if (x % 10 == k4) Console.ForegroundColor = fadedcolor;
                    else Console.ForegroundColor = basecolor;

                    Console.SetCursorPosition(x, y[x]);

                    /*if (x % 10 == 9) Console.ForegroundColor = fadedcolor;
                    else Console.ForegroundColor = basecolor;*/

                    Console.Write(Asciicharacters);

                    y[x] = YPositionFields(y[x] + 1, height);
                }
            }
            else if (Counter > fastFlow) //200-400
            {
                for (x = 0; x < width; ++x)
                {
                    Console.SetCursorPosition(x, y[x]);
                    Console.Write(' ');

                    int temp1 = y[x] - 20;
                    Console.SetCursorPosition(x, YPositionFields(temp1, height));
                    Console.Write(' ');

                    if (Counter > fastFlow && Counter < textFlow) 
                    {
                        if (x % 10 == k3) Console.ForegroundColor = cyancolor;
                        else if (x % 10 == k4) Console.ForegroundColor = fadedcolor;
                        else Console.ForegroundColor = basecolor;

                        int temp = y[x] - 2;
                        Console.SetCursorPosition(x, YPositionFields(temp, height));
                        Console.Write(Asciicharacters);
                    }
                    //Console.SetCursorPosition(width / 2, height / 2);
                    //Console.Write(endText);
                    //y[x] = YPositionFields(y[x] + 1, height);
                }
            }
        }
    }
}