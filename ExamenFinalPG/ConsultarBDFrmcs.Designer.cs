namespace ExamenFinalPG
{
    partial class ConsultarBDFrmcs
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TipoConsultaCmb = new System.Windows.Forms.ComboBox();
            this.Nittxt = new System.Windows.Forms.TextBox();
            this.Mestxt = new System.Windows.Forms.TextBox();
            this.AñoTxt = new System.Windows.Forms.TextBox();
            this.Nit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(617, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(110, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(547, 188);
            this.dataGridView1.TabIndex = 1;
            // 
            // TipoConsultaCmb
            // 
            this.TipoConsultaCmb.FormattingEnabled = true;
            this.TipoConsultaCmb.Items.AddRange(new object[] {
            "Recaudos",
            "RecaudosPoragente,mes y año"});
            this.TipoConsultaCmb.Location = new System.Drawing.Point(478, 56);
            this.TipoConsultaCmb.Name = "TipoConsultaCmb";
            this.TipoConsultaCmb.Size = new System.Drawing.Size(121, 21);
            this.TipoConsultaCmb.TabIndex = 2;
            // 
            // Nittxt
            // 
            this.Nittxt.Location = new System.Drawing.Point(81, 57);
            this.Nittxt.Name = "Nittxt";
            this.Nittxt.Size = new System.Drawing.Size(100, 20);
            this.Nittxt.TabIndex = 3;
            // 
            // Mestxt
            // 
            this.Mestxt.Location = new System.Drawing.Point(208, 57);
            this.Mestxt.Name = "Mestxt";
            this.Mestxt.Size = new System.Drawing.Size(100, 20);
            this.Mestxt.TabIndex = 4;
            // 
            // AñoTxt
            // 
            this.AñoTxt.Location = new System.Drawing.Point(337, 56);
            this.AñoTxt.Name = "AñoTxt";
            this.AñoTxt.Size = new System.Drawing.Size(100, 20);
            this.AñoTxt.TabIndex = 5;
            // 
            // Nit
            // 
            this.Nit.AutoSize = true;
            this.Nit.Location = new System.Drawing.Point(107, 32);
            this.Nit.Name = "Nit";
            this.Nit.Size = new System.Drawing.Size(56, 13);
            this.Nit.TabIndex = 6;
            this.Nit.Text = "Nit agente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(371, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Año";
            // 
            // ConsultarBDFrmcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 430);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nit);
            this.Controls.Add(this.AñoTxt);
            this.Controls.Add(this.Mestxt);
            this.Controls.Add(this.Nittxt);
            this.Controls.Add(this.TipoConsultaCmb);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "ConsultarBDFrmcs";
            this.Text = "ConsultarBDFrmcs";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox TipoConsultaCmb;
        private System.Windows.Forms.TextBox Nittxt;
        private System.Windows.Forms.TextBox Mestxt;
        private System.Windows.Forms.TextBox AñoTxt;
        private System.Windows.Forms.Label Nit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}