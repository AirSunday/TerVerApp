using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerVerApp
{
    class TableClass
    {
        public int[] Num { get; set; }
        public KeyValuePair<double, double>[] Inter { get; set; }
        public int[] Chast { get; set; }
        public double[] Hight { get; set; }

        /// <summary>Конструктор создающий пустые массивы</summary>
        /// <param name="countRow">Размерность массивов</param>
        public TableClass(int countRow)
        {
            Num = new int[countRow];
            Inter = new KeyValuePair<double, double>[countRow];
            Chast = new int[countRow];
            Hight = new double[countRow];
        }
    }
}
