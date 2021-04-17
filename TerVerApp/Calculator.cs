using System;
using System.Collections.Generic;
using System.Linq;

namespace TerVerApp
{
    internal class Calculator
    {
        public List<double> Sequence { get; }

        public Calculator(List<double> sequence)
        {
            Sequence = sequence;
        }

        public double mN (int n)
        {
            var sum = Sequence.Sum(num => Math.Pow(num, n));
            return sum/Sequence.Count;
        }
        
        public double vN (int n)
        {
            var m1 = mN(1);
            var sum = Sequence.Sum(num => Math.Pow(num - m1, n));
            return sum/Sequence.Count;
        }

        public double Sx()
        {
            var m1 = mN(1);
            var sum = Sequence.Sum(num => Math.Pow(num - m1, 2));
            return sum/(Sequence.Count-1);
        }

        public double XMod()
        {
            return Sequence.GroupBy(x => x).OrderByDescending(x => x.Count()).First().Key;
        }

        public double XMed()
        {
            var seq = Sequence;
            seq.Sort();
            return seq.Count % 2 == 1 ? seq[seq.Count / 2] : ((seq[seq.Count / 2] + seq[seq.Count / 2 - 1]) / 2);
        }

        public double Kas()
        {
            return vN(3) / Math.Pow(Math.Sqrt(vN(2)), 3);
        }

        public double Kex()
        {
            return (vN(4) / Math.Pow(Math.Sqrt(vN(2)), 4) - 3);
        }
    }
}
