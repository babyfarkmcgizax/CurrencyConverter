namespace CurrencyConverterOOP
{
    partial class frmPound
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPound));
            this.label1 = new System.Windows.Forms.Label();
            this.txtPoundFrom = new System.Windows.Forms.TextBox();
            this.lstPoundFrom = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.closePoundBtn = new System.Windows.Forms.Button();
            this.convPoundBtn = new System.Windows.Forms.Button();
            this.txtPoundTo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Pound amount:";
            // 
            // txtPoundFrom
            // 
            this.txtPoundFrom.Location = new System.Drawing.Point(32, 55);
            this.txtPoundFrom.Name = "txtPoundFrom";
            this.txtPoundFrom.Size = new System.Drawing.Size(100, 20);
            this.txtPoundFrom.TabIndex = 1;
            // 
            // lstPoundFrom
            // 
            this.lstPoundFrom.FormattingEnabled = true;
            this.lstPoundFrom.Items.AddRange(new object[] {
            "Euro",
            "Dollar",
            "Yen"});
            this.lstPoundFrom.Location = new System.Drawing.Point(183, 52);
            this.lstPoundFrom.Name = "lstPoundFrom";
            this.lstPoundFrom.Size = new System.Drawing.Size(120, 95);
            this.lstPoundFrom.TabIndex = 2;
            this.lstPoundFrom.SelectedIndexChanged += new System.EventHandler(this.lstPoundFrom_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Currency";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Wingdings 3", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(145, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "g";
            // 
            // closePoundBtn
            // 
            this.closePoundBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.closePoundBtn.Location = new System.Drawing.Point(244, 167);
            this.closePoundBtn.Name = "closePoundBtn";
            this.closePoundBtn.Size = new System.Drawing.Size(75, 23);
            this.closePoundBtn.TabIndex = 5;
            this.closePoundBtn.Text = "Close";
            this.closePoundBtn.UseVisualStyleBackColor = false;
            this.closePoundBtn.Click += new System.EventHandler(this.closePoundBtn_Click);
            // 
            // convPoundBtn
            // 
            this.convPoundBtn.BackColor = System.Drawing.SystemColors.Info;
            this.convPoundBtn.Location = new System.Drawing.Point(41, 88);
            this.convPoundBtn.Name = "convPoundBtn";
            this.convPoundBtn.Size = new System.Drawing.Size(75, 23);
            this.convPoundBtn.TabIndex = 6;
            this.convPoundBtn.Text = "Convert";
            this.convPoundBtn.UseVisualStyleBackColor = false;
            this.convPoundBtn.Click += new System.EventHandler(this.convPoundBtn_Click);
            // 
            // txtPoundTo
            // 
            this.txtPoundTo.Location = new System.Drawing.Point(32, 129);
            this.txtPoundTo.Name = "txtPoundTo";
            this.txtPoundTo.Size = new System.Drawing.Size(100, 20);
            this.txtPoundTo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Wingdings 3", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(145, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "f";
            // 
            // frmPound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 202);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPoundTo);
            this.Controls.Add(this.convPoundBtn);
            this.Controls.Add(this.closePoundBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstPoundFrom);
            this.Controls.Add(this.txtPoundFrom);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPound";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Convert from Pounds (Sterling)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPoundFrom;
        private System.Windows.Forms.ListBox lstPoundFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button closePoundBtn;
        private System.Windows.Forms.Button convPoundBtn;
        private System.Windows.Forms.TextBox txtPoundTo;
        private System.Windows.Forms.Label label4;
    }
}