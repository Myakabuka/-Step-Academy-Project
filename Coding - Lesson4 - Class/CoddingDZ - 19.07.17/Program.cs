using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public partial class Train
    {
        private string _trainNumeral;
        private int _carriageCount;
        private static string _departurePoint;
        private string _placeOfArrival;
        private int _travelTime;
        private DateTime _formationStartTime;
        private double _averageSpeed;
        private bool _trainForPeople;

        public Train()
        {
            _trainNumeral = "";
            _carriageCount = 0;
            _placeOfArrival = "";
            _travelTime = 0;
            _formationStartTime = System.DateTime.Now;
            _averageSpeed = 0.0;
            _trainForPeople = false;
        }

        static Train()
        {
            _departurePoint = "Астана";
        }

        public Train(string trainNumeral, int carriageCount, string placeOfArrival, int travelTime, double averageSpeed, bool trainForPeople)
        {
            SetTrainNumeral(trainNumeral);
            SetCarriageCount(carriageCount);
            SetPlaceOfArriavel(placeOfArrival);
            SetTravelTime(travelTime);
            _formationStartTime = System.DateTime.Now;
            SetAverageSpeed(averageSpeed);
            SetTrainForPeople(trainForPeople);
        }

        public void GetDistance(ref double distance)
        {
            distance = _averageSpeed * _travelTime;
        }

        public string GetTrainNumeral()
        {
            return _trainNumeral;
        }

        public void SetTrainNumeral(string trainNumeral)
        {
            _trainNumeral = trainNumeral;
        }

        public int GetCarriageCount()
        {
            return _carriageCount;
        }

        public void SetCarriageCount(int carriageCount)
        {
            _carriageCount = carriageCount;
        }

        public string GetPlaceOfArriavel()
        {
            return _placeOfArrival;
        }

        public void SetPlaceOfArriavel(string placeOfArrival)
        {
            _placeOfArrival = placeOfArrival;
        }

        public int GetTravelTime()
        {
            return _travelTime;
        }

        public void SetTravelTime(int travelTime)
        {
            _travelTime = travelTime;
        }

        public double GetAverageSpeed()
        {
            return _averageSpeed;
        }

        public void SetAverageSpeed(double averageSpeed)
        {
            _averageSpeed = averageSpeed;
        }

        public bool GetTrainForPeople()
        {
            return _trainForPeople;
        }

        public void SetTrainForPeople(bool trainForPeople)
        {
            _trainForPeople = trainForPeople;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Train[] trains = new Train[2];

            for(int i=0;i<trains.Length;++i)
            {
                Console.Clear();
                Console.WriteLine("Введите нумерацию поезда: ");
                string trainNumeral = Console.ReadLine();

                Console.WriteLine("Введите количество вагонов в поезде: ");
                int carriageCount;
                bool tryParse = Int32.TryParse(Console.ReadLine(), out carriageCount);

                Console.WriteLine("Введите место прибытия поезда: ");
                string placeOfArrival = Console.ReadLine();

                Console.WriteLine("Введите время затрачиваемое на дорогу время (в минутах): ");
                int trivalTime;
                tryParse = Int32.TryParse(Console.ReadLine(), out trivalTime);

                Console.WriteLine("Введите среднюю скорость поезда(метров в минуту): ");
                double averageSpeed;
                tryParse = Double.TryParse(Console.ReadLine(), out averageSpeed);

                Console.WriteLine("Предназначен ли поезд для транспортировки людей (true,false): ");
                bool trainForPeople;
                tryParse = bool.TryParse(Console.ReadLine(), out trainForPeople);

                trains[i] = new Train(trainNumeral, carriageCount, placeOfArrival, trivalTime, averageSpeed, trainForPeople);
            }

            for (int i = 0; i < trains.Length; ++i)
            {
                trains[i].Show();
            }
        }
    }
}