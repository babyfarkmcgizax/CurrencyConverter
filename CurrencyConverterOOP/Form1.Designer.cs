namespace CurrencyConverterOOP
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.euroBtn = new System.Windows.Forms.Button();
            this.poundBtn = new System.Windows.Forms.Button();
            this.dollarBtn = new System.Windows.Forms.Button();
            this.yenBtn = new System.Windows.Forms.Button();
            this.closeMenuBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select currency you wish to convert from:";
            // 
            // euroBtn
            // 
            this.euroBtn.BackColor = System.Drawing.Color.YellowGreen;
            this.euroBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.euroBtn.Location = new System.Drawing.Point(50, 59);
            this.euroBtn.Name = "euroBtn";
            this.euroBtn.Size = new System.Drawing.Size(75, 46);
            this.euroBtn.TabIndex = 1;
            this.euroBtn.Text = "Euros";
            this.euroBtn.UseVisualStyleBackColor = false;
            this.euroBtn.Click += new System.EventHandler(this.euroBtn_Click);
            // 
            // poundBtn
            // 
            this.poundBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.poundBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.poundBtn.Location = new System.Drawing.Point(172, 59);
            this.poundBtn.Name = "poundBtn";
            this.poundBtn.Size = new System.Drawing.Size(75, 46);
            this.poundBtn.TabIndex = 2;
            this.poundBtn.Text = "Pounds Sterling";
            this.poundBtn.UseVisualStyleBackColor = false;
            this.poundBtn.Click += new System.EventHandler(this.poundBtn_Click);
            // 
            // dollarBtn
            // 
            this.dollarBtn.BackColor = System.Drawing.Color.Blue;
            this.dollarBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dollarBtn.Location = new System.Drawing.Point(171, 111);
            this.dollarBtn.Name = "dollarBtn";
            this.dollarBtn.Size = new System.Drawing.Size(75, 44);
            this.dollarBtn.TabIndex = 3;
            this.dollarBtn.Text = "Dollars";
            this.dollarBtn.UseVisualStyleBackColor = false;
            this.dollarBtn.Click += new System.EventHandler(this.dollarBtn_Click);
            // 
            // yenBtn
            // 
            this.yenBtn.BackColor = System.Drawing.Color.Crimson;
            this.yenBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.yenBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.yenBtn.Location = new System.Drawing.Point(50, 111);
            this.yenBtn.Name = "yenBtn";
            this.yenBtn.Size = new System.Drawing.Size(75, 44);
            this.yenBtn.TabIndex = 4;
            this.yenBtn.Text = "Yen";
            this.yenBtn.UseVisualStyleBackColor = false;
            this.yenBtn.Click += new System.EventHandler(this.yenBtn_Click);
            // 
            // closeMenuBtn
            // 
            this.closeMenuBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.closeMenuBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.closeMenuBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeMenuBtn.Location = new System.Drawing.Point(297, 90);
            this.closeMenuBtn.Name = "closeMenuBtn";
            this.closeMenuBtn.Size = new System.Drawing.Size(75, 23);
            this.closeMenuBtn.TabIndex = 7;
            this.closeMenuBtn.Text = "Close";
            this.closeMenuBtn.UseVisualStyleBackColor = false;
            this.closeMenuBtn.Click += new System.EventHandler(this.closeMenuBtn_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(418, 200);
            this.Controls.Add(this.closeMenuBtn);
            this.Controls.Add(this.yenBtn);
            this.Controls.Add(this.dollarBtn);
            this.Controls.Add(this.poundBtn);
            this.Controls.Add(this.euroBtn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Currency Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button euroBtn;
        private System.Windows.Forms.Button poundBtn;
        private System.Windows.Forms.Button dollarBtn;
        private System.Windows.Forms.Button yenBtn;
        private System.Windows.Forms.Button closeMenuBtn;
    }
}

