namespace SoftwareMercado
{
    partial class estoque
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
            panel1 = new Panel();
            dataGridEstoque = new DataGridView();
            panel2 = new Panel();
            button2 = new Button();
            button1 = new Button();
            panel3 = new Panel();
            panelFalta = new Panel();
            panelDisp = new Panel();
            panelProd = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridEstoque).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(219, 219, 219);
            panel1.Controls.Add(dataGridEstoque);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(822, 540);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // dataGridEstoque
            // 
            dataGridEstoque.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridEstoque.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(3, 62, 140);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(3, 62, 140);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridEstoque.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridEstoque.Location = new Point(80, 106);
            dataGridEstoque.Name = "dataGridEstoque";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(3, 62, 140);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(3, 62, 140);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridEstoque.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(3, 62, 140);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(3, 62, 140);
            dataGridEstoque.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridEstoque.Size = new Size(660, 418);
            dataGridEstoque.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(822, 100);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(242, 135, 5);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(598, 15);
            button2.Name = "button2";
            button2.Size = new Size(142, 32);
            button2.TabIndex = 1;
            button2.Text = "Adicionar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(242, 135, 5);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(598, 53);
            button1.Name = "button1";
            button1.Size = new Size(142, 32);
            button1.TabIndex = 1;
            button1.Text = "Excluir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(217, 4, 61);
            panel3.Controls.Add(panelFalta);
            panel3.Controls.Add(panelDisp);
            panel3.Controls.Add(panelProd);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(80, 15);
            panel3.Name = "panel3";
            panel3.Size = new Size(492, 70);
            panel3.TabIndex = 0;
            // 
            // panelFalta
            // 
            panelFalta.BackColor = Color.FromArgb(242, 135, 5);
            panelFalta.Location = new Point(361, 55);
            panelFalta.Name = "panelFalta";
            panelFalta.Size = new Size(83, 10);
            panelFalta.TabIndex = 2;
            // 
            // panelDisp
            // 
            panelDisp.BackColor = Color.FromArgb(242, 135, 5);
            panelDisp.Location = new Point(204, 55);
            panelDisp.Name = "panelDisp";
            panelDisp.Size = new Size(83, 10);
            panelDisp.TabIndex = 2;
            // 
            // panelProd
            // 
            panelProd.BackColor = Color.FromArgb(242, 135, 5);
            panelProd.Location = new Point(40, 55);
            panelProd.Name = "panelProd";
            panelProd.Size = new Size(83, 10);
            panelProd.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(350, 20);
            label3.Name = "label3";
            label3.Size = new Size(107, 32);
            label3.TabIndex = 0;
            label3.Text = "Em falta";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(178, 20);
            label2.Name = "label2";
            label2.Size = new Size(135, 32);
            label2.TabIndex = 0;
            label2.Text = "Disponivel";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 20);
            label1.Name = "label1";
            label1.Size = new Size(119, 32);
            label1.TabIndex = 0;
            label1.Text = "Produtos";
            label1.Click += label1_Click;
            // 
            // estoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(3, 62, 140);
            ClientSize = new Size(846, 564);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "estoque";
            Text = "estoque";
            Load += estoque_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridEstoque).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridEstoque;
        private Panel panel3;
        private Button button2;
        private Button button1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panelFalta;
        private Panel panelDisp;
        private Panel panelProd;
    }
}