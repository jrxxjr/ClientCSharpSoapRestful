namespace TestSoapRestForms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        

        
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSoap = new System.Windows.Forms.Button();
            this.richTextSoap = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRest = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextRest = new System.Windows.Forms.RichTextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSoap
            // 
            this.btnSoap.Location = new System.Drawing.Point(110, 84);
            this.btnSoap.Name = "btnSoap";
            this.btnSoap.Size = new System.Drawing.Size(75, 23);
            this.btnSoap.TabIndex = 0;
            this.btnSoap.Text = "OK";
            this.btnSoap.UseVisualStyleBackColor = true;
            this.btnSoap.Click += new System.EventHandler(this.btnSoap_Click);
            // 
            // richTextSoap
            // 
            this.richTextSoap.Location = new System.Drawing.Point(64, 123);
            this.richTextSoap.Name = "richTextSoap";
            this.richTextSoap.ReadOnly = true;
            this.richTextSoap.Size = new System.Drawing.Size(180, 96);
            this.richTextSoap.TabIndex = 1;
            this.richTextSoap.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chamar Web Service Java";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "SOAP JAX-WS";
            // 
            // btnRest
            // 
            this.btnRest.Location = new System.Drawing.Point(110, 264);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(75, 23);
            this.btnRest.TabIndex = 4;
            this.btnRest.Text = "OK";
            this.btnRest.UseVisualStyleBackColor = true;
            this.btnRest.Click += new System.EventHandler(this.btnRest_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(107, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "RESTFULL";
            // 
            // richTextRest
            // 
            this.richTextRest.Location = new System.Drawing.Point(64, 303);
            this.richTextRest.Name = "richTextRest";
            this.richTextRest.ReadOnly = true;
            this.richTextRest.Size = new System.Drawing.Size(184, 90);
            this.richTextRest.TabIndex = 6;
            this.richTextRest.Text = "";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(110, 402);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 35);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 447);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.richTextRest);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextSoap);
            this.Controls.Add(this.btnSoap);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teste Web Service";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSoap;
        private System.Windows.Forms.RichTextBox richTextSoap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextRest;
        private System.Windows.Forms.Button btnLimpar;
    }
}

