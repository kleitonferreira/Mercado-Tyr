namespace SoftwareMercado
{
    partial class loginFRM
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginFRM));
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            button1 = new Button();
            btoLogar = new Button();
            label4 = new Label();
            senhaTXT = new TextBox();
            operadorTXT = new TextBox();
            caixaTXT = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(355, 614);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Location = new Point(80, 158);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 286);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(button1);
            panel3.Controls.Add(btoLogar);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(senhaTXT);
            panel3.Controls.Add(operadorTXT);
            panel3.Controls.Add(caixaTXT);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(483, 81);
            panel3.Name = "panel3";
            panel3.Size = new Size(427, 461);
            panel3.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(242, 135, 5);
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(262, 399);
            button1.Name = "button1";
            button1.Size = new Size(100, 50);
            button1.TabIndex = 5;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btoLogar
            // 
            btoLogar.BackColor = Color.FromArgb(242, 135, 5);
            btoLogar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btoLogar.Location = new Point(62, 399);
            btoLogar.Name = "btoLogar";
            btoLogar.Size = new Size(100, 50);
            btoLogar.TabIndex = 4;
            btoLogar.Text = "Logar";
            btoLogar.UseVisualStyleBackColor = false;
            btoLogar.Click += btoLogar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(62, 346);
            label4.Name = "label4";
            label4.Size = new Size(152, 17);
            label4.TabIndex = 3;
            label4.Text = "Registar novo operador";
            label4.Click += label4_Click;
            // 
            // senhaTXT
            // 
            senhaTXT.Location = new Point(62, 300);
            senhaTXT.Name = "senhaTXT";
            senhaTXT.Size = new Size(300, 23);
            senhaTXT.TabIndex = 2;
            // 
            // operadorTXT
            // 
            operadorTXT.Location = new Point(62, 196);
            operadorTXT.Name = "operadorTXT";
            operadorTXT.Size = new Size(300, 23);
            operadorTXT.TabIndex = 1;
            // 
            // caixaTXT
            // 
            caixaTXT.Location = new Point(62, 93);
            caixaTXT.Name = "caixaTXT";
            caixaTXT.Size = new Size(300, 23);
            caixaTXT.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Malgun Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(135, 148);
            label2.Name = "label2";
            label2.Size = new Size(166, 45);
            label2.TabIndex = 0;
            label2.Text = "Operador";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Malgun Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(163, 252);
            label3.Name = "label3";
            label3.Size = new Size(111, 45);
            label3.TabIndex = 0;
            label3.Text = "Senha";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Malgun Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(163, 45);
            label1.Name = "label1";
            label1.Size = new Size(100, 45);
            label1.TabIndex = 0;
            label1.Text = "Caixa";
            // 
            // loginFRM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(3, 62, 140);
            ClientSize = new Size(1046, 614);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "loginFRM";
            StartPosition = FormStartPosition.CenterScreen;
            Load += loginFRM_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Label label4;
        private TextBox senhaTXT;
        private TextBox operadorTXT;
        private TextBox caixaTXT;
        private Label label2;
        private Label label3;
        private Button btoLogar;
        private Button button1;
    }
}
