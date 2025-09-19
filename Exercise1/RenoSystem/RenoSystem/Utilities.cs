using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenoSystem
{
    public static class Utilities
    {
        // Check if a value is positive and non-zero
        public static bool IsNonZeroPositive(int value)
        {
            return value > 0;
        }

        //  public static bool IsNonZeroNegative(int value) { return value > 0; }

        // Check if a value meets a minimum limit
        public static bool MeetsMinimumCriteria(int value, int criteria)
        {
            return value >= criteria;
        }


        /*  public static void ValidatePositive(int value, string paramName)
          {
              if (value <= 0)
              {
                  throw new ArgumentException($"{paramName} must be a positive non-zero value.");
              } 
          }

          public static void ValidateMinimum(int value, int minimum, string paramName)
          {
              if (value < minimum)
              {
                  throw new ArgumentException($"{paramName} must be at least {minimum}.");
              }
          }
      }*/
    }
}
