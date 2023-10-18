using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric
{
    internal class GeometricProgression
    {
        private double a;   // Перший член прогресії
        private double r;   // Знаменник прогресії

        public GeometricProgression()
        {
            // Конструктор зі значеннями за замовчуванням
            a = 1.0;  // Перший член прогресії (зазвичай 1)
            r = 2.0;  // Знаменник прогресії (зазвичай 2)
        }

        public GeometricProgression(double firstTerm, double commonRatio)
        {
            // Конструктор зі специфікованими значеннями
            a = firstTerm;
            r = commonRatio;
        }

        public double GetNextTerm()
        {
            // Метод для знаходження наступного члена прогресії
            return a * r;
        }

        public double GetSumOfNextTerms(int k)
        {
            // Метод для знаходження суми наступних k членів прогресії
            double sum = 0;
            double currentTerm = a;

            for (int i = 0; i < k; i++)
            {
                sum += currentTerm;
                currentTerm *= r;
            }

            return sum;
        }
    }
}
