namespace CurrencyConverterOOP
{
    partial class frmYen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYen));
            this.label1 = new System.Windows.Forms.Label();
            this.txtYenFrom = new System.Windows.Forms.TextBox();
            this.txtYenTo = new System.Windows.Forms.TextBox();
            this.lstYenFrom = new System.Windows.Forms.ListBox();
            this.closeYenBtn = new System.Windows.Forms.Button();
            this.convYenBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Yen amount:";
            // 
            // txtYenFrom
            // 
            this.txtYenFrom.Location = new System.Drawing.Point(34, 48);
            this.txtYenFrom.Name = "txtYenFrom";
            this.txtYenFrom.Size = new System.Drawing.Size(100, 20);
            this.txtYenFrom.TabIndex = 1;
            // 
            // txtYenTo
            // 
            this.txtYenTo.Location = new System.Drawing.Point(34, 121);
            this.txtYenTo.Name = "txtYenTo";
            this.txtYenTo.Size = new System.Drawing.Size(100, 20);
            this.txtYenTo.TabIndex = 2;
            // 
            // lstYenFrom
            // 
            this.lstYenFrom.FormattingEnabled = true;
            this.lstYenFrom.Items.AddRange(new object[] {
            "Euro",
            "Dollar",
            "Pound Sterling"});
            this.lstYenFrom.Location = new System.Drawing.Point(180, 46);
            this.lstYenFrom.Name = "lstYenFrom";
            this.lstYenFrom.Size = new System.Drawing.Size(120, 95);
            this.lstYenFrom.TabIndex = 3;
            this.lstYenFrom.SelectedIndexChanged += new System.EventHandler(this.lstYenFrom_SelectedIndexChanged);
            // 
            // closeYenBtn
            // 
            this.closeYenBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.closeYenBtn.Location = new System.Drawing.Point(245, 163);
            this.closeYenBtn.Name = "closeYenBtn";
            this.closeYenBtn.Size = new System.Drawing.Size(75, 23);
            this.closeYenBtn.TabIndex = 4;
            this.closeYenBtn.Text = "Close";
            this.closeYenBtn.UseVisualStyleBackColor = false;
            this.closeYenBtn.Click += new System.EventHandler(this.closeYenBtn_Click);
            // 
            // convYenBtn
            // 
            this.convYenBtn.BackColor = System.Drawing.SystemColors.Info;
            this.convYenBtn.Location = new System.Drawing.Point(45, 85);
            this.convYenBtn.Name = "convYenBtn";
            this.convYenBtn.Size = new System.Drawing.Size(75, 23);
            this.convYenBtn.TabIndex = 5;
            this.convYenBtn.Text = "Convert";
            this.convYenBtn.UseVisualStyleBackColor = false;
            this.convYenBtn.Click += new System.EventHandler(this.convYenBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Wingdings 3", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(141, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "g";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Wingdings 3", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(141, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "f";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Select Currency";
            // 
            // frmYen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 198);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.convYenBtn);
            this.Controls.Add(this.closeYenBtn);
            this.Controls.Add(this.lstYenFrom);
            this.Controls.Add(this.txtYenTo);
            this.Controls.Add(this.txtYenFrom);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmYen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Convert from Yen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYenFrom;
        private System.Windows.Forms.TextBox txtYenTo;
        private System.Windows.Forms.ListBox lstYenFrom;
        private System.Windows.Forms.Button closeYenBtn;
        private System.Windows.Forms.Button convYenBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}