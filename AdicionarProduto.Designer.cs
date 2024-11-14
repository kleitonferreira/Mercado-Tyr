namespace SoftwareMercado
{
    partial class AdicionarProduto
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
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            QNTDprodutoTXT = new TextBox();
            NomeProdutoTXT = new TextBox();
            label3 = new Label();
            ValorTXT = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(219, 219, 219);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(QNTDprodutoTXT);
            panel1.Controls.Add(ValorTXT);
            panel1.Controls.Add(NomeProdutoTXT);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(344, 198);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.AppWorkspace;
            button2.Location = new Point(224, 125);
            button2.Name = "button2";
            button2.Size = new Size(100, 50);
            button2.TabIndex = 2;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.AppWorkspace;
            button1.Location = new Point(36, 125);
            button1.Name = "button1";
            button1.Size = new Size(100, 50);
            button1.TabIndex = 2;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(255, 21);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 1;
            label2.Text = "Quantidade";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 21);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome do produto";
            // 
            // QNTDprodutoTXT
            // 
            QNTDprodutoTXT.Location = new Point(255, 39);
            QNTDprodutoTXT.Name = "QNTDprodutoTXT";
            QNTDprodutoTXT.Size = new Size(69, 23);
            QNTDprodutoTXT.TabIndex = 0;
            // 
            // NomeProdutoTXT
            // 
            NomeProdutoTXT.Location = new Point(33, 39);
            NomeProdutoTXT.Name = "NomeProdutoTXT";
            NomeProdutoTXT.Size = new Size(215, 23);
            NomeProdutoTXT.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 65);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 1;
            label3.Text = "Valor do Produto";
            // 
            // ValorTXT
            // 
            ValorTXT.Location = new Point(33, 83);
            ValorTXT.Name = "ValorTXT";
            ValorTXT.Size = new Size(215, 23);
            ValorTXT.TabIndex = 0;
            // 
            // AdicionarProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(3, 62, 140);
            ClientSize = new Size(368, 222);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AdicionarProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdicionarProduto";
            Load += AdicionarProduto_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private TextBox QNTDprodutoTXT;
        private TextBox NomeProdutoTXT;
        private Button button1;
        private Button button2;
        private Label label3;
        private TextBox ValorTXT;
    }
}