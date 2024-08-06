namespace WindowsFormsAppIII
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnINSERIR = new System.Windows.Forms.Button();
            this.btnNOVA = new System.Windows.Forms.Button();
            this.btnFECHAR = new System.Windows.Forms.Button();
            this.lblTOTAL = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQTDE = new System.Windows.Forms.TextBox();
            this.txtPRODUTO = new System.Windows.Forms.TextBox();
            this.txtUNIT = new System.Windows.Forms.TextBox();
            this.lstPRODUTOS = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor Unitário:";
            // 
            // btnINSERIR
            // 
            this.btnINSERIR.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnINSERIR.Location = new System.Drawing.Point(217, 244);
            this.btnINSERIR.Name = "btnINSERIR";
            this.btnINSERIR.Size = new System.Drawing.Size(145, 60);
            this.btnINSERIR.TabIndex = 3;
            this.btnINSERIR.TabStop = false;
            this.btnINSERIR.Text = "Inserir Produto";
            this.btnINSERIR.UseVisualStyleBackColor = true;
            this.btnINSERIR.Click += new System.EventHandler(this.btnINSERIR_Click);
            // 
            // btnNOVA
            // 
            this.btnNOVA.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnNOVA.Location = new System.Drawing.Point(98, 663);
            this.btnNOVA.Name = "btnNOVA";
            this.btnNOVA.Size = new System.Drawing.Size(145, 59);
            this.btnNOVA.TabIndex = 4;
            this.btnNOVA.TabStop = false;
            this.btnNOVA.Text = "Nova Venda";
            this.btnNOVA.UseVisualStyleBackColor = true;
            this.btnNOVA.Click += new System.EventHandler(this.btnNOVA_Click);
            // 
            // btnFECHAR
            // 
            this.btnFECHAR.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnFECHAR.Location = new System.Drawing.Point(320, 663);
            this.btnFECHAR.Name = "btnFECHAR";
            this.btnFECHAR.Size = new System.Drawing.Size(145, 59);
            this.btnFECHAR.TabIndex = 5;
            this.btnFECHAR.TabStop = false;
            this.btnFECHAR.Text = "Fechar";
            this.btnFECHAR.UseVisualStyleBackColor = true;
            this.btnFECHAR.Click += new System.EventHandler(this.btnFECHAR_Click);
            // 
            // lblTOTAL
            // 
            this.lblTOTAL.AutoSize = true;
            this.lblTOTAL.Font = new System.Drawing.Font("Modern No. 20", 15.75F);
            this.lblTOTAL.Location = new System.Drawing.Point(351, 628);
            this.lblTOTAL.Name = "lblTOTAL";
            this.lblTOTAL.Size = new System.Drawing.Size(78, 24);
            this.lblTOTAL.TabIndex = 6;
            this.lblTOTAL.Text = "R$ 0,00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 15.75F);
            this.label5.Location = new System.Drawing.Point(98, 628);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Total da Venda:";
            // 
            // txtQTDE
            // 
            this.txtQTDE.Font = new System.Drawing.Font("Monoid", 9.749999F);
            this.txtQTDE.Location = new System.Drawing.Point(217, 160);
            this.txtQTDE.Name = "txtQTDE";
            this.txtQTDE.Size = new System.Drawing.Size(248, 25);
            this.txtQTDE.TabIndex = 1;
            // 
            // txtPRODUTO
            // 
            this.txtPRODUTO.Font = new System.Drawing.Font("Monoid", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPRODUTO.Location = new System.Drawing.Point(217, 119);
            this.txtPRODUTO.Name = "txtPRODUTO";
            this.txtPRODUTO.Size = new System.Drawing.Size(248, 25);
            this.txtPRODUTO.TabIndex = 0;
            // 
            // txtUNIT
            // 
            this.txtUNIT.Font = new System.Drawing.Font("Monoid", 9.749999F);
            this.txtUNIT.Location = new System.Drawing.Point(217, 199);
            this.txtUNIT.Name = "txtUNIT";
            this.txtUNIT.Size = new System.Drawing.Size(248, 25);
            this.txtUNIT.TabIndex = 2;
            // 
            // lstPRODUTOS
            // 
            this.lstPRODUTOS.FormattingEnabled = true;
            this.lstPRODUTOS.Location = new System.Drawing.Point(38, 318);
            this.lstPRODUTOS.MultiColumn = true;
            this.lstPRODUTOS.Name = "lstPRODUTOS";
            this.lstPRODUTOS.Size = new System.Drawing.Size(504, 290);
            this.lstPRODUTOS.TabIndex = 11;
            this.lstPRODUTOS.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(126, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(321, 87);
            this.label4.TabIndex = 12;
            this.label4.Text = "CARLÃO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(334, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Supermercados";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 766);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstPRODUTOS);
            this.Controls.Add(this.txtUNIT);
            this.Controls.Add(this.txtPRODUTO);
            this.Controls.Add(this.txtQTDE);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTOTAL);
            this.Controls.Add(this.btnFECHAR);
            this.Controls.Add(this.btnNOVA);
            this.Controls.Add(this.btnINSERIR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnINSERIR;
        private System.Windows.Forms.Button btnNOVA;
        private System.Windows.Forms.Button btnFECHAR;
        private System.Windows.Forms.Label lblTOTAL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQTDE;
        private System.Windows.Forms.TextBox txtPRODUTO;
        private System.Windows.Forms.TextBox txtUNIT;
        private System.Windows.Forms.ListBox lstPRODUTOS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}

