using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric
{
    internal class GeometricProgression
    {
        public double a;  // Перший член прогресії
        public double r;  // Знаменник прогресії

        public GeometricProgression()
        {
            // Конструктор за замовчуванням
            a = 0;
            r = 0;
        }

        public GeometricProgression(double a, double r)
        {
            // Конструктор зі специфікованими значеннями
            this.a = a;
            this.r = r;
        }

        public GeometricProgression(double a)
        {
            Random random = new Random();
            r = random.NextDouble();
            this.a = a;
        }

        public double GetNextTerm()
        {
            // Метод для знаходження наступного члена прогресії
            a *= r;
            return a;
        }

        public double GetSumOfNextTerms(int k)
        {
            // Метод для знаходження суми наступних k членів прогресії
            double sum = 0;
            double currentTerm = this.a;

            for (int i = 0; i < k; i++)
            {
                sum += currentTerm;
                currentTerm *= r;
            }

            return sum;
        }

        public double A
        {
            get { return this.a;  }
        }

        public double R
        {
            get { return this.r; }
        }
    }
}
