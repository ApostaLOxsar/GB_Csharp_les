/*using System.Threading;

Console.Clear();

Random randomNumber = new Random();
string endText = "ApostaL_Oxsar";
header.TextColor = Color.FromRgba(0, 255, 0, 100);

for (int i = 0; i < 30; i++)
{
    int endTextPrintSim = randomNumber.Next(endText.Length);
    Console.SetCursorPosition(100 - (endText.Length - endTextPrintSim), 0);
    Console.Write(endText[endTextPrintSim]);
    Thread.Sleep(50);
}*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

string[] colors = Enum.GetNames(typeof(ConsoleColor));
for (int i = 0; i < colors.Length; i++)
{
    Console.WriteLine(colors[i]);
}

