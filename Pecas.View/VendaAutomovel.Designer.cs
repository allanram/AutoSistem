namespace Pecas.View
{
    partial class VendaAutomovel
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
            label1 = new Label();
            txtQuantidadeDisponivel = new TextBox();
            txtQuantidadeVendida = new TextBox();
            txtNomeBloco = new TextBox();
            txtNomeAutomovel = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnRealizarVenda = new Button();
            textBox1 = new TextBox();
            label5 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(btnRealizarVenda);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtQuantidadeDisponivel);
            panel1.Controls.Add(txtQuantidadeVendida);
            panel1.Controls.Add(txtNomeBloco);
            panel1.Controls.Add(txtNomeAutomovel);
            panel1.Location = new Point(1, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(584, 265);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(165, 41);
            label2.Name = "label2";
            label2.Size = new Size(127, 15);
            label2.TabIndex = 5;
            label2.Text = "Quantidade Disponivel";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 41);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 4;
            label1.Text = "Automóvel";
            // 
            // txtQuantidadeDisponivel
            // 
            txtQuantidadeDisponivel.Location = new Point(165, 59);
            txtQuantidadeDisponivel.Name = "txtQuantidadeDisponivel";
            txtQuantidadeDisponivel.Size = new Size(127, 23);
            txtQuantidadeDisponivel.TabIndex = 3;
            // 
            // txtQuantidadeVendida
            // 
            txtQuantidadeVendida.Location = new Point(311, 59);
            txtQuantidadeVendida.Name = "txtQuantidadeVendida";
            txtQuantidadeVendida.Size = new Size(123, 23);
            txtQuantidadeVendida.TabIndex = 2;
            // 
            // txtNomeBloco
            // 
            txtNomeBloco.Location = new Point(26, 102);
            txtNomeBloco.Name = "txtNomeBloco";
            txtNomeBloco.Size = new Size(116, 23);
            txtNomeBloco.TabIndex = 1;
            // 
            // txtNomeAutomovel
            // 
            txtNomeAutomovel.Location = new Point(26, 59);
            txtNomeAutomovel.Name = "txtNomeAutomovel";
            txtNomeAutomovel.Size = new Size(116, 23);
            txtNomeAutomovel.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(320, 41);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 6;
            label3.Text = "Quantidade Vendida";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 85);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 7;
            label4.Text = "BLOCO:";
            // 
            // btnRealizarVenda
            // 
            btnRealizarVenda.BackColor = Color.FromArgb(128, 255, 128);
            btnRealizarVenda.BackgroundImageLayout = ImageLayout.Center;
            btnRealizarVenda.ForeColor = Color.Black;
            btnRealizarVenda.Location = new Point(329, 125);
            btnRealizarVenda.Name = "btnRealizarVenda";
            btnRealizarVenda.Size = new Size(75, 23);
            btnRealizarVenda.TabIndex = 8;
            btnRealizarVenda.Text = "Vender";
            btnRealizarVenda.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(165, 102);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(116, 23);
            textBox1.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(165, 85);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 10;
            label5.Text = "Valor R$";
            // 
            // VendaAutomovel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 298);
            Controls.Add(panel1);
            Name = "VendaAutomovel";
            Text = "VendaAutomovel";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtQuantidadeDisponivel;
        private TextBox txtQuantidadeVendida;
        private TextBox txtNomeBloco;
        private TextBox txtNomeAutomovel;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label5;
        private TextBox textBox1;
        private Button btnRealizarVenda;
    }
}