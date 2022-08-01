namespace TrianguloUC12
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCalcTrian = new System.Windows.Forms.Label();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblresultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCalcTrian
            // 
            this.lblCalcTrian.AutoSize = true;
            this.lblCalcTrian.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCalcTrian.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalcTrian.Location = new System.Drawing.Point(260, 41);
            this.lblCalcTrian.Name = "lblCalcTrian";
            this.lblCalcTrian.Size = new System.Drawing.Size(217, 24);
            this.lblCalcTrian.TabIndex = 0;
            this.lblCalcTrian.Text = "Área do Triângulo";
            // 
            // txtBase
            // 
            this.txtBase.Font = new System.Drawing.Font("Wide Latin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBase.Location = new System.Drawing.Point(249, 130);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(249, 24);
            this.txtBase.TabIndex = 1;
            this.txtBase.Text = "Coloque a base:";
            this.txtBase.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtAltura
            // 
            this.txtAltura.Font = new System.Drawing.Font("Wide Latin", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltura.Location = new System.Drawing.Point(249, 229);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(249, 21);
            this.txtAltura.TabIndex = 2;
            this.txtAltura.Text = "Coloque a altura:";
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnCalc.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(293, 346);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(184, 23);
            this.btnCalc.TabIndex = 3;
            this.btnCalc.Text = "Descobrir a área";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(287, 356);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(0, 13);
            this.lblresultado.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.lblCalcTrian);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCalcTrian;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblresultado;
    }
}

