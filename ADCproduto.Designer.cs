namespace SoftwareMercado
{
    partial class ADCproduto
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
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            valorTXT = new TextBox();
            quantidadeTXT = new TextBox();
            nomeTXT = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(219, 219, 219);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(valorTXT);
            panel1.Controls.Add(quantidadeTXT);
            panel1.Controls.Add(nomeTXT);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(344, 198);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(209, 18);
            label2.Name = "label2";
            label2.Size = new Size(132, 15);
            label2.TabIndex = 2;
            label2.Text = "quantidade em estoque";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(260, 71);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 2;
            label3.Text = "valor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 18);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 2;
            label1.Text = "Nome do produto";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.AppWorkspace;
            button2.Location = new Point(227, 132);
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
            button1.Location = new Point(18, 132);
            button1.Name = "button1";
            button1.Size = new Size(100, 50);
            button1.TabIndex = 1;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // valorTXT
            // 
            valorTXT.Location = new Point(227, 89);
            valorTXT.Name = "valorTXT";
            valorTXT.Size = new Size(100, 23);
            valorTXT.TabIndex = 0;
            valorTXT.Leave += valorTXT_Leave;
            // 
            // quantidadeTXT
            // 
            quantidadeTXT.Location = new Point(227, 36);
            quantidadeTXT.Name = "quantidadeTXT";
            quantidadeTXT.Size = new Size(100, 23);
            quantidadeTXT.TabIndex = 0;
            // 
            // nomeTXT
            // 
            nomeTXT.Location = new Point(18, 36);
            nomeTXT.Name = "nomeTXT";
            nomeTXT.Size = new Size(100, 23);
            nomeTXT.TabIndex = 0;
            // 
            // ADCproduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(3, 62, 140);
            ClientSize = new Size(368, 222);
            Controls.Add(panel1);
            Name = "ADCproduto";
            Text = "ADCproduto";
            Load += ADCproduto_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox valorTXT;
        private TextBox quantidadeTXT;
        private TextBox nomeTXT;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label1;
        private Button button2;
    }
}