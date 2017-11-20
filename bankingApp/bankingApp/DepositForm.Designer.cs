namespace bankingApp
{
    partial class DepositForm
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
            this.accNoBox = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.accTypeLable = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.currentBalLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.depositAmountBox = new System.Windows.Forms.TextBox();
            this.submitAmountBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make a deposit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Account no: ";
            // 
            // accNoBox
            // 
            this.accNoBox.Location = new System.Drawing.Point(117, 96);
            this.accNoBox.Name = "accNoBox";
            this.accNoBox.Size = new System.Drawing.Size(100, 20);
            this.accNoBox.TabIndex = 2;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(233, 96);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 3;
            this.searchBtn.Text = "search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // accTypeLable
            // 
            this.accTypeLable.AutoSize = true;
            this.accTypeLable.Location = new System.Drawing.Point(46, 180);
            this.accTypeLable.Name = "accTypeLable";
            this.accTypeLable.Size = new System.Drawing.Size(80, 13);
            this.accTypeLable.TabIndex = 4;
            this.accTypeLable.Text = "Account Type: ";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(46, 214);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(48, 13);
            this.genderLabel.TabIndex = 5;
            this.genderLabel.Text = "Gender: ";
            // 
            // currentBalLabel
            // 
            this.currentBalLabel.AutoSize = true;
            this.currentBalLabel.Location = new System.Drawing.Point(46, 250);
            this.currentBalLabel.Name = "currentBalLabel";
            this.currentBalLabel.Size = new System.Drawing.Size(88, 13);
            this.currentBalLabel.TabIndex = 6;
            this.currentBalLabel.Text = "Current balance: ";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(46, 127);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(41, 13);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Name: ";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(46, 154);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(51, 13);
            this.addressLabel.TabIndex = 8;
            this.addressLabel.Text = "Address: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Deposit: ";
            // 
            // depositAmountBox
            // 
            this.depositAmountBox.Location = new System.Drawing.Point(117, 284);
            this.depositAmountBox.Name = "depositAmountBox";
            this.depositAmountBox.Size = new System.Drawing.Size(100, 20);
            this.depositAmountBox.TabIndex = 10;
            this.depositAmountBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // submitAmountBtn
            // 
            this.submitAmountBtn.Location = new System.Drawing.Point(233, 284);
            this.submitAmountBtn.Name = "submitAmountBtn";
            this.submitAmountBtn.Size = new System.Drawing.Size(75, 23);
            this.submitAmountBtn.TabIndex = 11;
            this.submitAmountBtn.Text = "submit";
            this.submitAmountBtn.UseVisualStyleBackColor = true;
            this.submitAmountBtn.Click += new System.EventHandler(this.submitAmountBtn_Click);
            // 
            // DepositForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 403);
            this.Controls.Add(this.submitAmountBtn);
            this.Controls.Add(this.depositAmountBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.currentBalLabel);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.accTypeLable);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.accNoBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DepositForm";
            this.Text = "DepositForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox accNoBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label accTypeLable;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label currentBalLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox depositAmountBox;
        private System.Windows.Forms.Button submitAmountBtn;
    }
}