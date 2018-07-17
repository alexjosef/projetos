namespace MaoNaMassaWF
{
    partial class Form1
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
            this.TextoTitular = new System.Windows.Forms.TextBox();
            this.TextoSaldo = new System.Windows.Forms.TextBox();
            this.TextoNumero = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TextoTitular
            // 
            this.TextoTitular.Location = new System.Drawing.Point(110, 47);
            this.TextoTitular.Name = "TextoTitular";
            this.TextoTitular.Size = new System.Drawing.Size(100, 20);
            this.TextoTitular.TabIndex = 0;
            // 
            // TextoSaldo
            // 
            this.TextoSaldo.Location = new System.Drawing.Point(110, 99);
            this.TextoSaldo.Name = "TextoSaldo";
            this.TextoSaldo.Size = new System.Drawing.Size(100, 20);
            this.TextoSaldo.TabIndex = 1;
            // 
            // TextoNumero
            // 
            this.TextoNumero.Location = new System.Drawing.Point(110, 73);
            this.TextoNumero.Name = "TextoNumero";
            this.TextoNumero.Size = new System.Drawing.Size(100, 20);
            this.TextoNumero.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 310);
            this.Controls.Add(this.TextoNumero);
            this.Controls.Add(this.TextoSaldo);
            this.Controls.Add(this.TextoTitular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextoTitular;
        private System.Windows.Forms.TextBox TextoSaldo;
        private System.Windows.Forms.TextBox TextoNumero;
    }
}

