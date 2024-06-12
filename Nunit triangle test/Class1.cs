using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NUnitDemonstration
{
    public static class Triangle
    {
        public static string ValidTriangle(int angle1, int angle2, int angle3)
        {
            string result;
            if ((angle1 + angle2 + angle3) == 180)   
            {
                result = "The triangle is valid.";
            }
            else
            {
                result = "The triangle is NOT valid.";
            }
            return result;
        }
    }
}