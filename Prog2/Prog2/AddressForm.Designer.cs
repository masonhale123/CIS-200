namespace UPVApp
{
    partial class AddressForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AddressNameTxtBox = new System.Windows.Forms.TextBox();
            this.AddressLine1TxtBox = new System.Windows.Forms.TextBox();
            this.AddressLine2TxtBox = new System.Windows.Forms.TextBox();
            this.AddressCityTxtBox = new System.Windows.Forms.TextBox();
            this.AddressZipTxtBox = new System.Windows.Forms.TextBox();
            this.StateCombo = new System.Windows.Forms.ComboBox();
            this.AddressOK = new System.Windows.Forms.Button();
            this.AddressCancel = new System.Windows.Forms.Button();
            this.nameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.AddressErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.CityErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.StateErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ZipErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddressErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CityErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StateErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZipErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "City:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "State:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Zip:";
            // 
            // AddressNameTxtBox
            // 
            this.AddressNameTxtBox.Location = new System.Drawing.Point(94, 24);
            this.AddressNameTxtBox.Name = "AddressNameTxtBox";
            this.AddressNameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.AddressNameTxtBox.TabIndex = 5;
            this.AddressNameTxtBox.Validating += new System.ComponentModel.CancelEventHandler(this.AddressName_Validating);
            // 
            // AddressLine1TxtBox
            // 
            this.AddressLine1TxtBox.Location = new System.Drawing.Point(94, 51);
            this.AddressLine1TxtBox.Name = "AddressLine1TxtBox";
            this.AddressLine1TxtBox.Size = new System.Drawing.Size(100, 20);
            this.AddressLine1TxtBox.TabIndex = 6;
            this.AddressLine1TxtBox.Validating += new System.ComponentModel.CancelEventHandler(this.AddressLine1_Validating);
            this.AddressLine1TxtBox.Validated += new System.EventHandler(this.AddressLine1_Validated);
            // 
            // AddressLine2TxtBox
            // 
            this.AddressLine2TxtBox.Location = new System.Drawing.Point(94, 77);
            this.AddressLine2TxtBox.Name = "AddressLine2TxtBox";
            this.AddressLine2TxtBox.Size = new System.Drawing.Size(100, 20);
            this.AddressLine2TxtBox.TabIndex = 7;
            // 
            // AddressCityTxtBox
            // 
            this.AddressCityTxtBox.Location = new System.Drawing.Point(94, 116);
            this.AddressCityTxtBox.Name = "AddressCityTxtBox";
            this.AddressCityTxtBox.Size = new System.Drawing.Size(100, 20);
            this.AddressCityTxtBox.TabIndex = 8;
            this.AddressCityTxtBox.Validating += new System.ComponentModel.CancelEventHandler(this.AddressCity_Validating);
            this.AddressCityTxtBox.Validated += new System.EventHandler(this.AddressCity_Validated);
            // 
            // AddressZipTxtBox
            // 
            this.AddressZipTxtBox.Location = new System.Drawing.Point(94, 170);
            this.AddressZipTxtBox.Name = "AddressZipTxtBox";
            this.AddressZipTxtBox.Size = new System.Drawing.Size(100, 20);
            this.AddressZipTxtBox.TabIndex = 10;
            this.AddressZipTxtBox.Validating += new System.ComponentModel.CancelEventHandler(this.AddressZip_Validating);
            this.AddressZipTxtBox.Validated += new System.EventHandler(this.AddressZip_Validated);
            // 
            // StateCombo
            // 
            this.StateCombo.FormattingEnabled = true;
            this.StateCombo.Location = new System.Drawing.Point(94, 143);
            this.StateCombo.Name = "StateCombo";
            this.StateCombo.Size = new System.Drawing.Size(49, 21);
            this.StateCombo.TabIndex = 11;
            this.StateCombo.Validating += new System.ComponentModel.CancelEventHandler(this.StateCombo_Validating);
            this.StateCombo.Validated += new System.EventHandler(this.StateCombo_Validated);
            // 
            // AddressOK
            // 
            this.AddressOK.Location = new System.Drawing.Point(125, 205);
            this.AddressOK.Name = "AddressOK";
            this.AddressOK.Size = new System.Drawing.Size(75, 23);
            this.AddressOK.TabIndex = 12;
            this.AddressOK.Text = "OK";
            this.AddressOK.UseVisualStyleBackColor = true;
            this.AddressOK.Click += new System.EventHandler(this.AddressOK_Click);
            // 
            // AddressCancel
            // 
            this.AddressCancel.Location = new System.Drawing.Point(13, 205);
            this.AddressCancel.Name = "AddressCancel";
            this.AddressCancel.Size = new System.Drawing.Size(75, 23);
            this.AddressCancel.TabIndex = 13;
            this.AddressCancel.Text = "Cancel";
            this.AddressCancel.UseVisualStyleBackColor = true;
            this.AddressCancel.Click += new System.EventHandler(this.AddressCancel_Click);
            // 
            // nameErrorProvider
            // 
            this.nameErrorProvider.ContainerControl = this;
            // 
            // AddressErrorProvider
            // 
            this.AddressErrorProvider.ContainerControl = this;
            // 
            // CityErrorProvider
            // 
            this.CityErrorProvider.ContainerControl = this;
            // 
            // StateErrorProvider
            // 
            this.StateErrorProvider.ContainerControl = this;
            // 
            // ZipErrorProvider
            // 
            this.ZipErrorProvider.ContainerControl = this;
            // 
            // AddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 240);
            this.Controls.Add(this.AddressCancel);
            this.Controls.Add(this.AddressOK);
            this.Controls.Add(this.StateCombo);
            this.Controls.Add(this.AddressZipTxtBox);
            this.Controls.Add(this.AddressCityTxtBox);
            this.Controls.Add(this.AddressLine2TxtBox);
            this.Controls.Add(this.AddressLine1TxtBox);
            this.Controls.Add(this.AddressNameTxtBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddressForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddressForm";
            ((System.ComponentModel.ISupportInitialize)(this.nameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddressErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CityErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StateErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZipErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AddressNameTxtBox;
        private System.Windows.Forms.TextBox AddressLine1TxtBox;
        private System.Windows.Forms.TextBox AddressLine2TxtBox;
        private System.Windows.Forms.TextBox AddressCityTxtBox;
        private System.Windows.Forms.TextBox AddressZipTxtBox;
        private System.Windows.Forms.ComboBox StateCombo;
        private System.Windows.Forms.Button AddressOK;
        private System.Windows.Forms.Button AddressCancel;
        private System.Windows.Forms.ErrorProvider nameErrorProvider;
        private System.Windows.Forms.ErrorProvider AddressErrorProvider;
        private System.Windows.Forms.ErrorProvider CityErrorProvider;
        private System.Windows.Forms.ErrorProvider StateErrorProvider;
        private System.Windows.Forms.ErrorProvider ZipErrorProvider;
    }
}