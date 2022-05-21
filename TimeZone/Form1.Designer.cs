
namespace TimeZone
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
            this.cityListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timeZoneLabel = new System.Windows.Forms.Label();
            this.okBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(606, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a city and I will give you the time zone:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cityListBox
            // 
            this.cityListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityListBox.FormattingEnabled = true;
            this.cityListBox.ItemHeight = 31;
            this.cityListBox.Items.AddRange(new object[] {
            "Denver",
            "Honolulu",
            "Minneapolis",
            "New York",
            "San Francisco"});
            this.cityListBox.Location = new System.Drawing.Point(251, 78);
            this.cityListBox.Name = "cityListBox";
            this.cityListBox.Size = new System.Drawing.Size(290, 159);
            this.cityListBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Time Zone:";
            // 
            // timeZoneLabel
            // 
            this.timeZoneLabel.BackColor = System.Drawing.SystemColors.Info;
            this.timeZoneLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeZoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeZoneLabel.Location = new System.Drawing.Point(312, 281);
            this.timeZoneLabel.Name = "timeZoneLabel";
            this.timeZoneLabel.Size = new System.Drawing.Size(300, 56);
            this.timeZoneLabel.TabIndex = 3;
            this.timeZoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // okBtn
            // 
            this.okBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.okBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okBtn.Location = new System.Drawing.Point(143, 360);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(240, 65);
            this.okBtn.TabIndex = 4;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = false;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(417, 360);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(240, 65);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.timeZoneLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cityListBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Time Zone";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox cityListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label timeZoneLabel;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}

