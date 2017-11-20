namespace multipleWindowMaths
{
    partial class displayResult
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
            this.resultBox = new System.Windows.Forms.TextBox();
            this.mainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(68, 58);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(100, 20);
            this.resultBox.TabIndex = 0;
            // 
            // mainMenu
            // 
            this.mainMenu.Location = new System.Drawing.Point(68, 131);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(75, 23);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "Main menu";
            this.mainMenu.UseVisualStyleBackColor = true;
            this.mainMenu.Click += new System.EventHandler(this.mainMenu_Click);
            // 
            // displayResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 303);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.resultBox);
            this.Name = "displayResult";
            this.Text = "displayResult";
            this.Load += new System.EventHandler(this.displayResult_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Button mainMenu;
    }
}