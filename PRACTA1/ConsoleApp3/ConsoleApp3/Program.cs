using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        class Car
        {
            public int MaxSpeed;
            public string NameCar;
            public Car(int MaxSpeed, string NameCar)
            {
                this.NameCar = NameCar;
                this.MaxSpeed = MaxSpeed;
            }
            //Вычисление времени гонщика в часах
            public double CountTime(double distance)
            {
                return distance / MaxSpeed;
            }
        }
        class pro
        {
            static void Main(string[] args)
            {
                int distance = 50;
                string win = "";
                //Генерация значений скорости
                Random rndSpeed = new Random();
                int[] MaxSpeed = {
                rndSpeed.Next(200, 360),
                rndSpeed.Next(200, 360),
                rndSpeed.Next(200, 360),
                rndSpeed.Next(200, 360)
             };

                //Генерация номеров гонщиков
                Random rndNum = new Random();
                string[] RiderNumber = {
                "Rider number-" + rndNum.Next(1, 10),
                "Rider number-" + rndNum.Next(1, 10),
                "Rider number-" + rndNum.Next(1, 10),
                "Rider number-" + rndNum.Next(1, 10)
              };

                //Инициализация классов с конструкторами
                Car car1 = new Car(MaxSpeed[0], RiderNumber[0]);
                Car car2 = new Car(MaxSpeed[1], RiderNumber[1]);
                Car car3 = new Car(MaxSpeed[2], RiderNumber[2]);
                Car car4 = new Car(MaxSpeed[3], RiderNumber[3]);

                //Расчёт времени движения гонщика в часах
                double[] timeZ = {
                car1.CountTime(distance),
                car2.CountTime(distance),
                car3.CountTime(distance),
                car4.CountTime(distance)
              };

                //Определение победителя
                double winner = timeZ.Min();
                if (winner == timeZ[0])
                    win = RiderNumber[0];
                else if (winner == timeZ[1])
                    win = RiderNumber[1];
                else if (winner == timeZ[2])
                    win = RiderNumber[2];
                else if (winner == timeZ[3])
                    win = RiderNumber[3];

                //Вывод результатов
                Console.WriteLine($"Race " +
                $"\nDistance 50Км " +
                $"\n\tWinner: \"{win}\"" +
                $"\n{car1.NameCar}, \tV = {car1.MaxSpeed} Км/ч, t = {timeZ[0]:f2} ч;" +
                $"\n{car2.NameCar}, \tV = {car2.MaxSpeed} Км/ч, t = {timeZ[1]:f2} ч;" +
                $"\n{car3.NameCar}, \tV = {car3.MaxSpeed} Км/ч, t = {timeZ[2]:f2} ч;" +
                $"\n{car4.NameCar}, \tV = {car4.MaxSpeed} Км/ч, t = {timeZ[3]:f2} ч;");
                Console.ReadKey(true);
            }
        }
    }
}

