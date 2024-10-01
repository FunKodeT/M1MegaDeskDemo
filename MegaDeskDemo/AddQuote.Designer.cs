namespace MegaDeskDemo
{
    partial class AddQuote
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
            this.menuBackBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menuBackBtn
            // 
            this.menuBackBtn.Location = new System.Drawing.Point(12, 386);
            this.menuBackBtn.Name = "menuBackBtn";
            this.menuBackBtn.Size = new System.Drawing.Size(198, 52);
            this.menuBackBtn.TabIndex = 0;
            this.menuBackBtn.Text = "Go Back";
            this.menuBackBtn.UseVisualStyleBackColor = true;
            this.menuBackBtn.Click += new System.EventHandler(this.GoBack);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuBackBtn);
            this.Name = "AddQuote";
            this.Text = "View Quotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button menuBackBtn;
    }
}