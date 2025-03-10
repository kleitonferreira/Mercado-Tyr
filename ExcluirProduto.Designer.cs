namespace SoftwareMercado
{
    partial class ExcluirProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcluirProduto));
            panel1 = new Panel();
            CBOid = new ComboBox();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            CBOprodutos = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(219, 219, 219);
            panel1.Controls.Add(CBOid);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(CBOprodutos);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(344, 198);
            panel1.TabIndex = 0;
            // 
            // CBOid
            // 
            CBOid.FormattingEnabled = true;
            CBOid.Location = new Point(17, 61);
            CBOid.Name = "CBOid";
            CBOid.Size = new Size(30, 23);
            CBOid.TabIndex = 3;
            CBOid.Visible = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.AppWorkspace;
            button2.Location = new Point(226, 125);
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
            button1.Location = new Point(17, 125);
            button1.Name = "button1";
            button1.Size = new Size(100, 50);
            button1.TabIndex = 2;
            button1.Text = "Excluir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.Location = new Point(303, 23);
            panel2.Name = "panel2";
            panel2.Size = new Size(23, 23);
            panel2.TabIndex = 1;
            // 
            // CBOprodutos
            // 
            CBOprodutos.FormattingEnabled = true;
            CBOprodutos.Location = new Point(17, 23);
            CBOprodutos.Name = "CBOprodutos";
            CBOprodutos.Size = new Size(280, 23);
            CBOprodutos.TabIndex = 0;
            // 
            // ExcluirProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(3, 62, 140);
            ClientSize = new Size(368, 222);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ExcluirProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ExcluirProduto";
            Load += ExcluirProduto_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Panel panel2;
        private ComboBox CBOprodutos;
        private ComboBox CBOid;
        private Button button2;
    }
}