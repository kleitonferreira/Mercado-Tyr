namespace SoftwareMercado
{
    partial class RegistroFRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroFRM));
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            button2 = new Button();
            button1 = new Button();
            label5 = new Label();
            senhaTXT = new TextBox();
            chaveTXT = new TextBox();
            operadorTXT = new TextBox();
            CaixaTXT = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(691, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(355, 614);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Location = new Point(80, 158);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 284);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(senhaTXT);
            panel3.Controls.Add(chaveTXT);
            panel3.Controls.Add(operadorTXT);
            panel3.Controls.Add(CaixaTXT);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(107, 77);
            panel3.Name = "panel3";
            panel3.Size = new Size(427, 461);
            panel3.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(242, 135, 5);
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(254, 379);
            button2.Name = "button2";
            button2.Size = new Size(100, 50);
            button2.TabIndex = 6;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(242, 135, 5);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(67, 379);
            button1.Name = "button1";
            button1.Size = new Size(100, 50);
            button1.TabIndex = 5;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(67, 336);
            label5.Name = "label5";
            label5.Size = new Size(123, 17);
            label5.TabIndex = 4;
            label5.Text = "Voltar para o login";
            label5.Click += label5_Click;
            // 
            // senhaTXT
            // 
            senhaTXT.Location = new Point(67, 220);
            senhaTXT.Name = "senhaTXT";
            senhaTXT.Size = new Size(287, 23);
            senhaTXT.TabIndex = 2;
            // 
            // chaveTXT
            // 
            chaveTXT.Location = new Point(67, 294);
            chaveTXT.Name = "chaveTXT";
            chaveTXT.Size = new Size(287, 23);
            chaveTXT.TabIndex = 3;
            // 
            // operadorTXT
            // 
            operadorTXT.Location = new Point(67, 146);
            operadorTXT.Name = "operadorTXT";
            operadorTXT.Size = new Size(287, 23);
            operadorTXT.TabIndex = 1;
            // 
            // CaixaTXT
            // 
            CaixaTXT.Location = new Point(67, 72);
            CaixaTXT.Name = "CaixaTXT";
            CaixaTXT.Size = new Size(287, 23);
            CaixaTXT.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Malgun Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(160, 246);
            label4.Name = "label4";
            label4.Size = new Size(111, 45);
            label4.TabIndex = 0;
            label4.Text = "Chave";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Malgun Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(160, 172);
            label3.Name = "label3";
            label3.Size = new Size(111, 45);
            label3.TabIndex = 0;
            label3.Text = "Senha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Malgun Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(131, 98);
            label2.Name = "label2";
            label2.Size = new Size(166, 45);
            label2.TabIndex = 0;
            label2.Text = "Operador";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Malgun Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(160, 24);
            label1.Name = "label1";
            label1.Size = new Size(100, 45);
            label1.TabIndex = 0;
            label1.Text = "Caixa";
            // 
            // RegistroFRM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(3, 62, 140);
            ClientSize = new Size(1046, 614);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegistroFRM";
            StartPosition = FormStartPosition.CenterScreen;
            Load += RegistroFRM_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private TextBox senhaTXT;
        private TextBox chaveTXT;
        private TextBox operadorTXT;
        private TextBox CaixaTXT;
        private Button button1;
        private Button button2;
    }
}