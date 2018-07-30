namespace CaixaEletronico
{
    partial class CadastroDeContas
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
            this.numeroDaConta = new System.Windows.Forms.TextBox();
            this.titularConta = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tipoDeConta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numeroDaConta
            // 
            this.numeroDaConta.Location = new System.Drawing.Point(82, 97);
            this.numeroDaConta.Name = "numeroDaConta";
            this.numeroDaConta.Size = new System.Drawing.Size(100, 20);
            this.numeroDaConta.TabIndex = 0;
            this.numeroDaConta.TextChanged += new System.EventHandler(this.numeroDaConta_TextChanged);
            // 
            // titularConta
            // 
            this.titularConta.Location = new System.Drawing.Point(82, 155);
            this.titularConta.Name = "titularConta";
            this.titularConta.Size = new System.Drawing.Size(100, 20);
            this.titularConta.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tipoDeConta
            // 
            this.tipoDeConta.FormattingEnabled = true;
            this.tipoDeConta.Location = new System.Drawing.Point(71, 25);
            this.tipoDeConta.Name = "tipoDeConta";
            this.tipoDeConta.Size = new System.Drawing.Size(121, 21);
            this.tipoDeConta.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Escolha o tipo da sua nova conta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Digite um número para sua conta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nome do titular da conta:";
            // 
            // CadastroDeContas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tipoDeConta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.titularConta);
            this.Controls.Add(this.numeroDaConta);
            this.Name = "CadastroDeContas";
            this.Text = "CadastroDeContas";
            this.Load += new System.EventHandler(this.CadastroDeContas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numeroDaConta;
        private System.Windows.Forms.TextBox titularConta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox tipoDeConta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}