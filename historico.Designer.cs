namespace SoftwareMercado
{
    partial class historico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(historico));
            panel1 = new Panel();
            dataGridHist = new DataGridView();
            panel3 = new Panel();
            LBLtotal = new Label();
            panel4 = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            CBOidOperador = new ComboBox();
            CBOoperador = new ComboBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            dateTimeFim = new DateTimePicker();
            dateTimeInicio = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label6 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridHist).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(219, 219, 219);
            panel1.Controls.Add(dataGridHist);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(822, 540);
            panel1.TabIndex = 1;
            // 
            // dataGridHist
            // 
            dataGridHist.AllowUserToAddRows = false;
            dataGridHist.AllowUserToDeleteRows = false;
            dataGridHist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridHist.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(3, 62, 140);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(3, 62, 140);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridHist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridHist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(3, 62, 140);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(3, 62, 140);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridHist.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridHist.Location = new Point(19, 111);
            dataGridHist.Name = "dataGridHist";
            dataGridHist.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(3, 62, 140);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(3, 62, 140);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridHist.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.75F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(3, 62, 140);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(3, 62, 140);
            dataGridHist.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridHist.Size = new Size(787, 374);
            dataGridHist.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(LBLtotal);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(button1);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 491);
            panel3.Name = "panel3";
            panel3.Size = new Size(822, 49);
            panel3.TabIndex = 1;
            // 
            // LBLtotal
            // 
            LBLtotal.AutoSize = true;
            LBLtotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            LBLtotal.Location = new Point(19, 13);
            LBLtotal.Name = "LBLtotal";
            LBLtotal.Size = new Size(52, 21);
            LBLtotal.TabIndex = 2;
            LBLtotal.Text = "Total:";
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Center;
            panel4.Location = new Point(778, 14);
            panel4.Name = "panel4";
            panel4.Size = new Size(28, 23);
            panel4.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(242, 135, 5);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(653, 14);
            button1.Name = "button1";
            button1.Size = new Size(119, 23);
            button1.TabIndex = 0;
            button1.Text = "Pesquisar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(242, 135, 5);
            panel2.Controls.Add(CBOidOperador);
            panel2.Controls.Add(CBOoperador);
            panel2.Controls.Add(checkBox2);
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(dateTimeFim);
            panel2.Controls.Add(dateTimeInicio);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(822, 105);
            panel2.TabIndex = 0;
            // 
            // CBOidOperador
            // 
            CBOidOperador.FormattingEnabled = true;
            CBOidOperador.Location = new Point(539, 61);
            CBOidOperador.Name = "CBOidOperador";
            CBOidOperador.Size = new Size(35, 23);
            CBOidOperador.TabIndex = 4;
            CBOidOperador.Visible = false;
            // 
            // CBOoperador
            // 
            CBOoperador.DropDownStyle = ComboBoxStyle.DropDownList;
            CBOoperador.FormattingEnabled = true;
            CBOoperador.Location = new Point(368, 61);
            CBOoperador.Name = "CBOoperador";
            CBOoperador.Size = new Size(165, 23);
            CBOoperador.TabIndex = 4;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(713, 48);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(56, 19);
            checkBox2.TabIndex = 3;
            checkBox2.Text = "Todas";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(713, 75);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(86, 19);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Canceladas";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // dateTimeFim
            // 
            dateTimeFim.Location = new Point(54, 77);
            dateTimeFim.Name = "dateTimeFim";
            dateTimeFim.Size = new Size(240, 23);
            dateTimeFim.TabIndex = 1;
            // 
            // dateTimeInicio
            // 
            dateTimeInicio.Location = new Point(54, 46);
            dateTimeInicio.Name = "dateTimeInicio";
            dateTimeInicio.Size = new Size(240, 23);
            dateTimeInicio.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label3.Location = new Point(19, 81);
            label3.Name = "label3";
            label3.Size = new Size(33, 17);
            label3.TabIndex = 0;
            label3.Text = "Até:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label4.Location = new Point(368, 41);
            label4.Name = "label4";
            label4.Size = new Size(66, 17);
            label4.TabIndex = 0;
            label4.Text = "Operador";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.Location = new Point(19, 50);
            label2.Name = "label2";
            label2.Size = new Size(29, 17);
            label2.TabIndex = 0;
            label2.Text = "De:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(713, 11);
            label6.Name = "label6";
            label6.Size = new Size(75, 21);
            label6.TabIndex = 0;
            label6.Text = "Exibição";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 11);
            label1.Name = "label1";
            label1.Size = new Size(46, 21);
            label1.TabIndex = 0;
            label1.Text = "Data";
            // 
            // historico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(3, 62, 140);
            ClientSize = new Size(846, 564);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "historico";
            Text = "historico";
            Load += historico_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridHist).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridHist;
        private Panel panel3;
        private Label label1;
        private DateTimePicker dateTimeFim;
        private DateTimePicker dateTimeInicio;
        private Label label3;
        private Label label2;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label label6;
        private Button button1;
        private Label LBLtotal;
        private Panel panel4;
        private ComboBox CBOidOperador;
        private ComboBox CBOoperador;
        private Label label4;
    }
}