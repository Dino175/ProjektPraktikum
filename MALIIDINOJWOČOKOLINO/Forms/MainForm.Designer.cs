namespace MALIIDINOJWOČOKOLINO.Forms
{
    partial class MainForm
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
            this.dataGridObaveze = new System.Windows.Forms.DataGridView();
            this.txBoxObveze = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridObaveze)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridObaveze
            // 
            this.dataGridObaveze.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridObaveze.Location = new System.Drawing.Point(404, 12);
            this.dataGridObaveze.Name = "dataGridObaveze";
            this.dataGridObaveze.Size = new System.Drawing.Size(384, 426);
            this.dataGridObaveze.TabIndex = 0;
            // 
            // txBoxObveze
            // 
            this.txBoxObveze.Location = new System.Drawing.Point(13, 13);
            this.txBoxObveze.Multiline = true;
            this.txBoxObveze.Name = "txBoxObveze";
            this.txBoxObveze.Size = new System.Drawing.Size(337, 278);
            this.txBoxObveze.TabIndex = 1;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(13, 329);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.Text = "Spremi";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txBoxObveze);
            this.Controls.Add(this.dataGridObaveze);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridObaveze)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridObaveze;
        private System.Windows.Forms.TextBox txBoxObveze;
        private System.Windows.Forms.Button btnDodaj;
    }
}