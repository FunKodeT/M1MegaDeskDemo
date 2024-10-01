namespace MegaDeskDemo
{
    partial class mainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainMenu));
            this.quoteNewBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.quoteViewBtn = new System.Windows.Forms.Button();
            this.quoteSearchBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // quoteNewBtn
            // 
            this.quoteNewBtn.Location = new System.Drawing.Point(12, 12);
            this.quoteNewBtn.Name = "quoteNewBtn";
            this.quoteNewBtn.Size = new System.Drawing.Size(198, 52);
            this.quoteNewBtn.TabIndex = 0;
            this.quoteNewBtn.Text = "Add New Quote";
            this.quoteNewBtn.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(216, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 190);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // quoteViewBtn
            // 
            this.quoteViewBtn.Location = new System.Drawing.Point(12, 70);
            this.quoteViewBtn.Name = "quoteViewBtn";
            this.quoteViewBtn.Size = new System.Drawing.Size(198, 52);
            this.quoteViewBtn.TabIndex = 5;
            this.quoteViewBtn.Text = "View Quotes";
            this.quoteViewBtn.UseVisualStyleBackColor = true;
            this.quoteViewBtn.Click += new System.EventHandler(this.OpenViewQuotes);
            // 
            // quoteSearchBtn
            // 
            this.quoteSearchBtn.Location = new System.Drawing.Point(12, 128);
            this.quoteSearchBtn.Name = "quoteSearchBtn";
            this.quoteSearchBtn.Size = new System.Drawing.Size(198, 52);
            this.quoteSearchBtn.TabIndex = 6;
            this.quoteSearchBtn.Text = "Search Quotes";
            this.quoteSearchBtn.UseVisualStyleBackColor = true;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(12, 186);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(198, 52);
            this.exitBtn.TabIndex = 7;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 247);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.quoteSearchBtn);
            this.Controls.Add(this.quoteViewBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.quoteNewBtn);
            this.Name = "mainMenu";
            this.Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button quoteNewBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button quoteViewBtn;
        private System.Windows.Forms.Button quoteSearchBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}

