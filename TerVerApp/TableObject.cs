using System;
using System.Collections.Generic;
using System.Linq;

namespace TerVerApp
{
    internal class TableObject
    {
        public int CountRow { get; private set; }
        public int CountColumn { get; } = 4;
        public double Delt { get; private set; }

        /// <summary>Создать и заполнить таблицу</summary>
        /// <param name="varSeq">Вариационный ряд</param>
        /// <param name="countRow">Количество строк</param>
        /// <returns>Таблица</returns>
        public TableClass CreateTable(List<double> varSeq, int countRow = 0)
        {
            if (countRow == 0)
            {
                CountRow = Convert.ToInt32(Math.Floor(Math.Log(Convert.ToDouble(varSeq.Count), 2.0))) + 1;
            }
            if (countRow > 0)
            {
                CountRow = countRow;
            }
            var Table = new TableClass(CountRow);

            Delt = Math.Round((varSeq[varSeq.Count - 1] - varSeq[0]) / CountRow, 4);

            Table.Inter[0] = new KeyValuePair<double, double>(Math.Round(varSeq[0], 6), Math.Round(varSeq[0] + Delt, 4));

            int temp = 0, j;

            for (var i = 0; i < CountRow; i++)
            {
                Table.Num[i] = (i + 1);

                if (i != 0)
                {
                    if (i == CountRow - 1)
                    {
                        Table.Inter[i] = new KeyValuePair<double, double>(
                            Math.Round(Table.Inter[i - 1].Value, 4),
                            Math.Round(varSeq.LastOrDefault(), 4));
                    }
                    else
                    {
                        Table.Inter[i] = new KeyValuePair<double, double>(
                            Math.Round(Table.Inter[i - 1].Value, 4),
                            Math.Round(Table.Inter[i - 1].Value + Delt, 4));
                    }
                }

                for (j = temp; j < varSeq.Count && varSeq[j] <= (Table.Inter[i]).Value; j++) ;

                Table.Chast[i] = j - temp;
                temp = j;

                Table.Hight[i] = Math.Round(Convert.ToDouble(Table.Chast[i]) / Delt / varSeq.Count, 4);
            }

            return Table;

        }
    }
}
