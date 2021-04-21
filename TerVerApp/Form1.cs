using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TerVerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private List<double> ParseStandart(bool flag = true)
        {
            try
            {
                var s = txtbxInput.Text;
                s = s.Replace("−", "-");
                var input = s.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();
                if (!flag) return input;
                lblStatus.Text = "Статус: Ооо, повезло, повезло!";
                lblStatus.ForeColor = Color.Green;
                txtbxInput.Focus();
                return input;
            }
            catch
            {
                if (!flag)
                {
                    lblStatus.Text = "Статус: Ввод некорректен!";
                    lblStatus.ForeColor = Color.Red;
                    txtbxInput.Focus();
                    return null;
                }
                lblStatus.Text = "Статус: Обычный метод - ошибка. Выбран метод с большими N!";
                lblStatus.ForeColor = Color.Blue;
                txtbxInput.Focus();
                rbN.Checked = true;
                rbStandart.Checked = false;
                return ParseManyN(false);
            }
        }

        private List<double> ParseManyN(bool flag = true)
        {
            try { 
                var s = txtbxInput.Text;
                var input = new List<double>();
                var str = s.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                foreach (var word in str)
                {
                    var str2 = word.Split(new[] { ':' }).Select(double.Parse).ToList();
                    for(var i = 0; i < str2[1]; i++)
                    {
                        input.Add(str2[0]);
                    }
                }

                if (!flag) return input;
                lblStatus.Text = "Статус: Ооо, повезло, повезло!";
                lblStatus.ForeColor = Color.Green;
                txtbxInput.Focus();
                return input;
            }
            catch
            {
                if (!flag)
                {
                    lblStatus.Text = "Статус: Ввод некорректен!";
                    lblStatus.ForeColor = Color.Red;
                    txtbxInput.Focus();
                    return null;
                }
                lblStatus.Text = "Статус: При больших N - ошибка. Выбран обычный метод!";
                lblStatus.ForeColor = Color.Blue;
                txtbxInput.Focus();
                rbN.Checked = false;
                rbStandart.Checked = true;
                return ParseStandart(false);
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            tableGist.Visible = false;
            tableGist.Controls.Clear();
            if (txtbxInput.Text == "")
            {
                lblStatus.Text = "Статус: Ничего не введено!";
                lblStatus.ForeColor = Color.Red;
                txtbxInput.Focus();
                return;
            }

            var calc = rbStandart.Checked ? new Calculator(ParseStandart()) : new Calculator(ParseManyN());

            if (calc.Sequence == null)
                return;

            // Выборочный начальный момент n-ого порядка
            txtbxM1.Text = calc.mN(1).ToString("0.####");
            txtbxM2.Text = calc.mN(2).ToString("0.####");
            txtbxM3.Text = calc.mN(3).ToString("0.####");
            txtbxM4.Text = calc.mN(4).ToString("0.####");

            // Выборочный центральный момент n-ого порядка
            txtbxV2.Text = calc.vN(2).ToString("0.####");
            txtbxV3.Text = calc.vN(3).ToString("0.####");
            txtbxV4.Text = calc.vN(4).ToString("0.####");
            txtbxV5.Text = calc.vN(5).ToString("0.####");

            // Оценка Дисперсии
            txtbxSx.Text = calc.Sx().ToString("0.####");

            // Мода и Медиана
            txtbxMed.Text = calc.XMed().ToString("0.####");
            txtbxMod.Text = calc.XMod().ToString("0.####");

            // Коэф. Ас. и Екс.
            txtbxKas.Text = calc.Kas().ToString("0.####");
            txtbxKex.Text = calc.Kex().ToString("0.####");

            // Вариационный ряд
            var seq = calc.Sequence;
            seq.Sort();
            txtbxVarSeq.Text = string.Join(" ", seq.ToArray());

            CreateTable(seq);
        }

        private void btnReCalc_Click(object sender, EventArgs e)
        {
            tableGist.Visible = false;
            tableGist.Controls.Clear();

            int.TryParse(tbxH.Text, out var countRow);

            var seq = txtbxVarSeq.Text.Split(' ').Select(double.Parse).ToList();

            CreateTable(seq, countRow);

        }

        private void CreateTable(List<double> seq, int countRow = 0)
        {
            // Таблица
            var tableObject = new TableObject();
            var table = tableObject.CreateTable(seq, countRow);
            tableGist.ColumnCount = tableObject.countColumn;
            tableGist.RowCount = tableObject.CountRow + 1;

            tbxH.Text = (tableObject.CountRow).ToString();
            tbxS.Text = (tableObject.Delta).ToString("0.####");

            for (var j = 0; j <= tableObject.CountRow; j++)
            {
                var label1 = new Label();
                var label2 = new Label();
                var label3 = new Label();
                var label4 = new Label();
                label1.AutoSize = false;
                label2.AutoSize = false;
                label3.AutoSize = false;
                label4.AutoSize = false;
                label1.TextAlign = ContentAlignment.MiddleCenter;
                label2.TextAlign = ContentAlignment.MiddleCenter;
                label3.TextAlign = ContentAlignment.MiddleCenter;
                label4.TextAlign = ContentAlignment.MiddleCenter;
                label1.Dock = DockStyle.Fill;
                label2.Dock = DockStyle.Fill;
                label3.Dock = DockStyle.Fill;
                label4.Dock = DockStyle.Fill;

                if (j == 0)
                {
                    label1.Text = "№";
                    label2.Text = "Интервал";
                    label3.Text = "Частота";
                    label4.Text = "Высота столбца";
                    label1.Font = new Font(label7.Font.Name, 8.25f, label7.Font.Style);
                    label2.Font = new Font(label7.Font.Name, 8.25f, label7.Font.Style);
                    label3.Font = new Font(label7.Font.Name, 8.25f, label7.Font.Style);
                    label4.Font = new Font(label7.Font.Name, 8.25f, label7.Font.Style);

                    tableGist.Controls.Add(label1, 0, 0);
                    tableGist.Controls.Add(label2, 1, 0);
                    tableGist.Controls.Add(label3, 2, 0);
                    tableGist.Controls.Add(label4, 3, 0);
                    continue;
                }

                label1.Text = table.Num[j - 1].ToString();
                tableGist.Controls.Add(label1, 0, j);

                if (j != tableObject.CountRow)
                    label2.Text = "[ " + table.Inter[j - 1].Key.ToString("0.####") + " ; " + table.Inter[j - 1].Value.ToString("0.####") + " )";
                else
                    label2.Text = "[ " + table.Inter[j - 1].Key.ToString("0.####") + " ; " + table.Inter[j - 1].Value.ToString("0.####") + " ]";
                tableGist.Controls.Add(label2, 1, j);

                label3.Text = table.Chast[j - 1].ToString("0.####");
                tableGist.Controls.Add(label3, 2, j);

                label4.Text = table.Hight[j - 1].ToString("0.####");
                tableGist.Controls.Add(label4, 3, j);
            }
            tableGist.Visible = true;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            var formHelp = (FormHelp)Application.OpenForms["Form3"] ?? new FormHelp();
            formHelp.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/kain69");
        }

        private void linkSasha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/AirSunday");
        }
    }
}
