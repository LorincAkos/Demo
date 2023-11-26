using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public static class RandomNumberGenerator
    {
        public static int GenerateNumber(int lower,int upper)
        {
            Random r = new Random();
            return r.Next(lower,upper);
        }
    }
}
