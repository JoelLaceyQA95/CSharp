namespace messageForm
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
            this.messageBox = new System.Windows.Forms.TextBox();
            this.countWordsRadio = new System.Windows.Forms.RadioButton();
            this.UpperCaseLettersRadio = new System.Windows.Forms.RadioButton();
            this.lowerCaseLettersRadio = new System.Windows.Forms.RadioButton();
            this.numbersRadio = new System.Windows.Forms.RadioButton();
            this.specialCharactersRadio = new System.Windows.Forms.RadioButton();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Message";
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(79, 25);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(100, 20);
            this.messageBox.TabIndex = 1;
            // 
            // countWordsRadio
            // 
            this.countWordsRadio.AutoSize = true;
            this.countWordsRadio.Location = new System.Drawing.Point(26, 66);
            this.countWordsRadio.Name = "countWordsRadio";
            this.countWordsRadio.Size = new System.Drawing.Size(84, 17);
            this.countWordsRadio.TabIndex = 2;
            this.countWordsRadio.TabStop = true;
            this.countWordsRadio.Text = "Count words";
            this.countWordsRadio.UseVisualStyleBackColor = true;
            // 
            // UpperCaseLettersRadio
            // 
            this.UpperCaseLettersRadio.AutoSize = true;
            this.UpperCaseLettersRadio.Location = new System.Drawing.Point(26, 89);
            this.UpperCaseLettersRadio.Name = "UpperCaseLettersRadio";
            this.UpperCaseLettersRadio.Size = new System.Drawing.Size(108, 17);
            this.UpperCaseLettersRadio.TabIndex = 3;
            this.UpperCaseLettersRadio.TabStop = true;
            this.UpperCaseLettersRadio.Text = "Uppercase letters";
            this.UpperCaseLettersRadio.UseVisualStyleBackColor = true;
            this.UpperCaseLettersRadio.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // lowerCaseLettersRadio
            // 
            this.lowerCaseLettersRadio.AutoSize = true;
            this.lowerCaseLettersRadio.Location = new System.Drawing.Point(26, 112);
            this.lowerCaseLettersRadio.Name = "lowerCaseLettersRadio";
            this.lowerCaseLettersRadio.Size = new System.Drawing.Size(108, 17);
            this.lowerCaseLettersRadio.TabIndex = 4;
            this.lowerCaseLettersRadio.TabStop = true;
            this.lowerCaseLettersRadio.Text = "Lowercase letters";
            this.lowerCaseLettersRadio.UseVisualStyleBackColor = true;
            // 
            // numbersRadio
            // 
            this.numbersRadio.AutoSize = true;
            this.numbersRadio.Location = new System.Drawing.Point(26, 135);
            this.numbersRadio.Name = "numbersRadio";
            this.numbersRadio.Size = new System.Drawing.Size(67, 17);
            this.numbersRadio.TabIndex = 5;
            this.numbersRadio.TabStop = true;
            this.numbersRadio.Text = "Numbers";
            this.numbersRadio.UseVisualStyleBackColor = true;
            // 
            // specialCharactersRadio
            // 
            this.specialCharactersRadio.AutoSize = true;
            this.specialCharactersRadio.Location = new System.Drawing.Point(26, 158);
            this.specialCharactersRadio.Name = "specialCharactersRadio";
            this.specialCharactersRadio.Size = new System.Drawing.Size(113, 17);
            this.specialCharactersRadio.TabIndex = 6;
            this.specialCharactersRadio.TabStop = true;
            this.specialCharactersRadio.Text = "Special characters";
            this.specialCharactersRadio.UseVisualStyleBackColor = true;
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(79, 201);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(100, 20);
            this.outputBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Output";
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(176, 112);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 9;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.specialCharactersRadio);
            this.Controls.Add(this.numbersRadio);
            this.Controls.Add(this.lowerCaseLettersRadio);
            this.Controls.Add(this.UpperCaseLettersRadio);
            this.Controls.Add(this.countWordsRadio);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.RadioButton countWordsRadio;
        private System.Windows.Forms.RadioButton UpperCaseLettersRadio;
        private System.Windows.Forms.RadioButton lowerCaseLettersRadio;
        private System.Windows.Forms.RadioButton numbersRadio;
        private System.Windows.Forms.RadioButton specialCharactersRadio;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button submitBtn;
    }
}

