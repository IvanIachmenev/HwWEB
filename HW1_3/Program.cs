using System;

namespace HW_1_3
{
    class Program
    {
        static void Opar()
        {
            Console.WriteLine("V = S(площадь основания) * h(высота)");
            Console.WriteLine("Введите S и h в заданном порядке");
            var S = Convert.ToInt32(Console.ReadLine());
            var h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"V = S * h = {S} * {h} = " + (S*h));
        }

        static void Acceleration_formula()
        {
            Console.WriteLine("a(ускорение) = (V(конечная скорость) - V0(начальная скорость)) / t(время)");
            Console.WriteLine("Введите V, V0, t в заданном порядке");
            var V = Convert.ToInt32(Console.ReadLine());
            var V0 = Convert.ToInt32(Console.ReadLine());
            var t = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"a = (V - V0) / t = ({V} - {V0}) / {t} = " + ((V - V0) / t));
        }

        static void TheWeightOfTheBodyMovingWithAcceleration()
        {
            Console.WriteLine("P(Вес тела) = m(масса тела) * (g(ускорение свободного падения) + a(ускорение))");
            Console.WriteLine("Введите m, a в заданном порядке");
            const int g = 10;
            var m = Convert.ToInt32(Console.ReadLine());
            var a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"P = m * (g + a) = {m} * ({g} + {a}) = " + (m * (g + a)));
        }

        static void KineticEnergy()
        {
            Console.WriteLine("Ek(средняя кинетическая энергия) = 3/2 * k(1.38 * 10^(-23)) * T(абсолютная температура в кельвинах))");
            Console.WriteLine("Введите t в градусах цельсия");
            var t = Convert.ToInt32(Console.ReadLine()) + 273;
            var k = Math.Pow(1.38, -23);
            Console.WriteLine($"Ek = 3/2 * k * (t + 273) = 3/2 * (1.38^(-23)) * {t} = " + ((3/2) * k * t));
        }

        static void Main(string[] args)
        {
            Console.Write("Выберите одну из четырех фомул, введя косноль ее номер:\n 1.Объем прямоугольного паралепипеда\n 2.Формулу ускорения\n");
            Console.WriteLine(" 3.Вес тела движуйщийся с положительным ускорением\n 4.Cр. кин. энергия молекул одноатомного газа");
            
            var i = Convert.ToInt32(Console.ReadLine());
            
            switch (i)
            {
                case 1:
                    Opar();
                break;
                case 2:
                    Acceleration_formula();
                break;
                case 3:
                    TheWeightOfTheBodyMovingWithAcceleration();
                break;
                case 4:
                    KineticEnergy();
                break;
                default:
                    Console.WriteLine("Нет такой формулы.");
                break;
            }
        }
    }
}
