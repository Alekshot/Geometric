using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric
{
    internal class GeometricProgression
    {
        double a;   // Перший член прогресії
        double r;   // Знаменник прогресії

        public GeometricProgression(double a, double r)
        {
            // Конструктор зі специфікованими значеннями
            this.a = a;
            this.r = r;
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
