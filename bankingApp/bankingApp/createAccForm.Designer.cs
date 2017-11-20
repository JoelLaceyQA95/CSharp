namespace bankingApp
{
    partial class createAccForm
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
            this.currentAccRadio = new System.Windows.Forms.RadioButton();
            this.savingsAccRadio = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.maleRadio = new System.Windows.Forms.RadioButton();
            this.femaleRadio = new System.Windows.Forms.RadioButton();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.createAccBtn = new System.Windows.Forms.Button();
            this.AccTypeGroup = new System.Windows.Forms.GroupBox();
            this.genderGroup = new System.Windows.Forms.GroupBox();
            this.AccTypeGroup.SuspendLayout();
            this.genderGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create new account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Account type";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // currentAccRadio
            // 
            this.currentAccRadio.AutoSize = true;
            this.currentAccRadio.Location = new System.Drawing.Point(6, 23);
            this.currentAccRadio.Name = "currentAccRadio";
            this.currentAccRadio.Size = new System.Drawing.Size(101, 17);
            this.currentAccRadio.TabIndex = 4;
            this.currentAccRadio.TabStop = true;
            this.currentAccRadio.Text = "Current account";
            this.currentAccRadio.UseVisualStyleBackColor = true;
            // 
            // savingsAccRadio
            // 
            this.savingsAccRadio.AutoSize = true;
            this.savingsAccRadio.Location = new System.Drawing.Point(6, 0);
            this.savingsAccRadio.Name = "savingsAccRadio";
            this.savingsAccRadio.Size = new System.Drawing.Size(105, 17);
            this.savingsAccRadio.TabIndex = 5;
            this.savingsAccRadio.TabStop = true;
            this.savingsAccRadio.Text = "Savings account";
            this.savingsAccRadio.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Gender";
            // 
            // maleRadio
            // 
            this.maleRadio.AutoSize = true;
            this.maleRadio.Location = new System.Drawing.Point(6, 15);
            this.maleRadio.Name = "maleRadio";
            this.maleRadio.Size = new System.Drawing.Size(48, 17);
            this.maleRadio.TabIndex = 7;
            this.maleRadio.TabStop = true;
            this.maleRadio.Text = "Male";
            this.maleRadio.UseVisualStyleBackColor = true;
            // 
            // femaleRadio
            // 
            this.femaleRadio.AutoSize = true;
            this.femaleRadio.Location = new System.Drawing.Point(6, 38);
            this.femaleRadio.Name = "femaleRadio";
            this.femaleRadio.Size = new System.Drawing.Size(59, 17);
            this.femaleRadio.TabIndex = 8;
            this.femaleRadio.TabStop = true;
            this.femaleRadio.Text = "Female";
            this.femaleRadio.UseVisualStyleBackColor = true;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(62, 105);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 9;
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(62, 139);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(100, 20);
            this.addressBox.TabIndex = 10;
            // 
            // createAccBtn
            // 
            this.createAccBtn.Location = new System.Drawing.Point(220, 324);
            this.createAccBtn.Name = "createAccBtn";
            this.createAccBtn.Size = new System.Drawing.Size(127, 23);
            this.createAccBtn.TabIndex = 11;
            this.createAccBtn.Text = "Create account";
            this.createAccBtn.UseVisualStyleBackColor = true;
            this.createAccBtn.Click += new System.EventHandler(this.createAccBtn_Click);
            // 
            // AccTypeGroup
            // 
            this.AccTypeGroup.Controls.Add(this.savingsAccRadio);
            this.AccTypeGroup.Controls.Add(this.currentAccRadio);
            this.AccTypeGroup.Location = new System.Drawing.Point(45, 195);
            this.AccTypeGroup.Name = "AccTypeGroup";
            this.AccTypeGroup.Size = new System.Drawing.Size(139, 69);
            this.AccTypeGroup.TabIndex = 12;
            this.AccTypeGroup.TabStop = false;
            this.AccTypeGroup.Text = "groupBox1";
            // 
            // genderGroup
            // 
            this.genderGroup.Controls.Add(this.femaleRadio);
            this.genderGroup.Controls.Add(this.maleRadio);
            this.genderGroup.Location = new System.Drawing.Point(45, 283);
            this.genderGroup.Name = "genderGroup";
            this.genderGroup.Size = new System.Drawing.Size(119, 64);
            this.genderGroup.TabIndex = 13;
            this.genderGroup.TabStop = false;
            this.genderGroup.Text = "groupBox2";
            // 
            // createAccForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 395);
            this.Controls.Add(this.genderGroup);
            this.Controls.Add(this.AccTypeGroup);
            this.Controls.Add(this.createAccBtn);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "createAccForm";
            this.Text = "createAccForm";
            this.AccTypeGroup.ResumeLayout(false);
            this.AccTypeGroup.PerformLayout();
            this.genderGroup.ResumeLayout(false);
            this.genderGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton currentAccRadio;
        private System.Windows.Forms.RadioButton savingsAccRadio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton maleRadio;
        private System.Windows.Forms.RadioButton femaleRadio;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.Button createAccBtn;
        private System.Windows.Forms.GroupBox AccTypeGroup;
        private System.Windows.Forms.GroupBox genderGroup;
    }
}