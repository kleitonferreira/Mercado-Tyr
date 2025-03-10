namespace SoftwareMercado
{
    partial class FormaPagamento
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
            trocoTXT = new TextBox();
            trocoLabel = new Label();
            label1 = new Label();
            pagamentoCBO = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(219, 219, 219);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(trocoTXT);
            panel1.Controls.Add(trocoLabel);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pagamentoCBO);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(344, 198);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.AppWorkspace;
            button2.Location = new Point(190, 120);
            button2.Name = "button2";
            button2.Size = new Size(100, 50);
            button2.TabIndex = 3;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.AppWorkspace;
            button1.Location = new Point(52, 120);
            button1.Name = "button1";
            button1.Size = new Size(100, 50);
            button1.TabIndex = 3;
            button1.Text = "Finalizar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // trocoTXT
            // 
            trocoTXT.Location = new Point(190, 39);
            trocoTXT.Name = "trocoTXT";
            trocoTXT.Size = new Size(130, 23);
            trocoTXT.TabIndex = 2;
            // 
            // trocoLabel
            // 
            trocoLabel.AutoSize = true;
            trocoLabel.Location = new Point(190, 21);
            trocoLabel.Name = "trocoLabel";
            trocoLabel.Size = new Size(100, 15);
            trocoLabel.TabIndex = 1;
            trocoLabel.Text = "Valor em dinheiro";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 21);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 1;
            label1.Text = "Forma de pagamento";
            // 
            // pagamentoCBO
            // 
            pagamentoCBO.DropDownStyle = ComboBoxStyle.DropDownList;
            pagamentoCBO.FormattingEnabled = true;
            pagamentoCBO.Items.AddRange(new object[] { "Dinheiro", "Débito", "Crédito", "Pix" });
            pagamentoCBO.Location = new Point(22, 39);
            pagamentoCBO.Name = "pagamentoCBO";
            pagamentoCBO.Size = new Size(130, 23);
            pagamentoCBO.TabIndex = 0;
            pagamentoCBO.SelectedIndexChanged += pagamentoCBO_SelectedIndexChanged;
            // 
            // FormaPagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(3, 62, 140);
            ClientSize = new Size(368, 222);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormaPagamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormaPagamento";
            Load += FormaPagamento_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ComboBox pagamentoCBO;
        private Button button1;
        private TextBox trocoTXT;
        private Label trocoLabel;
        private Button button2;
    }
}