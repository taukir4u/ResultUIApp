using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResultUIApp
{
    class Result
    {
        public double Physics { get; private set; }
        public double Chemestry { get; private set; }
        public double Math { get; private set; }
        
        public Result(double physics, double chemestry, double math)
        {
            Physics = physics;
            Chemestry = chemestry;
            Math = math;
        }

        public double GetAverage()
        {
            return (Physics + Chemestry + Math) / 3;

        }

        public string GetMyGrade()
        {
            double averageMark = GetAverage();
            
            if (averageMark >= 80)
            {
                return "A+";
            }
            else if (averageMark >= 70)
            {
                return "B+";
            }
            else if (averageMark >= 60)
            {
                return "C+";
            }
            else if (averageMark >= 50)
            {
                return "D+";
            }
            else
            {
                return "F";
            }
        }
    }
}
