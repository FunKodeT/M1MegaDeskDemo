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
            this.components = new System.ComponentModel.Container();
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
            this.WidthErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.NameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.DepthErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.DrawerErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ShippingErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.MaterialErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WidthErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepthErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrawerErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShippingErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // menuBackBtn
            // 
            this.menuBackBtn.Location = new System.Drawing.Point(12, 378);
            this.menuBackBtn.Name = "menuBackBtn";
            this.menuBackBtn.Size = new System.Drawing.Size(198, 52);
            this.menuBackBtn.TabIndex = 0;
            this.menuBackBtn.Text = "Main Menu";
            this.menuBackBtn.UseVisualStyleBackColor = true;
            this.menuBackBtn.Click += new System.EventHandler(this.GoBack);
            // 
            // submitOrderBtn
            // 
            this.submitOrderBtn.Location = new System.Drawing.Point(235, 378);
            this.submitOrderBtn.Name = "submitOrderBtn";
            this.submitOrderBtn.Size = new System.Drawing.Size(198, 52);
            this.submitOrderBtn.TabIndex = 1;
            this.submitOrderBtn.Text = "Submit Order";
            this.submitOrderBtn.UseVisualStyleBackColor = true;
            this.submitOrderBtn.Click += new System.EventHandler(this.SubmitOrderBtn_Click);
            // 
            // dateNowLbl
            // 
            this.dateNowLbl.AutoSize = true;
            this.dateNowLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNowLbl.Location = new System.Drawing.Point(106, 86);
            this.dateNowLbl.Name = "dateNowLbl";
            this.dateNowLbl.Size = new System.Drawing.Size(109, 17);
            this.dateNowLbl.TabIndex = 2;
            this.dateNowLbl.Text = "Today\'s Date:";
            // 
            // plzNameLbl
            // 
            this.plzNameLbl.AutoSize = true;
            this.plzNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plzNameLbl.Location = new System.Drawing.Point(13, 49);
            this.plzNameLbl.Name = "plzNameLbl";
            this.plzNameLbl.Size = new System.Drawing.Size(168, 20);
            this.plzNameLbl.TabIndex = 3;
            this.plzNameLbl.Text = "Please Enter Name:";
            // 
            // deskWidthLbl
            // 
            this.deskWidthLbl.AutoSize = true;
            this.deskWidthLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deskWidthLbl.Location = new System.Drawing.Point(13, 157);
            this.deskWidthLbl.Name = "deskWidthLbl";
            this.deskWidthLbl.Size = new System.Drawing.Size(95, 20);
            this.deskWidthLbl.TabIndex = 4;
            this.deskWidthLbl.Text = "Desk Width:";
            // 
            // deskDepthLbl
            // 
            this.deskDepthLbl.AutoSize = true;
            this.deskDepthLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deskDepthLbl.Location = new System.Drawing.Point(13, 207);
            this.deskDepthLbl.Name = "deskDepthLbl";
            this.deskDepthLbl.Size = new System.Drawing.Size(98, 20);
            this.deskDepthLbl.TabIndex = 5;
            this.deskDepthLbl.Text = "Desk Depth:";
            // 
            // deskAmountLbl
            // 
            this.deskAmountLbl.AutoSize = true;
            this.deskAmountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deskAmountLbl.Location = new System.Drawing.Point(13, 257);
            this.deskAmountLbl.Name = "deskAmountLbl";
            this.deskAmountLbl.Size = new System.Drawing.Size(165, 20);
            this.deskAmountLbl.TabIndex = 6;
            this.deskAmountLbl.Text = "Desk Drawer Amount:";
            // 
            // matTypeLbl
            // 
            this.matTypeLbl.AutoSize = true;
            this.matTypeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matTypeLbl.Location = new System.Drawing.Point(13, 294);
            this.matTypeLbl.Name = "matTypeLbl";
            this.matTypeLbl.Size = new System.Drawing.Size(107, 20);
            this.matTypeLbl.TabIndex = 7;
            this.matTypeLbl.Text = "Material Type:";
            // 
            // shipTimeLbl
            // 
            this.shipTimeLbl.AutoSize = true;
            this.shipTimeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shipTimeLbl.Location = new System.Drawing.Point(13, 331);
            this.shipTimeLbl.Name = "shipTimeLbl";
            this.shipTimeLbl.Size = new System.Drawing.Size(154, 20);
            this.shipTimeLbl.TabIndex = 8;
            this.shipTimeLbl.Text = "Shipping Timeframe:";
            // 
            // megaDeskHdrLbl
            // 
            this.megaDeskHdrLbl.AutoSize = true;
            this.megaDeskHdrLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.megaDeskHdrLbl.Location = new System.Drawing.Point(12, 9);
            this.megaDeskHdrLbl.Name = "megaDeskHdrLbl";
            this.megaDeskHdrLbl.Size = new System.Drawing.Size(422, 26);
            this.megaDeskHdrLbl.TabIndex = 9;
            this.megaDeskHdrLbl.Text = "MegaDesk                                                   ";
            // 
            // shipTimeReqLbl
            // 
            this.shipTimeReqLbl.AutoSize = true;
            this.shipTimeReqLbl.Location = new System.Drawing.Point(14, 351);
            this.shipTimeReqLbl.Name = "shipTimeReqLbl";
            this.shipTimeReqLbl.Size = new System.Drawing.Size(67, 13);
            this.shipTimeReqLbl.TabIndex = 13;
            this.shipTimeReqLbl.Text = "requirements";
            // 
            // dskDepReqLbl
            // 
            this.dskDepReqLbl.AutoSize = true;
            this.dskDepReqLbl.Location = new System.Drawing.Point(14, 227);
            this.dskDepReqLbl.Name = "dskDepReqLbl";
            this.dskDepReqLbl.Size = new System.Drawing.Size(67, 13);
            this.dskDepReqLbl.TabIndex = 14;
            this.dskDepReqLbl.Text = "requirements";
            // 
            // dskWidReqLbl
            // 
            this.dskWidReqLbl.AutoSize = true;
            this.dskWidReqLbl.Location = new System.Drawing.Point(14, 177);
            this.dskWidReqLbl.Name = "dskWidReqLbl";
            this.dskWidReqLbl.Size = new System.Drawing.Size(67, 13);
            this.dskWidReqLbl.TabIndex = 15;
            this.dskWidReqLbl.Text = "requirements";
            // 
            // DepthBox
            // 
            this.DepthBox.Location = new System.Drawing.Point(225, 207);
            this.DepthBox.Name = "DepthBox";
            this.DepthBox.Size = new System.Drawing.Size(198, 20);
            this.DepthBox.TabIndex = 17;
            this.DepthBox.Validating += new System.ComponentModel.CancelEventHandler(this.DepthBox_Validating);
            // 
            // ShippingComboBox
            // 
            this.ShippingComboBox.FormattingEnabled = true;
            this.ShippingComboBox.Items.AddRange(new object[] {
            "3",
            "5",
            "7"});
            this.ShippingComboBox.Location = new System.Drawing.Point(225, 333);
            this.ShippingComboBox.Name = "ShippingComboBox";
            this.ShippingComboBox.Size = new System.Drawing.Size(198, 21);
            this.ShippingComboBox.TabIndex = 20;
            this.ShippingComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.ShippingBox_Validating);
            // 
            // MaterialComboBox
            // 
            this.MaterialComboBox.FormattingEnabled = true;
            this.MaterialComboBox.Items.AddRange(new object[] {
            "Pine",
            "Laminate",
            "Veneer",
            "Oak",
            "Rosewood"});
            this.MaterialComboBox.Location = new System.Drawing.Point(225, 293);
            this.MaterialComboBox.Name = "MaterialComboBox";
            this.MaterialComboBox.Size = new System.Drawing.Size(198, 21);
            this.MaterialComboBox.TabIndex = 21;
            this.MaterialComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.MaterialBox_Validating);
            // 
            // DrawerInput
            // 
            this.DrawerInput.FormattingEnabled = true;
            this.DrawerInput.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.DrawerInput.Location = new System.Drawing.Point(225, 256);
            this.DrawerInput.Name = "DrawerInput";
            this.DrawerInput.Size = new System.Drawing.Size(198, 21);
            this.DrawerInput.TabIndex = 22;
            this.DrawerInput.Validating += new System.ComponentModel.CancelEventHandler(this.DrawerBox_Validating);
            // 
            // WidthBox
            // 
            this.WidthBox.Location = new System.Drawing.Point(225, 157);
            this.WidthBox.Name = "WidthBox";
            this.WidthBox.Size = new System.Drawing.Size(198, 20);
            this.WidthBox.TabIndex = 23;
            this.WidthBox.Validating += new System.ComponentModel.CancelEventHandler(this.WidthBox_Validating);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(225, 49);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(198, 20);
            this.NameBox.TabIndex = 24;
            this.NameBox.Validating += new System.ComponentModel.CancelEventHandler(this.NameBox_Validating);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(255, 86);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(92, 17);
            this.DateLabel.TabIndex = 25;
            this.DateLabel.Text = "Today\'s Date";
            // 
            // WidthErrorProvider
            // 
            this.WidthErrorProvider.ContainerControl = this;
            // 
            // NameErrorProvider
            // 
            this.NameErrorProvider.ContainerControl = this;
            // 
            // DepthErrorProvider
            // 
            this.DepthErrorProvider.ContainerControl = this;
            // 
            // DrawerErrorProvider
            // 
            this.DrawerErrorProvider.ContainerControl = this;
            // 
            // ShippingErrorProvider
            // 
            this.ShippingErrorProvider.ContainerControl = this;
            // 
            // MaterialErrorProvider
            // 
            this.MaterialErrorProvider.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(417, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Specifications                                                           ";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 442);
            this.Controls.Add(this.label4);
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
            this.Load += new System.EventHandler(this.AddQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WidthErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepthErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrawerErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShippingErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialErrorProvider)).EndInit();
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
        private System.Windows.Forms.ErrorProvider WidthErrorProvider;
        private System.Windows.Forms.ErrorProvider NameErrorProvider;
        private System.Windows.Forms.ErrorProvider DepthErrorProvider;
        private System.Windows.Forms.ErrorProvider DrawerErrorProvider;
        private System.Windows.Forms.ErrorProvider ShippingErrorProvider;
        private System.Windows.Forms.ErrorProvider MaterialErrorProvider;
        private System.Windows.Forms.Label label4;
    }
}