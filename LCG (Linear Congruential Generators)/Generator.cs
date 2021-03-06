﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace LCG__Linear_Congruential_Generators_
{
    public class Generator
    {
        private int a, c, m, z0;
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

        public bool Control()
        {
            bool success = false;
            int i = 0;
            while (!success && i <= m)
            {
                if (Math.Pow(2,i) == m)
                    success = true;
                i++;
            }

            if (c == 0)
                success = false;

            int smallNumber = a < m ? a : m;
            for (i = 2; i <=smallNumber; i++)
            {
                if (a % i == 0 && m % i == 0)
                    success = false;
            }

            if ((a - 1) % 4 != 0)
                success = false;

            return success;
        }
    }
}
