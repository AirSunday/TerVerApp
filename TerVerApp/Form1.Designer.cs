
namespace TerVerApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtbxInput = new System.Windows.Forms.TextBox();
            this.rbStandart = new System.Windows.Forms.RadioButton();
            this.rbN = new System.Windows.Forms.RadioButton();
            this.btnM1 = new System.Windows.Forms.Button();
            this.grpbxMat = new System.Windows.Forms.GroupBox();
            this.pbMat = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtbxM4 = new System.Windows.Forms.TextBox();
            this.txtbxM3 = new System.Windows.Forms.TextBox();
            this.txtbxM2 = new System.Windows.Forms.TextBox();
            this.btnM4 = new System.Windows.Forms.Button();
            this.btnM3 = new System.Windows.Forms.Button();
            this.btnM2 = new System.Windows.Forms.Button();
            this.txtbxM1 = new System.Windows.Forms.TextBox();
            this.grpbxDisp = new System.Windows.Forms.GroupBox();
            this.pbDisp = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtbxV5 = new System.Windows.Forms.TextBox();
            this.txtbxV4 = new System.Windows.Forms.TextBox();
            this.txtbxV3 = new System.Windows.Forms.TextBox();
            this.btnV5 = new System.Windows.Forms.Button();
            this.btnV4 = new System.Windows.Forms.Button();
            this.btnV3 = new System.Windows.Forms.Button();
            this.btnV2 = new System.Windows.Forms.Button();
            this.txtbxV2 = new System.Windows.Forms.TextBox();
            this.grpbxSx = new System.Windows.Forms.GroupBox();
            this.pbSx = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSx = new System.Windows.Forms.Button();
            this.txtbxSx = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.grpbxRdBtn = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpbxMat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMat)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.grpbxDisp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDisp)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.grpbxSx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSx)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.grpbxRdBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbxInput
            // 
            this.txtbxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtbxInput.Location = new System.Drawing.Point(12, 12);
            this.txtbxInput.Name = "txtbxInput";
            this.txtbxInput.Size = new System.Drawing.Size(469, 22);
            this.txtbxInput.TabIndex = 0;
            // 
            // rbStandart
            // 
            this.rbStandart.AutoSize = true;
            this.rbStandart.Checked = true;
            this.rbStandart.Location = new System.Drawing.Point(6, 19);
            this.rbStandart.Name = "rbStandart";
            this.rbStandart.Size = new System.Drawing.Size(99, 17);
            this.rbStandart.TabIndex = 1;
            this.rbStandart.TabStop = true;
            this.rbStandart.Text = "Обычный ввод";
            this.rbStandart.UseVisualStyleBackColor = true;
            // 
            // rbN
            // 
            this.rbN.AutoSize = true;
            this.rbN.Location = new System.Drawing.Point(111, 19);
            this.rbN.Name = "rbN";
            this.rbN.Size = new System.Drawing.Size(102, 17);
            this.rbN.TabIndex = 2;
            this.rbN.Text = "При больших N";
            this.rbN.UseVisualStyleBackColor = true;
            // 
            // btnM1
            // 
            this.btnM1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnM1.Enabled = false;
            this.btnM1.Location = new System.Drawing.Point(3, 3);
            this.btnM1.Name = "btnM1";
            this.btnM1.Size = new System.Drawing.Size(72, 31);
            this.btnM1.TabIndex = 3;
            this.btnM1.Text = "m1";
            this.btnM1.UseVisualStyleBackColor = true;
            // 
            // grpbxMat
            // 
            this.grpbxMat.Controls.Add(this.pbMat);
            this.grpbxMat.Controls.Add(this.tableLayoutPanel1);
            this.grpbxMat.Location = new System.Drawing.Point(12, 114);
            this.grpbxMat.Name = "grpbxMat";
            this.grpbxMat.Size = new System.Drawing.Size(469, 175);
            this.grpbxMat.TabIndex = 5;
            this.grpbxMat.TabStop = false;
            this.grpbxMat.Text = "Мат. Ожидание";
            // 
            // pbMat
            // 
            this.pbMat.Image = ((System.Drawing.Image)(resources.GetObject("pbMat.Image")));
            this.pbMat.InitialImage = null;
            this.pbMat.Location = new System.Drawing.Point(220, 19);
            this.pbMat.Name = "pbMat";
            this.pbMat.Size = new System.Drawing.Size(243, 150);
            this.pbMat.TabIndex = 1;
            this.pbMat.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.txtbxM4, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtbxM3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtbxM2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnM4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnM3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnM2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnM1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtbxM1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(210, 150);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtbxM4
            // 
            this.txtbxM4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbxM4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtbxM4.Location = new System.Drawing.Point(81, 114);
            this.txtbxM4.Multiline = true;
            this.txtbxM4.Name = "txtbxM4";
            this.txtbxM4.ReadOnly = true;
            this.txtbxM4.Size = new System.Drawing.Size(126, 33);
            this.txtbxM4.TabIndex = 12;
            // 
            // txtbxM3
            // 
            this.txtbxM3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbxM3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtbxM3.Location = new System.Drawing.Point(81, 77);
            this.txtbxM3.Multiline = true;
            this.txtbxM3.Name = "txtbxM3";
            this.txtbxM3.ReadOnly = true;
            this.txtbxM3.Size = new System.Drawing.Size(126, 31);
            this.txtbxM3.TabIndex = 11;
            // 
            // txtbxM2
            // 
            this.txtbxM2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbxM2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtbxM2.Location = new System.Drawing.Point(81, 40);
            this.txtbxM2.Multiline = true;
            this.txtbxM2.Name = "txtbxM2";
            this.txtbxM2.ReadOnly = true;
            this.txtbxM2.Size = new System.Drawing.Size(126, 31);
            this.txtbxM2.TabIndex = 10;
            // 
            // btnM4
            // 
            this.btnM4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnM4.Enabled = false;
            this.btnM4.Location = new System.Drawing.Point(3, 114);
            this.btnM4.Name = "btnM4";
            this.btnM4.Size = new System.Drawing.Size(72, 33);
            this.btnM4.TabIndex = 9;
            this.btnM4.Text = "m4";
            this.btnM4.UseVisualStyleBackColor = true;
            // 
            // btnM3
            // 
            this.btnM3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnM3.Enabled = false;
            this.btnM3.Location = new System.Drawing.Point(3, 77);
            this.btnM3.Name = "btnM3";
            this.btnM3.Size = new System.Drawing.Size(72, 31);
            this.btnM3.TabIndex = 7;
            this.btnM3.Text = "m3";
            this.btnM3.UseVisualStyleBackColor = true;
            // 
            // btnM2
            // 
            this.btnM2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnM2.Enabled = false;
            this.btnM2.Location = new System.Drawing.Point(3, 40);
            this.btnM2.Name = "btnM2";
            this.btnM2.Size = new System.Drawing.Size(72, 31);
            this.btnM2.TabIndex = 5;
            this.btnM2.Text = "m2";
            this.btnM2.UseVisualStyleBackColor = true;
            // 
            // txtbxM1
            // 
            this.txtbxM1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbxM1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtbxM1.Location = new System.Drawing.Point(81, 3);
            this.txtbxM1.Multiline = true;
            this.txtbxM1.Name = "txtbxM1";
            this.txtbxM1.ReadOnly = true;
            this.txtbxM1.Size = new System.Drawing.Size(126, 31);
            this.txtbxM1.TabIndex = 4;
            // 
            // grpbxDisp
            // 
            this.grpbxDisp.Controls.Add(this.pbDisp);
            this.grpbxDisp.Controls.Add(this.tableLayoutPanel2);
            this.grpbxDisp.Location = new System.Drawing.Point(487, 114);
            this.grpbxDisp.Name = "grpbxDisp";
            this.grpbxDisp.Size = new System.Drawing.Size(469, 175);
            this.grpbxDisp.TabIndex = 6;
            this.grpbxDisp.TabStop = false;
            this.grpbxDisp.Text = "Дисперсия";
            // 
            // pbDisp
            // 
            this.pbDisp.Image = global::TerVerApp.Properties.Resources.Без_имени_2;
            this.pbDisp.InitialImage = null;
            this.pbDisp.Location = new System.Drawing.Point(220, 19);
            this.pbDisp.Name = "pbDisp";
            this.pbDisp.Size = new System.Drawing.Size(243, 150);
            this.pbDisp.TabIndex = 1;
            this.pbDisp.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.txtbxV5, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtbxV4, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtbxV3, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnV5, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnV4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnV3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnV2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtbxV2, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(210, 150);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // txtbxV5
            // 
            this.txtbxV5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbxV5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtbxV5.Location = new System.Drawing.Point(81, 114);
            this.txtbxV5.Multiline = true;
            this.txtbxV5.Name = "txtbxV5";
            this.txtbxV5.ReadOnly = true;
            this.txtbxV5.Size = new System.Drawing.Size(126, 33);
            this.txtbxV5.TabIndex = 12;
            // 
            // txtbxV4
            // 
            this.txtbxV4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbxV4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtbxV4.Location = new System.Drawing.Point(81, 77);
            this.txtbxV4.Multiline = true;
            this.txtbxV4.Name = "txtbxV4";
            this.txtbxV4.ReadOnly = true;
            this.txtbxV4.Size = new System.Drawing.Size(126, 31);
            this.txtbxV4.TabIndex = 11;
            // 
            // txtbxV3
            // 
            this.txtbxV3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbxV3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtbxV3.Location = new System.Drawing.Point(81, 40);
            this.txtbxV3.Multiline = true;
            this.txtbxV3.Name = "txtbxV3";
            this.txtbxV3.ReadOnly = true;
            this.txtbxV3.Size = new System.Drawing.Size(126, 31);
            this.txtbxV3.TabIndex = 10;
            // 
            // btnV5
            // 
            this.btnV5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnV5.Enabled = false;
            this.btnV5.Location = new System.Drawing.Point(3, 114);
            this.btnV5.Name = "btnV5";
            this.btnV5.Size = new System.Drawing.Size(72, 33);
            this.btnV5.TabIndex = 9;
            this.btnV5.Text = "v5";
            this.btnV5.UseVisualStyleBackColor = true;
            // 
            // btnV4
            // 
            this.btnV4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnV4.Enabled = false;
            this.btnV4.Location = new System.Drawing.Point(3, 77);
            this.btnV4.Name = "btnV4";
            this.btnV4.Size = new System.Drawing.Size(72, 31);
            this.btnV4.TabIndex = 7;
            this.btnV4.Text = "v4";
            this.btnV4.UseVisualStyleBackColor = true;
            // 
            // btnV3
            // 
            this.btnV3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnV3.Enabled = false;
            this.btnV3.Location = new System.Drawing.Point(3, 40);
            this.btnV3.Name = "btnV3";
            this.btnV3.Size = new System.Drawing.Size(72, 31);
            this.btnV3.TabIndex = 5;
            this.btnV3.Text = "v3";
            this.btnV3.UseVisualStyleBackColor = true;
            // 
            // btnV2
            // 
            this.btnV2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnV2.Enabled = false;
            this.btnV2.Location = new System.Drawing.Point(3, 3);
            this.btnV2.Name = "btnV2";
            this.btnV2.Size = new System.Drawing.Size(72, 31);
            this.btnV2.TabIndex = 3;
            this.btnV2.Text = "v2";
            this.btnV2.UseVisualStyleBackColor = true;
            // 
            // txtbxV2
            // 
            this.txtbxV2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbxV2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtbxV2.Location = new System.Drawing.Point(81, 3);
            this.txtbxV2.Multiline = true;
            this.txtbxV2.Name = "txtbxV2";
            this.txtbxV2.ReadOnly = true;
            this.txtbxV2.Size = new System.Drawing.Size(126, 31);
            this.txtbxV2.TabIndex = 4;
            // 
            // grpbxSx
            // 
            this.grpbxSx.Controls.Add(this.pbSx);
            this.grpbxSx.Controls.Add(this.tableLayoutPanel3);
            this.grpbxSx.Location = new System.Drawing.Point(487, 38);
            this.grpbxSx.Name = "grpbxSx";
            this.grpbxSx.Size = new System.Drawing.Size(469, 67);
            this.grpbxSx.TabIndex = 7;
            this.grpbxSx.TabStop = false;
            this.grpbxSx.Text = "Оценка дисперсии";
            // 
            // pbSx
            // 
            this.pbSx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbSx.Image = global::TerVerApp.Properties.Resources.Без_имени_3;
            this.pbSx.InitialImage = null;
            this.pbSx.Location = new System.Drawing.Point(220, 19);
            this.pbSx.Name = "pbSx";
            this.pbSx.Size = new System.Drawing.Size(243, 42);
            this.pbSx.TabIndex = 1;
            this.pbSx.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.btnSx, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtbxSx, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(210, 42);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // btnSx
            // 
            this.btnSx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSx.Enabled = false;
            this.btnSx.Location = new System.Drawing.Point(3, 3);
            this.btnSx.Name = "btnSx";
            this.btnSx.Size = new System.Drawing.Size(72, 36);
            this.btnSx.TabIndex = 3;
            this.btnSx.Text = "Sx";
            this.btnSx.UseVisualStyleBackColor = true;
            // 
            // txtbxSx
            // 
            this.txtbxSx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbxSx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtbxSx.Location = new System.Drawing.Point(81, 3);
            this.txtbxSx.Multiline = true;
            this.txtbxSx.Name = "txtbxSx";
            this.txtbxSx.ReadOnly = true;
            this.txtbxSx.Size = new System.Drawing.Size(126, 36);
            this.txtbxSx.TabIndex = 4;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(247, 43);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 48);
            this.btnCalc.TabIndex = 8;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // grpbxRdBtn
            // 
            this.grpbxRdBtn.Controls.Add(this.rbStandart);
            this.grpbxRdBtn.Controls.Add(this.rbN);
            this.grpbxRdBtn.Location = new System.Drawing.Point(12, 38);
            this.grpbxRdBtn.Name = "grpbxRdBtn";
            this.grpbxRdBtn.Size = new System.Drawing.Size(229, 53);
            this.grpbxRdBtn.TabIndex = 9;
            this.grpbxRdBtn.TabStop = false;
            this.grpbxRdBtn.Text = "Метод ввода";
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatus.Location = new System.Drawing.Point(12, 296);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(469, 24);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Статус: Хорошо!";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(484, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Made by Влад Кармазин и Саша Пономарев. Пользуйся, не благодари!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 329);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.grpbxRdBtn);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.grpbxSx);
            this.Controls.Add(this.grpbxDisp);
            this.Controls.Add(this.grpbxMat);
            this.Controls.Add(this.txtbxInput);
            this.Name = "Form1";
            this.Text = "Изи ТерВер сдал!";
            this.grpbxMat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMat)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.grpbxDisp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbDisp)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.grpbxSx.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSx)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.grpbxRdBtn.ResumeLayout(false);
            this.grpbxRdBtn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxInput;
        private System.Windows.Forms.RadioButton rbStandart;
        private System.Windows.Forms.RadioButton rbN;
        private System.Windows.Forms.Button btnM1;
        private System.Windows.Forms.GroupBox grpbxMat;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtbxM4;
        private System.Windows.Forms.TextBox txtbxM3;
        private System.Windows.Forms.TextBox txtbxM2;
        private System.Windows.Forms.Button btnM4;
        private System.Windows.Forms.Button btnM3;
        private System.Windows.Forms.Button btnM2;
        private System.Windows.Forms.TextBox txtbxM1;
        private System.Windows.Forms.PictureBox pbMat;
        private System.Windows.Forms.GroupBox grpbxDisp;
        private System.Windows.Forms.PictureBox pbDisp;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtbxV5;
        private System.Windows.Forms.TextBox txtbxV4;
        private System.Windows.Forms.TextBox txtbxV3;
        private System.Windows.Forms.Button btnV5;
        private System.Windows.Forms.Button btnV4;
        private System.Windows.Forms.Button btnV3;
        private System.Windows.Forms.Button btnV2;
        private System.Windows.Forms.TextBox txtbxV2;
        private System.Windows.Forms.GroupBox grpbxSx;
        private System.Windows.Forms.PictureBox pbSx;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnSx;
        private System.Windows.Forms.TextBox txtbxSx;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.GroupBox grpbxRdBtn;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label1;
    }
}

