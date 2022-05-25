using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureCalculation
{
    public class Triangle : Figure
    {
        public Double SideA { get; set; } = Double.NaN;
        public Double SideB { get; set; } = Double.NaN;
        public Double SideC { get; set; } = Double.NaN;
        public Boolean IsRectangular 
        {
            get 
            {
                Double squaredSideA = SideA * SideA;
                Double squaredSideB = SideB * SideB;
                return SideC == Math.Sqrt(squaredSideA + squaredSideB);
            }
        }
        
        /// <summary>
        /// Треугольник со сторонами 3, 5, 6 может существовать
        /// </summary>
        public Triangle() : this(3, 5, 6) { }
        public Triangle(Double sideA) : this(sideA, 5, 6) { }
        public Triangle(Double sideA, Double sideB) : this(sideA, sideB, 6) { }

        public Triangle(Double sideA, Double sideB, Double sideC)
        {
            if(this.IsTriangleExist(sideA, sideB, sideC)) 
            {
                SideA = sideA;
                SideB = sideB;
                SideC = sideC;

            }
            else 
            {
                throw new ArgumentException("A triangle with such sides cannot exist.");
            }
        }

        public override Double Area()
        {
            Double halfPerimetr = this.Perimetr() / 2;
            Double area = Math.Sqrt(halfPerimetr *
                            (halfPerimetr - SideA) *
                            (halfPerimetr - SideB) *
                            (halfPerimetr - SideC));
            return area;
            throw new NotImplementedException();
        }
       
        public Double Perimetr() 
        {
            return SideA + SideB + SideC;
        }
        /// <summary>
        /// Проверка на существование треугольника.
        /// a + b > c, b + c > a, a + c > b.
        /// Проверка на положительность сторон треугольника не проводится, 
        /// т. к. в математике нет доказательства невозможности отрицательной длины.
        /// </summary>
        /// <param name="sideA">Длина стороны A</param>
        /// <param name="sideB">Длина стороны B</param>
        /// <param name="sideC">Длина стороны C</param>
        private Boolean IsTriangleExist(Double sideA, Double sideB, Double sideC) 
        {
            Boolean disparityBetweeParties_AB_C = (sideA + sideB > sideC) ? true : false;
            Boolean disparityBetweeParties_BC_A = (sideB + sideC > sideA) ? true : false;
            Boolean disparityBetweeParties_AC_B = (sideA + sideC > sideB) ? true : false;

            if (disparityBetweeParties_AB_C && disparityBetweeParties_BC_A && disparityBetweeParties_AC_B) 
            {
                return true;
            }
            else 
            {
                return false;
            }
        }       
    }
}
