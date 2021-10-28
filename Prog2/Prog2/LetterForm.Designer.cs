namespace UPVApp
{
    partial class LetterForm
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
            this.FixCostTxtBox = new System.Windows.Forms.TextBox();
            this.OriginAddyCombo = new System.Windows.Forms.ComboBox();
            this.DestAddyCombo = new System.Windows.Forms.ComboBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.OriginAddyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.DestAddyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.FixCostErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.OriginAddyErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DestAddyErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FixCostErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Origin Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Destination Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fixed Cost:";
            // 
            // FixCostTxtBox
            // 
            this.FixCostTxtBox.Location = new System.Drawing.Point(127, 95);
            this.FixCostTxtBox.Name = "FixCostTxtBox";
            this.FixCostTxtBox.Size = new System.Drawing.Size(100, 20);
            this.FixCostTxtBox.TabIndex = 3;
            this.FixCostTxtBox.Validating += new System.ComponentModel.CancelEventHandler(this.FixCost_Validating);
            this.FixCostTxtBox.Validated += new System.EventHandler(this.FixCost_Validated);
            // 
            // OriginAddyCombo
            // 
            this.OriginAddyCombo.FormattingEnabled = true;
            this.OriginAddyCombo.Location = new System.Drawing.Point(127, 24);
            this.OriginAddyCombo.Name = "OriginAddyCombo";
            this.OriginAddyCombo.Size = new System.Drawing.Size(121, 21);
            this.OriginAddyCombo.TabIndex = 4;
            this.OriginAddyCombo.Validating += new System.ComponentModel.CancelEventHandler(this.OriginAddyCombo_Validating);
            this.OriginAddyCombo.Validated += new System.EventHandler(this.OriginAddyCombo_Validated);
            // 
            // DestAddyCombo
            // 
            this.DestAddyCombo.FormattingEnabled = true;
            this.DestAddyCombo.Location = new System.Drawing.Point(127, 61);
            this.DestAddyCombo.Name = "DestAddyCombo";
            this.DestAddyCombo.Size = new System.Drawing.Size(121, 21);
            this.DestAddyCombo.TabIndex = 5;
            this.DestAddyCombo.Validating += new System.ComponentModel.CancelEventHandler(this.DestAddyCombo_Validating);
            this.DestAddyCombo.Validated += new System.EventHandler(this.DestAddyCombo_Validated);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(13, 130);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 6;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(207, 130);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 7;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // OriginAddyErrorProvider
            // 
            this.OriginAddyErrorProvider.ContainerControl = this;
            // 
            // DestAddyErrorProvider
            // 
            this.DestAddyErrorProvider.ContainerControl = this;
            // 
            // FixCostErrorProvider
            // 
            this.FixCostErrorProvider.ContainerControl = this;
            // 
            // LetterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 165);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.DestAddyCombo);
            this.Controls.Add(this.OriginAddyCombo);
            this.Controls.Add(this.FixCostTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LetterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Letter";
            ((System.ComponentModel.ISupportInitialize)(this.OriginAddyErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DestAddyErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FixCostErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FixCostTxtBox;
        private System.Windows.Forms.ComboBox OriginAddyCombo;
        private System.Windows.Forms.ComboBox DestAddyCombo;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.ErrorProvider OriginAddyErrorProvider;
        private System.Windows.Forms.ErrorProvider DestAddyErrorProvider;
        private System.Windows.Forms.ErrorProvider FixCostErrorProvider;
    }
}