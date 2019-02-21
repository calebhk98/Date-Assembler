namespace Birth_Date_String
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dayOfWeek = new System.Windows.Forms.TextBox();
            this.NameOfMonth = new System.Windows.Forms.TextBox();
            this.numberOfMonth = new System.Windows.Forms.TextBox();
            this.Year = new System.Windows.Forms.TextBox();
            this.DateBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.DateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(30, 29);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(191, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the day of the week";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(29, 55);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(191, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter the name of the month";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(29, 81);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(191, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter the numeric day of the month";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(29, 107);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(191, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enter the year";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dayOfWeek
            // 
            this.dayOfWeek.Location = new System.Drawing.Point(227, 32);
            this.dayOfWeek.Name = "dayOfWeek";
            this.dayOfWeek.Size = new System.Drawing.Size(137, 20);
            this.dayOfWeek.TabIndex = 4;
            // 
            // NameOfMonth
            // 
            this.NameOfMonth.Location = new System.Drawing.Point(226, 58);
            this.NameOfMonth.Name = "NameOfMonth";
            this.NameOfMonth.Size = new System.Drawing.Size(137, 20);
            this.NameOfMonth.TabIndex = 5;
            // 
            // numberOfMonth
            // 
            this.numberOfMonth.Location = new System.Drawing.Point(226, 84);
            this.numberOfMonth.Name = "numberOfMonth";
            this.numberOfMonth.Size = new System.Drawing.Size(137, 20);
            this.numberOfMonth.TabIndex = 6;
            // 
            // Year
            // 
            this.Year.Location = new System.Drawing.Point(227, 110);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(137, 20);
            this.Year.TabIndex = 7;
            // 
            // DateBtn
            // 
            this.DateBtn.Location = new System.Drawing.Point(36, 234);
            this.DateBtn.Name = "DateBtn";
            this.DateBtn.Size = new System.Drawing.Size(75, 23);
            this.DateBtn.TabIndex = 8;
            this.DateBtn.Text = "Show Date";
            this.DateBtn.UseVisualStyleBackColor = true;
            this.DateBtn.Click += new System.EventHandler(this.DateBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(146, 233);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearBtn.TabIndex = 9;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(266, 232);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitBtn.TabIndex = 10;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // DateLabel
            // 
            this.DateLabel.Location = new System.Drawing.Point(36, 156);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(305, 28);
            this.DateLabel.TabIndex = 11;
            this.DateLabel.Text = "This is where the date will be";
            this.DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 353);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.DateBtn);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.numberOfMonth);
            this.Controls.Add(this.NameOfMonth);
            this.Controls.Add(this.dayOfWeek);
            this.Controls.Add(this.label4);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dayOfWeek;
        private System.Windows.Forms.TextBox NameOfMonth;
        private System.Windows.Forms.TextBox numberOfMonth;
        private System.Windows.Forms.TextBox Year;
        private System.Windows.Forms.Button DateBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label DateLabel;
    }
}

