using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;



class Program
{
    static int Counter;
    static Random randomPosition = new Random();
    static Random randomNumber = new Random();

        static String endText = "ApostaL_oxsar"; //никнейм

    static char Asciicharacters //генерация символа
    {
        get
        {
            int t = randomPosition.Next(9);

            if (t <= 2) return (char)('0' + randomPosition.Next(10));
            else if (t <= 4) return (char)('a' + randomPosition.Next(26));
            else if (t <= 8) return (char)('A' + randomPosition.Next(26));
            else return (char)(randomPosition.Next(32, 255));
        }
    }
    static void Main()
    {
        //CallBack();
        Console.ForegroundColor = ConsoleColor.DarkGreen; //basecolor;
        Console.WindowLeft = Console.WindowTop = 0;
        Console.WindowHeight = Console.BufferHeight = Console.LargestWindowHeight;
        Console.WindowWidth = Console.BufferWidth = Console.LargestWindowWidth;
        Console.SetWindowPosition(0, 0);
        Console.CursorVisible = false;

        int whidth, height;
        int[] y;
        AutoResetEvent waitHandler = new AutoResetEvent(true);
        Initialize(out whidth, out height, out y);
        Person whidthHeightYForTherad1 = new Person(whidth, height, y);
        /* Thread myThread1 = new Thread(whidthHeightYForTherad1.myThread1);
         Thread myThread2 = new Thread(whidthHeightYForTherad1.myThread2);
         Thread myThread3 = new Thread(whidthHeightYForTherad1.myThread3);*/

            while (true) ColumnUpdate(whidth, height, y);
        }

        public static int YPositionFields(int yPosition, int height) //ограничение выхожа за границы 
        {
            if (yPosition < 0) return yPosition + height;
            if (yPosition < height) return yPosition;
            return 0;

    }

    private static void Initialize(out int width, out int height, out int[] y) //определение разрешение и генерация масива связи х с у
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
              , k3 = 10
              , k4 = 20;
            y[0] = YPositionFields(y[0] + 1, height);
            for (x = 0; x < width; x = x + 2) // 0 2 4 8 10 12 14 16 18 20
            {
                if (x % 30 == k3) Console.ForegroundColor = ConsoleColor.White;
                else if (x % 30 == k4) Console.ForegroundColor = ConsoleColor.DarkBlue;
                else Console.ForegroundColor = ConsoleColor.DarkGreen;

                int temp = y[x] - 2;  //печать символа
                Console.SetCursorPosition(x, YPositionFields(temp, height));
                Console.Write(Asciicharacters);

                int temp1 = y[x] - 20; // печать пробела(пустое место)
                Console.SetCursorPosition(x, YPositionFields(temp1, height));
                Console.Write(' ');

                if (x == width / 5 || x == width / 2) //печать никнейма
                {
                    int endTextPrintSim = randomNumber.Next(endText.Length);
                    Console.SetCursorPosition(width - (endText.Length - endTextPrintSim), height - 1);
                    Console.Write(endText[endTextPrintSim]);
                }

                y[x] = YPositionFields(y[x] + 1, height);
            }
        }
    }
}