namespace SoftwareMercado
{
    partial class novaCompra
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
            panel1 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            TextoCaixa = new Label();
            panelCOR = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(219, 219, 219);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(822, 540);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(panelCOR);
            panel3.Controls.Add(TextoCaixa);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(822, 87);
            panel3.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 453);
            panel2.Name = "panel2";
            panel2.Size = new Size(822, 87);
            panel2.TabIndex = 0;
            // 
            // TextoCaixa
            // 
            TextoCaixa.AutoSize = true;
            TextoCaixa.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TextoCaixa.Location = new Point(72, 30);
            TextoCaixa.Name = "TextoCaixa";
            TextoCaixa.Size = new Size(57, 21);
            TextoCaixa.TabIndex = 0;
            TextoCaixa.Text = "label1";
            // 
            // panelCOR
            // 
            panelCOR.Location = new Point(50, 35);
            panelCOR.Name = "panelCOR";
            panelCOR.Size = new Size(16, 16);
            panelCOR.TabIndex = 1;
            // 
            // novaCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(3, 62, 140);
            ClientSize = new Size(846, 564);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "novaCompra";
            Text = "novaCompra";
            Load += novaCompra_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Panel panelCOR;
        private Label TextoCaixa;
    }
}