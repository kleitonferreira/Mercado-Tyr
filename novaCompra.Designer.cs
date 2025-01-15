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
            dataGridProdutosVenda = new DataGridView();
            panel3 = new Panel();
            quantidadeTXT = new TextBox();
            CBOIDproduto = new ComboBox();
            CBOproduto = new ComboBox();
            ultimoProdutoLBL = new Label();
            button2 = new Button();
            button1 = new Button();
            panelCOR = new Panel();
            TextoCaixa = new Label();
            panel2 = new Panel();
            panel4 = new Panel();
            qtdeLBL = new Label();
            precoLBL = new Label();
            button3 = new Button();
            TrocoLBL = new Label();
            PagamentoLBL = new Label();
            TotalCompraLBL = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridProdutosVenda).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(219, 219, 219);
            panel1.Controls.Add(dataGridProdutosVenda);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(822, 540);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // dataGridProdutosVenda
            // 
            dataGridProdutosVenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridProdutosVenda.Dock = DockStyle.Fill;
            dataGridProdutosVenda.Location = new Point(0, 87);
            dataGridProdutosVenda.Name = "dataGridProdutosVenda";
            dataGridProdutosVenda.Size = new Size(822, 366);
            dataGridProdutosVenda.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(quantidadeTXT);
            panel3.Controls.Add(CBOIDproduto);
            panel3.Controls.Add(CBOproduto);
            panel3.Controls.Add(ultimoProdutoLBL);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(panelCOR);
            panel3.Controls.Add(TextoCaixa);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(822, 87);
            panel3.TabIndex = 1;
            // 
            // quantidadeTXT
            // 
            quantidadeTXT.Location = new Point(240, 45);
            quantidadeTXT.Name = "quantidadeTXT";
            quantidadeTXT.Size = new Size(111, 23);
            quantidadeTXT.TabIndex = 6;
            // 
            // CBOIDproduto
            // 
            CBOIDproduto.FormattingEnabled = true;
            CBOIDproduto.Location = new Point(197, 13);
            CBOIDproduto.Name = "CBOIDproduto";
            CBOIDproduto.Size = new Size(21, 23);
            CBOIDproduto.TabIndex = 5;
            CBOIDproduto.Visible = false;
            // 
            // CBOproduto
            // 
            CBOproduto.FormattingEnabled = true;
            CBOproduto.Location = new Point(46, 45);
            CBOproduto.Name = "CBOproduto";
            CBOproduto.Size = new Size(172, 23);
            CBOproduto.TabIndex = 5;
            // 
            // ultimoProdutoLBL
            // 
            ultimoProdutoLBL.AutoSize = true;
            ultimoProdutoLBL.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ultimoProdutoLBL.ForeColor = Color.FromArgb(217, 4, 61);
            ultimoProdutoLBL.Location = new Point(629, 45);
            ultimoProdutoLBL.Name = "ultimoProdutoLBL";
            ultimoProdutoLBL.Size = new Size(78, 32);
            ultimoProdutoLBL.TabIndex = 4;
            ultimoProdutoLBL.Text = "label2";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(242, 135, 5);
            button2.Location = new Point(629, 7);
            button2.Name = "button2";
            button2.Size = new Size(124, 32);
            button2.TabIndex = 2;
            button2.Text = "Iniciar venda";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(242, 135, 5);
            button1.Location = new Point(364, 45);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(23, 23);
            button1.TabIndex = 2;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panelCOR
            // 
            panelCOR.Location = new Point(46, 7);
            panelCOR.Name = "panelCOR";
            panelCOR.Size = new Size(21, 21);
            panelCOR.TabIndex = 1;
            // 
            // TextoCaixa
            // 
            TextoCaixa.AutoSize = true;
            TextoCaixa.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TextoCaixa.Location = new Point(70, 7);
            TextoCaixa.Margin = new Padding(0);
            TextoCaixa.Name = "TextoCaixa";
            TextoCaixa.Size = new Size(57, 21);
            TextoCaixa.TabIndex = 0;
            TextoCaixa.Text = "label1";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(qtdeLBL);
            panel2.Controls.Add(precoLBL);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(TrocoLBL);
            panel2.Controls.Add(PagamentoLBL);
            panel2.Controls.Add(TotalCompraLBL);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 453);
            panel2.Name = "panel2";
            panel2.Size = new Size(822, 87);
            panel2.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(242, 135, 5);
            panel4.Location = new Point(481, 15);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 56);
            panel4.TabIndex = 4;
            // 
            // qtdeLBL
            // 
            qtdeLBL.AutoSize = true;
            qtdeLBL.Location = new Point(142, 37);
            qtdeLBL.Name = "qtdeLBL";
            qtdeLBL.Size = new Size(38, 15);
            qtdeLBL.TabIndex = 3;
            qtdeLBL.Text = "label1";
            // 
            // precoLBL
            // 
            precoLBL.AutoSize = true;
            precoLBL.Location = new Point(249, 37);
            precoLBL.Name = "precoLBL";
            precoLBL.Size = new Size(38, 15);
            precoLBL.TabIndex = 4;
            precoLBL.Text = "label2";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(217, 4, 61);
            button3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(629, 15);
            button3.Name = "button3";
            button3.Size = new Size(135, 56);
            button3.TabIndex = 2;
            button3.Text = "Finalizar compra";
            button3.UseVisualStyleBackColor = false;
            // 
            // TrocoLBL
            // 
            TrocoLBL.AutoSize = true;
            TrocoLBL.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TrocoLBL.Location = new Point(497, 45);
            TrocoLBL.Name = "TrocoLBL";
            TrocoLBL.Size = new Size(68, 30);
            TrocoLBL.TabIndex = 3;
            TrocoLBL.Text = "label1";
            // 
            // PagamentoLBL
            // 
            PagamentoLBL.AutoSize = true;
            PagamentoLBL.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PagamentoLBL.Location = new Point(497, 15);
            PagamentoLBL.Name = "PagamentoLBL";
            PagamentoLBL.Size = new Size(68, 30);
            PagamentoLBL.TabIndex = 3;
            PagamentoLBL.Text = "label1";
            // 
            // TotalCompraLBL
            // 
            TotalCompraLBL.AutoSize = true;
            TotalCompraLBL.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TotalCompraLBL.Location = new Point(375, 25);
            TotalCompraLBL.Name = "TotalCompraLBL";
            TotalCompraLBL.Size = new Size(68, 30);
            TotalCompraLBL.TabIndex = 3;
            TotalCompraLBL.Text = "label1";
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
            ((System.ComponentModel.ISupportInitialize)dataGridProdutosVenda).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Panel panelCOR;
        private Label TextoCaixa;
        private Button button1;
        private Button button2;
        private Label precoLBL;
        private Label TotalCompraLBL;
        private Button button3;
        private Label ultimoProdutoLBL;
        private Label qtdeLBL;
        private Panel panel4;
        private Label PagamentoLBL;
        private Label TrocoLBL;
        private DataGridView dataGridProdutosVenda;
        private TextBox quantidadeTXT;
        private ComboBox CBOIDproduto;
        private ComboBox CBOproduto;
    }
}