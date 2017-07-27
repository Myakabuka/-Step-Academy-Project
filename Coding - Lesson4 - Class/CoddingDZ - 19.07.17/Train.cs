using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    partial class Train
    {
        public void Show()
        {
            double distance=0;
            GetDistance(ref distance);
            Console.WriteLine("Поезд с нумерацией " + _trainNumeral + " движется к пункту " 
                + _placeOfArrival + " со средней скоростью " + _averageSpeed + " на преодоление расстояния в " 
                + distance + " метров, понадобится приблизительно " + _travelTime + " минут." );
            Console.WriteLine("Нажмите \"Enter\" чтобы продолжить...");
            Console.ReadLine();
        }
    }
}
