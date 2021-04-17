using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace TerVerApp
{
    internal class TableObject
    {
        public int CountRow { get; private set; }
        public int countColumn = 4;
        public double Delta { get; private set; }

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

            Delta = (varSeq[varSeq.Count - 1] - varSeq[0]) / CountRow;

            using (null)
            {
                var inter1 = varSeq[0];
                var inter2 = varSeq[0] + Delta;
                if (inter2 - Math.Truncate(inter2) >= 0.9999999999000000)
                {
                    inter2 = inter2 >= 0
                        ? Math.Ceiling(inter2)
                        : Math.Floor(inter2);
                }
                Table.Inter[0] = new KeyValuePair<double, double>(inter1, inter2);
            }

            var j = 0;
            for (var i = 0; i < CountRow; i++)
            {
                Table.Num[i] = (i + 1);
                var inter1 = Table.Inter[0].Key; 
                var inter2 = Table.Inter[0].Value;
                if (i != 0)
                {
                    inter1 = Table.Inter[i - 1].Value;
                    inter2 = Table.Inter[i - 1].Value + Delta;
                    if (inter2 - Math.Truncate(inter2) >= 0.9999999999000000)
                    {
                        inter2 = inter2 >= 0
                            ? Math.Ceiling(inter2)
                            : Math.Floor(inter2);
                    }

                    Table.Inter[i] = new KeyValuePair<double, double>(inter1, inter2);
                }

                var temp = 0;
                for (; j < varSeq.Count; j++)
                {
                    if (i != CountRow - 1)
                    {
                        if (varSeq[j] >= inter1 && varSeq[j] < inter2)
                            temp++;
                        else
                            break;
                    }
                    else
                    {
                        if (varSeq[j] >= inter1 && varSeq[j] <= inter2)
                            temp++;
                        else
                            break;
                    }
                }
                Table.Chast[i] = temp;

                Table.Hight[i] = Convert.ToDouble(Table.Chast[i]) / Delta / varSeq.Count;
            }

            return Table;

        }
    }
}
