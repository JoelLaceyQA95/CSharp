namespace databaseTest
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
            this.regNoBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.marksBox = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.regNoBox2 = new System.Windows.Forms.TextBox();
            this.nameBox2 = new System.Windows.Forms.TextBox();
            this.marksBox2 = new System.Windows.Forms.TextBox();
            this.showBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // regNoBox
            // 
            this.regNoBox.Location = new System.Drawing.Point(38, 40);
            this.regNoBox.Name = "regNoBox";
            this.regNoBox.Size = new System.Drawing.Size(100, 20);
            this.regNoBox.TabIndex = 0;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(38, 80);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 1;
            // 
            // marksBox
            // 
            this.marksBox.Location = new System.Drawing.Point(38, 118);
            this.marksBox.Name = "marksBox";
            this.marksBox.Size = new System.Drawing.Size(100, 20);
            this.marksBox.TabIndex = 2;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(38, 157);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 3;
            this.submit.Text = "submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // regNoBox2
            // 
            this.regNoBox2.Location = new System.Drawing.Point(258, 40);
            this.regNoBox2.Name = "regNoBox2";
            this.regNoBox2.Size = new System.Drawing.Size(100, 20);
            this.regNoBox2.TabIndex = 4;
            // 
            // nameBox2
            // 
            this.nameBox2.Location = new System.Drawing.Point(258, 80);
            this.nameBox2.Name = "nameBox2";
            this.nameBox2.Size = new System.Drawing.Size(100, 20);
            this.nameBox2.TabIndex = 5;
            // 
            // marksBox2
            // 
            this.marksBox2.Location = new System.Drawing.Point(258, 118);
            this.marksBox2.Name = "marksBox2";
            this.marksBox2.Size = new System.Drawing.Size(100, 20);
            this.marksBox2.TabIndex = 6;
            // 
            // showBtn
            // 
            this.showBtn.Location = new System.Drawing.Point(258, 156);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(75, 23);
            this.showBtn.TabIndex = 7;
            this.showBtn.Text = "show record";
            this.showBtn.UseVisualStyleBackColor = true;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 268);
            this.Controls.Add(this.showBtn);
            this.Controls.Add(this.marksBox2);
            this.Controls.Add(this.nameBox2);
            this.Controls.Add(this.regNoBox2);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.marksBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.regNoBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox regNoBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox marksBox;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox regNoBox2;
        private System.Windows.Forms.TextBox nameBox2;
        private System.Windows.Forms.TextBox marksBox2;
        private System.Windows.Forms.Button showBtn;
    }
}

