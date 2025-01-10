namespace SoftwareMercado
{
    partial class abrirCaixa
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            timerReset = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(219, 219, 219);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 237);
            panel1.TabIndex = 0;
           
            // 
            // button2
            // 
            button2.BackColor = SystemColors.AppWorkspace;
            button2.Location = new Point(203, 165);
            button2.Name = "button2";
            button2.Size = new Size(100, 50);
            button2.TabIndex = 1;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.AppWorkspace;
            button1.Location = new Point(57, 165);
            button1.Name = "button1";
            button1.Size = new Size(100, 50);
            button1.TabIndex = 1;
            button1.Text = "Abrir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(57, 80);
            label1.Name = "label1";
            label1.Size = new Size(246, 25);
            label1.TabIndex = 0;
            label1.Text = "Você deseja abrir o caixa??";
            // 
            // abrirCaixa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(3, 62, 140);
            ClientSize = new Size(384, 261);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "abrirCaixa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "abrirCaixa";
            Load += abrirCaixa_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button button1;
        private Label label1;
        private System.Windows.Forms.Timer timerReset;
    }
}