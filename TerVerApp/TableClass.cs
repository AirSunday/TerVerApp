using System.Collections.Generic;

namespace TerVerApp
{
    internal class TableClass
    {
        public int[] Num { get; }
        public KeyValuePair<double, double>[] Inter { get; }
        public int[] Chast { get; }
        public double[] Hight { get; }

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
