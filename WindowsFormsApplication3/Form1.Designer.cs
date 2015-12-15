namespace WindowsFormsApplication3
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
            this.shipmentPriceGroupBox = new System.Windows.Forms.GroupBox();
            this.parcelWeightGroupBox = new System.Windows.Forms.GroupBox();
            this.lb10PlusRadioButton = new System.Windows.Forms.RadioButton();
            this.lb3RadioButton = new System.Windows.Forms.RadioButton();
            this.lb5RadioButton = new System.Windows.Forms.RadioButton();
            this.lb10RadioButton = new System.Windows.Forms.RadioButton();
            this.lb1RadioButton = new System.Windows.Forms.RadioButton();
            this.priceLabel = new System.Windows.Forms.Label();
            this.zoneLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.zoneComboBox = new System.Windows.Forms.ComboBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.shipmentPriceGroupBox.SuspendLayout();
            this.parcelWeightGroupBox.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // shipmentPriceGroupBox
            // 
            this.shipmentPriceGroupBox.Controls.Add(this.parcelWeightGroupBox);
            this.shipmentPriceGroupBox.Controls.Add(this.priceLabel);
            this.shipmentPriceGroupBox.Controls.Add(this.zoneLabel);
            this.shipmentPriceGroupBox.Controls.Add(this.priceTextBox);
            this.shipmentPriceGroupBox.Controls.Add(this.zoneComboBox);
            this.shipmentPriceGroupBox.Location = new System.Drawing.Point(12, 64);
            this.shipmentPriceGroupBox.Name = "shipmentPriceGroupBox";
            this.shipmentPriceGroupBox.Size = new System.Drawing.Size(629, 242);
            this.shipmentPriceGroupBox.TabIndex = 1;
            this.shipmentPriceGroupBox.TabStop = false;
            this.shipmentPriceGroupBox.Text = "Shipment Price";
            // 
            // parcelWeightGroupBox
            // 
            this.parcelWeightGroupBox.Controls.Add(this.lb10PlusRadioButton);
            this.parcelWeightGroupBox.Controls.Add(this.lb3RadioButton);
            this.parcelWeightGroupBox.Controls.Add(this.lb5RadioButton);
            this.parcelWeightGroupBox.Controls.Add(this.lb10RadioButton);
            this.parcelWeightGroupBox.Controls.Add(this.lb1RadioButton);
            this.parcelWeightGroupBox.Location = new System.Drawing.Point(16, 31);
            this.parcelWeightGroupBox.Name = "parcelWeightGroupBox";
            this.parcelWeightGroupBox.Size = new System.Drawing.Size(251, 193);
            this.parcelWeightGroupBox.TabIndex = 4;
            this.parcelWeightGroupBox.TabStop = false;
            this.parcelWeightGroupBox.Text = "Parcel Weight";
            // 
            // lb10PlusRadioButton
            // 
            this.lb10PlusRadioButton.AutoSize = true;
            this.lb10PlusRadioButton.Location = new System.Drawing.Point(64, 166);
            this.lb10PlusRadioButton.Name = "lb10PlusRadioButton";
            this.lb10PlusRadioButton.Size = new System.Drawing.Size(72, 21);
            this.lb10PlusRadioButton.TabIndex = 4;
            this.lb10PlusRadioButton.TabStop = true;
            this.lb10PlusRadioButton.Text = "> 10 lb";
            this.lb10PlusRadioButton.UseVisualStyleBackColor = true;
            // 
            // lb3RadioButton
            // 
            this.lb3RadioButton.AutoSize = true;
            this.lb3RadioButton.Location = new System.Drawing.Point(64, 56);
            this.lb3RadioButton.Name = "lb3RadioButton";
            this.lb3RadioButton.Size = new System.Drawing.Size(56, 21);
            this.lb3RadioButton.TabIndex = 1;
            this.lb3RadioButton.TabStop = true;
            this.lb3RadioButton.Text = " 3 lb";
            this.lb3RadioButton.UseVisualStyleBackColor = true;
            // 
            // lb5RadioButton
            // 
            this.lb5RadioButton.AutoSize = true;
            this.lb5RadioButton.Location = new System.Drawing.Point(64, 94);
            this.lb5RadioButton.Name = "lb5RadioButton";
            this.lb5RadioButton.Size = new System.Drawing.Size(56, 21);
            this.lb5RadioButton.TabIndex = 2;
            this.lb5RadioButton.TabStop = true;
            this.lb5RadioButton.Text = " 5 lb";
            this.lb5RadioButton.UseVisualStyleBackColor = true;
            // 
            // lb10RadioButton
            // 
            this.lb10RadioButton.AutoSize = true;
            this.lb10RadioButton.Location = new System.Drawing.Point(64, 130);
            this.lb10RadioButton.Name = "lb10RadioButton";
            this.lb10RadioButton.Size = new System.Drawing.Size(64, 21);
            this.lb10RadioButton.TabIndex = 3;
            this.lb10RadioButton.TabStop = true;
            this.lb10RadioButton.Text = " 10 lb";
            this.lb10RadioButton.UseVisualStyleBackColor = true;
            // 
            // lb1RadioButton
            // 
            this.lb1RadioButton.AutoSize = true;
            this.lb1RadioButton.Location = new System.Drawing.Point(64, 21);
            this.lb1RadioButton.Name = "lb1RadioButton";
            this.lb1RadioButton.Size = new System.Drawing.Size(56, 21);
            this.lb1RadioButton.TabIndex = 0;
            this.lb1RadioButton.TabStop = true;
            this.lb1RadioButton.Text = " 1 lb";
            this.lb1RadioButton.UseVisualStyleBackColor = true;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(334, 152);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(48, 17);
            this.priceLabel.TabIndex = 3;
            this.priceLabel.Text = "Price :";
            // 
            // zoneLabel
            // 
            this.zoneLabel.AutoSize = true;
            this.zoneLabel.Location = new System.Drawing.Point(334, 87);
            this.zoneLabel.Name = "zoneLabel";
            this.zoneLabel.Size = new System.Drawing.Size(49, 17);
            this.zoneLabel.TabIndex = 1;
            this.zoneLabel.Text = "Zone :";
            // 
            // priceTextBox
            // 
            this.priceTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.priceTextBox.Location = new System.Drawing.Point(389, 147);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.ReadOnly = true;
            this.priceTextBox.Size = new System.Drawing.Size(218, 22);
            this.priceTextBox.TabIndex = 1;
            // 
            // zoneComboBox
            // 
            this.zoneComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.zoneComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.zoneComboBox.FormattingEnabled = true;
            this.zoneComboBox.Items.AddRange(new object[] {
            "Zone A",
            "Zone B",
            "Zone C",
            "Zone D"});
            this.zoneComboBox.Location = new System.Drawing.Point(389, 84);
            this.zoneComboBox.Name = "zoneComboBox";
            this.zoneComboBox.Size = new System.Drawing.Size(218, 24);
            this.zoneComboBox.TabIndex = 0;
            this.zoneComboBox.SelectedIndexChanged += new System.EventHandler(this.zoneComboBox_SelectedIndexChanged);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(544, 313);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(401, 313);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "C&lear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(652, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.clearToolStripMenuItem.Text = "C&lear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.fontToolStripMenuItem.Text = "&Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.colorToolStripMenuItem.Text = "&Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 348);
            this.Controls.Add(this.shipmentPriceGroupBox);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AC Flies Parcel Shipment";
            this.shipmentPriceGroupBox.ResumeLayout(false);
            this.shipmentPriceGroupBox.PerformLayout();
            this.parcelWeightGroupBox.ResumeLayout(false);
            this.parcelWeightGroupBox.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox shipmentPriceGroupBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.GroupBox parcelWeightGroupBox;
        private System.Windows.Forms.RadioButton lb10PlusRadioButton;
        private System.Windows.Forms.RadioButton lb3RadioButton;
        private System.Windows.Forms.RadioButton lb5RadioButton;
        private System.Windows.Forms.RadioButton lb10RadioButton;
        private System.Windows.Forms.RadioButton lb1RadioButton;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label zoneLabel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.ComboBox zoneComboBox;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

