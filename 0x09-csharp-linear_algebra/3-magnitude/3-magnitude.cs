using System;
using System.Collections.Generic;

class VectorMath
{
    public static double Magnitude(double[] vector)
    {
        if (vector.Length == 2)
        {	
			double[] res = Math.Round(Math.Sqrt(vector[0]*vector[0]+vector[1]*vector[1]), 2);
			return res;
        }
		
        if (vector.Length == 3)
        {
            return (Math.Round(Math.Sqrt(vector[0]*vector[0]+vector[1]*vector[1]+vector[2]*vector[2]), 2));
        }

        return (-1);
    }
}
