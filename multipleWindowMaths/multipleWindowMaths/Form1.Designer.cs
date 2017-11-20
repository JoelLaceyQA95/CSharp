namespace multipleWindowMaths
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
            this.numOne = new System.Windows.Forms.TextBox();
            this.numTwo = new System.Windows.Forms.TextBox();
            this.addRadio = new System.Windows.Forms.RadioButton();
            this.minusRadio = new System.Windows.Forms.RadioButton();
            this.multiplyRadio = new System.Windows.Forms.RadioButton();
            this.divideRadio = new System.Windows.Forms.RadioButton();
            this.submitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numOne
            // 
            this.numOne.Location = new System.Drawing.Point(45, 64);
            this.numOne.Name = "numOne";
            this.numOne.Size = new System.Drawing.Size(100, 20);
            this.numOne.TabIndex = 0;
            // 
            // numTwo
            // 
            this.numTwo.Location = new System.Drawing.Point(45, 104);
            this.numTwo.Name = "numTwo";
            this.numTwo.Size = new System.Drawing.Size(100, 20);
            this.numTwo.TabIndex = 1;
            // 
            // addRadio
            // 
            this.addRadio.AutoSize = true;
            this.addRadio.Location = new System.Drawing.Point(45, 130);
            this.addRadio.Name = "addRadio";
            this.addRadio.Size = new System.Drawing.Size(44, 17);
            this.addRadio.TabIndex = 2;
            this.addRadio.TabStop = true;
            this.addRadio.Text = "Add";
            this.addRadio.UseVisualStyleBackColor = true;
            // 
            // minusRadio
            // 
            this.minusRadio.AutoSize = true;
            this.minusRadio.Location = new System.Drawing.Point(45, 164);
            this.minusRadio.Name = "minusRadio";
            this.minusRadio.Size = new System.Drawing.Size(65, 17);
            this.minusRadio.TabIndex = 3;
            this.minusRadio.TabStop = true;
            this.minusRadio.Text = "Subtract";
            this.minusRadio.UseVisualStyleBackColor = true;
            // 
            // multiplyRadio
            // 
            this.multiplyRadio.AutoSize = true;
            this.multiplyRadio.Location = new System.Drawing.Point(45, 199);
            this.multiplyRadio.Name = "multiplyRadio";
            this.multiplyRadio.Size = new System.Drawing.Size(60, 17);
            this.multiplyRadio.TabIndex = 4;
            this.multiplyRadio.TabStop = true;
            this.multiplyRadio.Text = "Multiply";
            this.multiplyRadio.UseVisualStyleBackColor = true;
            // 
            // divideRadio
            // 
            this.divideRadio.AutoSize = true;
            this.divideRadio.Location = new System.Drawing.Point(45, 232);
            this.divideRadio.Name = "divideRadio";
            this.divideRadio.Size = new System.Drawing.Size(55, 17);
            this.divideRadio.TabIndex = 5;
            this.divideRadio.TabStop = true;
            this.divideRadio.Text = "Divide";
            this.divideRadio.UseVisualStyleBackColor = true;
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(45, 266);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 6;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "First Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Second Number";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 372);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.divideRadio);
            this.Controls.Add(this.multiplyRadio);
            this.Controls.Add(this.minusRadio);
            this.Controls.Add(this.addRadio);
            this.Controls.Add(this.numTwo);
            this.Controls.Add(this.numOne);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numOne;
        private System.Windows.Forms.TextBox numTwo;
        private System.Windows.Forms.RadioButton addRadio;
        private System.Windows.Forms.RadioButton minusRadio;
        private System.Windows.Forms.RadioButton multiplyRadio;
        private System.Windows.Forms.RadioButton divideRadio;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

