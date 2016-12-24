namespace YeniOtobus
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
            this.PicKamilKoc = new System.Windows.Forms.PictureBox();
            this.labelOtobusTuru = new System.Windows.Forms.Label();
            this.CBoxOtobusTuru = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicKamilKoc)).BeginInit();
            this.SuspendLayout();
            // 
            // PicKamilKoc
            // 
            this.PicKamilKoc.Location = new System.Drawing.Point(12, 34);
            this.PicKamilKoc.Name = "PicKamilKoc";
            this.PicKamilKoc.Size = new System.Drawing.Size(430, 229);
            this.PicKamilKoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicKamilKoc.TabIndex = 0;
            this.PicKamilKoc.TabStop = false;
            // 
            // labelOtobusTuru
            // 
            this.labelOtobusTuru.AutoSize = true;
            this.labelOtobusTuru.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOtobusTuru.Location = new System.Drawing.Point(129, 280);
            this.labelOtobusTuru.Name = "labelOtobusTuru";
            this.labelOtobusTuru.Size = new System.Drawing.Size(205, 25);
            this.labelOtobusTuru.TabIndex = 1;
            this.labelOtobusTuru.Text = "Otobüs Türü Seçiniz";
            // 
            // CBoxOtobusTuru
            // 
            this.CBoxOtobusTuru.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CBoxOtobusTuru.FormattingEnabled = true;
            this.CBoxOtobusTuru.Items.AddRange(new object[] {
            "Travego",
            "Neoplan"});
            this.CBoxOtobusTuru.Location = new System.Drawing.Point(125, 308);
            this.CBoxOtobusTuru.Name = "CBoxOtobusTuru";
            this.CBoxOtobusTuru.Size = new System.Drawing.Size(209, 32);
            this.CBoxOtobusTuru.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 756);
            this.Controls.Add(this.CBoxOtobusTuru);
            this.Controls.Add(this.labelOtobusTuru);
            this.Controls.Add(this.PicKamilKoc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicKamilKoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicKamilKoc;
        private System.Windows.Forms.Label labelOtobusTuru;
        private System.Windows.Forms.ComboBox CBoxOtobusTuru;
    }
}

