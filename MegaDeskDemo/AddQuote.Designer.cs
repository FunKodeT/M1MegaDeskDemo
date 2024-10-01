﻿namespace MegaDeskDemo
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
            this.submitOrderBtn = new System.Windows.Forms.Button();
            this.dateNowLbl = new System.Windows.Forms.Label();
            this.plzNameLbl = new System.Windows.Forms.Label();
            this.deskWidthLbl = new System.Windows.Forms.Label();
            this.deskDepthLbl = new System.Windows.Forms.Label();
            this.deskAmountLbl = new System.Windows.Forms.Label();
            this.matTypeLbl = new System.Windows.Forms.Label();
            this.shipTimeLbl = new System.Windows.Forms.Label();
            this.megaDeskHdrLbl = new System.Windows.Forms.Label();
            this.shipTimeReqLbl = new System.Windows.Forms.Label();
            this.dskDepReqLbl = new System.Windows.Forms.Label();
            this.dskWidReqLbl = new System.Windows.Forms.Label();
            this.DepthBox = new System.Windows.Forms.TextBox();
            this.ShippingComboBox = new System.Windows.Forms.ComboBox();
            this.MaterialComboBox = new System.Windows.Forms.ComboBox();
            this.DrawerInput = new System.Windows.Forms.ComboBox();
            this.WidthBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.DateLabel = new System.Windows.Forms.Label();
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
            // submitOrderBtn
            // 
            this.submitOrderBtn.Location = new System.Drawing.Point(235, 386);
            this.submitOrderBtn.Name = "submitOrderBtn";
            this.submitOrderBtn.Size = new System.Drawing.Size(198, 52);
            this.submitOrderBtn.TabIndex = 1;
            this.submitOrderBtn.Text = "Submit Order";
            this.submitOrderBtn.UseVisualStyleBackColor = true;
            // 
            // dateNowLbl
            // 
            this.dateNowLbl.AutoSize = true;
            this.dateNowLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNowLbl.Location = new System.Drawing.Point(8, 34);
            this.dateNowLbl.Name = "dateNowLbl";
            this.dateNowLbl.Size = new System.Drawing.Size(106, 20);
            this.dateNowLbl.TabIndex = 2;
            this.dateNowLbl.Text = "Today\'s Date:";
            // 
            // plzNameLbl
            // 
            this.plzNameLbl.AutoSize = true;
            this.plzNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plzNameLbl.Location = new System.Drawing.Point(8, 82);
            this.plzNameLbl.Name = "plzNameLbl";
            this.plzNameLbl.Size = new System.Drawing.Size(184, 20);
            this.plzNameLbl.TabIndex = 3;
            this.plzNameLbl.Text = "Please Enter Your Name";
            // 
            // deskWidthLbl
            // 
            this.deskWidthLbl.AutoSize = true;
            this.deskWidthLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deskWidthLbl.Location = new System.Drawing.Point(8, 134);
            this.deskWidthLbl.Name = "deskWidthLbl";
            this.deskWidthLbl.Size = new System.Drawing.Size(95, 20);
            this.deskWidthLbl.TabIndex = 4;
            this.deskWidthLbl.Text = "Desk Width:";
            // 
            // deskDepthLbl
            // 
            this.deskDepthLbl.AutoSize = true;
            this.deskDepthLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deskDepthLbl.Location = new System.Drawing.Point(8, 184);
            this.deskDepthLbl.Name = "deskDepthLbl";
            this.deskDepthLbl.Size = new System.Drawing.Size(98, 20);
            this.deskDepthLbl.TabIndex = 5;
            this.deskDepthLbl.Text = "Desk Depth:";
            // 
            // deskAmountLbl
            // 
            this.deskAmountLbl.AutoSize = true;
            this.deskAmountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deskAmountLbl.Location = new System.Drawing.Point(8, 233);
            this.deskAmountLbl.Name = "deskAmountLbl";
            this.deskAmountLbl.Size = new System.Drawing.Size(165, 20);
            this.deskAmountLbl.TabIndex = 6;
            this.deskAmountLbl.Text = "Desk Drawer Amount:";
            // 
            // matTypeLbl
            // 
            this.matTypeLbl.AutoSize = true;
            this.matTypeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matTypeLbl.Location = new System.Drawing.Point(8, 282);
            this.matTypeLbl.Name = "matTypeLbl";
            this.matTypeLbl.Size = new System.Drawing.Size(107, 20);
            this.matTypeLbl.TabIndex = 7;
            this.matTypeLbl.Text = "Material Type:";
            // 
            // shipTimeLbl
            // 
            this.shipTimeLbl.AutoSize = true;
            this.shipTimeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shipTimeLbl.Location = new System.Drawing.Point(8, 334);
            this.shipTimeLbl.Name = "shipTimeLbl";
            this.shipTimeLbl.Size = new System.Drawing.Size(154, 20);
            this.shipTimeLbl.TabIndex = 8;
            this.shipTimeLbl.Text = "Shipping Timeframe:";
            // 
            // megaDeskHdrLbl
            // 
            this.megaDeskHdrLbl.AutoSize = true;
            this.megaDeskHdrLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.megaDeskHdrLbl.Location = new System.Drawing.Point(7, 8);
            this.megaDeskHdrLbl.Name = "megaDeskHdrLbl";
            this.megaDeskHdrLbl.Size = new System.Drawing.Size(116, 26);
            this.megaDeskHdrLbl.TabIndex = 9;
            this.megaDeskHdrLbl.Text = "MegaDesk";
            // 
            // shipTimeReqLbl
            // 
            this.shipTimeReqLbl.AutoSize = true;
            this.shipTimeReqLbl.Location = new System.Drawing.Point(12, 354);
            this.shipTimeReqLbl.Name = "shipTimeReqLbl";
            this.shipTimeReqLbl.Size = new System.Drawing.Size(67, 13);
            this.shipTimeReqLbl.TabIndex = 13;
            this.shipTimeReqLbl.Text = "requirements";
            // 
            // dskDepReqLbl
            // 
            this.dskDepReqLbl.AutoSize = true;
            this.dskDepReqLbl.Location = new System.Drawing.Point(12, 204);
            this.dskDepReqLbl.Name = "dskDepReqLbl";
            this.dskDepReqLbl.Size = new System.Drawing.Size(67, 13);
            this.dskDepReqLbl.TabIndex = 14;
            this.dskDepReqLbl.Text = "requirements";
            // 
            // dskWidReqLbl
            // 
            this.dskWidReqLbl.AutoSize = true;
            this.dskWidReqLbl.Location = new System.Drawing.Point(12, 154);
            this.dskWidReqLbl.Name = "dskWidReqLbl";
            this.dskWidReqLbl.Size = new System.Drawing.Size(67, 13);
            this.dskWidReqLbl.TabIndex = 15;
            this.dskWidReqLbl.Text = "requirements";
            // 
            // DepthBox
            // 
            this.DepthBox.Location = new System.Drawing.Point(235, 184);
            this.DepthBox.Name = "DepthBox";
            this.DepthBox.Size = new System.Drawing.Size(198, 20);
            this.DepthBox.TabIndex = 17;
            // 
            // ShippingComboBox
            // 
            this.ShippingComboBox.FormattingEnabled = true;
            this.ShippingComboBox.Location = new System.Drawing.Point(235, 333);
            this.ShippingComboBox.Name = "ShippingComboBox";
            this.ShippingComboBox.Size = new System.Drawing.Size(198, 21);
            this.ShippingComboBox.TabIndex = 20;
            // 
            // MaterialComboBox
            // 
            this.MaterialComboBox.FormattingEnabled = true;
            this.MaterialComboBox.Location = new System.Drawing.Point(235, 281);
            this.MaterialComboBox.Name = "MaterialComboBox";
            this.MaterialComboBox.Size = new System.Drawing.Size(198, 21);
            this.MaterialComboBox.TabIndex = 21;
            // 
            // DrawerInput
            // 
            this.DrawerInput.FormattingEnabled = true;
            this.DrawerInput.Location = new System.Drawing.Point(235, 232);
            this.DrawerInput.Name = "DrawerInput";
            this.DrawerInput.Size = new System.Drawing.Size(198, 21);
            this.DrawerInput.TabIndex = 22;
            // 
            // WidthBox
            // 
            this.WidthBox.Location = new System.Drawing.Point(235, 134);
            this.WidthBox.Name = "WidthBox";
            this.WidthBox.Size = new System.Drawing.Size(198, 20);
            this.WidthBox.TabIndex = 23;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(235, 82);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(198, 20);
            this.NameBox.TabIndex = 24;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(278, 34);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(102, 20);
            this.DateLabel.TabIndex = 25;
            this.DateLabel.Text = "Today\'s Date";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 442);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.WidthBox);
            this.Controls.Add(this.DrawerInput);
            this.Controls.Add(this.MaterialComboBox);
            this.Controls.Add(this.ShippingComboBox);
            this.Controls.Add(this.DepthBox);
            this.Controls.Add(this.dskWidReqLbl);
            this.Controls.Add(this.dskDepReqLbl);
            this.Controls.Add(this.shipTimeReqLbl);
            this.Controls.Add(this.megaDeskHdrLbl);
            this.Controls.Add(this.shipTimeLbl);
            this.Controls.Add(this.matTypeLbl);
            this.Controls.Add(this.deskAmountLbl);
            this.Controls.Add(this.deskDepthLbl);
            this.Controls.Add(this.deskWidthLbl);
            this.Controls.Add(this.plzNameLbl);
            this.Controls.Add(this.dateNowLbl);
            this.Controls.Add(this.submitOrderBtn);
            this.Controls.Add(this.menuBackBtn);
            this.Name = "AddQuote";
            this.Text = "Add Quote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button menuBackBtn;
        private System.Windows.Forms.Button submitOrderBtn;
        private System.Windows.Forms.Label dateNowLbl;
        private System.Windows.Forms.Label plzNameLbl;
        private System.Windows.Forms.Label deskWidthLbl;
        private System.Windows.Forms.Label deskDepthLbl;
        private System.Windows.Forms.Label deskAmountLbl;
        private System.Windows.Forms.Label matTypeLbl;
        private System.Windows.Forms.Label shipTimeLbl;
        private System.Windows.Forms.Label megaDeskHdrLbl;
        private System.Windows.Forms.Label shipTimeReqLbl;
        private System.Windows.Forms.Label dskDepReqLbl;
        private System.Windows.Forms.Label dskWidReqLbl;
        private System.Windows.Forms.TextBox DepthBox;
        private System.Windows.Forms.ComboBox ShippingComboBox;
        private System.Windows.Forms.ComboBox MaterialComboBox;
        private System.Windows.Forms.ComboBox DrawerInput;
        private System.Windows.Forms.TextBox WidthBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label DateLabel;
    }
}