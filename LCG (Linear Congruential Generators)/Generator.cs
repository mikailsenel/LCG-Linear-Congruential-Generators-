using System;
using System.Collections.Generic;
using System.Text;

namespace LCG__Linear_Congruential_Generators_
{
    public class Generator
    {
        private int a,c,m,z0;
        public Generator(int multiplier, int increment, int amplitude, int initialValue)
        {
            this.a = multiplier;
            this.c = increment;
            this.m = amplitude;
            this.z0 = initialValue;
        }
        public double[] LCG_Generators()
        {
            /*
             *      z(k+1)=(a*z(k)+c) mod(m)                a=multiplier
             *      u(k)=z(k)/m                             c=increment
             *                                              m=amplitude
            */

            double[] u = new double[m];
            double zk = z0;
            for (int i = 0; i < m; i++)
            {
                u[i] = zk / m;
                zk = (a * zk + c) % m;
            }
            return u;
        }
    }
}
