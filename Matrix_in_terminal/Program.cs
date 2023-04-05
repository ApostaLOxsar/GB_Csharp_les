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



    static int flowSpeed = 200;
    static int fastFlow = flowSpeed + 40; //время удаление// 240
    static int textFlow = flowSpeed + 40; //время ускорения//240
    static int textEnd = flowSpeed + 0;



    static string[] colors = Enum.GetNames(typeof(ConsoleColor));
    static int index = 0;

    /*static ConsoleColor basecolor = ConsoleColor.DarkGreen;
     static ConsoleColor cyancolor = ConsoleColor.Cyan;
     static ConsoleColor fadedcolor = ConsoleColor.White;*/
    /*static ConsoleColor basecolor = ConsoleColor.DarkGreen;
    static ConsoleColor cyancolor = ConsoleColor.DarkGreen;
    static ConsoleColor fadedcolor = ConsoleColor.DarkGreen;*/



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

        while (true)
        {
            Thread myThread1 = new Thread(whidthHeightYForTherad1.myThread1);
            Thread myThread2 = new Thread(whidthHeightYForTherad1.myThread2);
            Thread myThread3 = new Thread(whidthHeightYForTherad1.myThread3);


            myThread1.Start();
            myThread2.Start();
            myThread3.Start();
            /*myThread1.Join();
            myThread2.Join();
            myThread3.Join();*/
        }
    }

    static void CallBack()
    {
        Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), colors[index]);
        index = new Random().Next(colors.Length);
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

    record class Person(int width, int height, int[] y)
    {
        AutoResetEvent waitHandler = new AutoResetEvent(true);
       // y[0] = YPositionFields(y[0] + 1, height);
        public void myThread1()
        {
            waitHandler.WaitOne();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            int x;
            //y[0] = YPositionFields(y[0] + 1, height);

            for (x = 1; x < width / 3; ++x)
            {
                y[x] = YPositionFields(y[x] + 1, height);
             
                int temp = y[x] - 2;  //печать символа
                Console.SetCursorPosition(x, YPositionFields(temp, height));
                Console.Write(Asciicharacters);

                int temp1 = y[x] - 20; // печать пробела(пустое место)
                Console.SetCursorPosition(x, YPositionFields(temp1, height));
                Console.Write(' ');

            }
            waitHandler.Set();
        }
        public void myThread2()
        {
            waitHandler.WaitOne();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            int x;
            //y[0] = YPositionFields(y[0] + 1, height);

            for (x = width / 3; x < width * 2 / 3; ++x)
            {
                y[x] = YPositionFields(y[x] + 1, height);
             
                int temp = y[x] - 2;  //печать символа
                Console.SetCursorPosition(x, YPositionFields(temp, height));
                Console.Write(Asciicharacters);

                int temp1 = y[x] - 20; // печать пробела(пустое место)
                Console.SetCursorPosition(x, YPositionFields(temp1, height));
                Console.Write(' ');

            }
            waitHandler.Set();
        }
        public void myThread3()
        {
            waitHandler.WaitOne();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            int x;
           // y[0] = YPositionFields(y[0] + 1, height);

            for (x = width * 2 / 3; x < width; ++x)
            {
                y[x] = YPositionFields(y[x] + 1, height);
             
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

            }
            waitHandler.Set();
        }

    }

    /*static void ColumnUpdate(int width, int height, int[] y)
    {
        if (Counter <= flowSpeed)//0-200
        {
            myThread11.Start();
            myThread21.Start();
            myThread11.Join();
        }
    }*/
}
