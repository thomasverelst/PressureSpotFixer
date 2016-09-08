namespace PressureSpotFixer
{
    partial class SettingsForm
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
            this.confirmButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.selectFileButton = new System.Windows.Forms.Button();
            this.filePath = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.setPositionButton = new System.Windows.Forms.Button();
            this.yNumericBox = new System.Windows.Forms.NumericUpDown();
            this.xNumericBox = new System.Windows.Forms.NumericUpDown();
            this.resetPrevPosButton = new System.Windows.Forms.Button();
            this.savePosButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yNumericBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xNumericBox)).BeginInit();
            this.SuspendLayout();
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(238, 238);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 0;
            this.confirmButton.Text = "OK";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // selectFileButton
            // 
            this.selectFileButton.Location = new System.Drawing.Point(9, 19);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(128, 23);
            this.selectFileButton.TabIndex = 3;
            this.selectFileButton.Text = "Select image file";
            this.selectFileButton.UseVisualStyleBackColor = true;
            this.selectFileButton.Click += new System.EventHandler(this.selectImgButton_Click);
            // 
            // filePath
            // 
            this.filePath.AutoSize = true;
            this.filePath.Location = new System.Drawing.Point(143, 24);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(0, 13);
            this.filePath.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "You can now move your fixer image by dragging the red box.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.selectFileButton);
            this.groupBox1.Controls.Add(this.filePath);
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 51);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fixer image";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.setPositionButton);
            this.groupBox2.Controls.Add(this.yNumericBox);
            this.groupBox2.Controls.Add(this.xNumericBox);
            this.groupBox2.Controls.Add(this.resetPrevPosButton);
            this.groupBox2.Controls.Add(this.savePosButton);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(301, 163);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fixer position";
            // 
            // setPositionButton
            // 
            this.setPositionButton.Location = new System.Drawing.Point(185, 51);
            this.setPositionButton.Name = "setPositionButton";
            this.setPositionButton.Size = new System.Drawing.Size(96, 23);
            this.setPositionButton.TabIndex = 15;
            this.setPositionButton.Text = "Set as position";
            this.setPositionButton.UseVisualStyleBackColor = true;
            this.setPositionButton.Click += new System.EventHandler(this.setPositionButton_Click);
            // 
            // yNumericBox
            // 
            this.yNumericBox.Location = new System.Drawing.Point(126, 53);
            this.yNumericBox.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.yNumericBox.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.yNumericBox.Name = "yNumericBox";
            this.yNumericBox.Size = new System.Drawing.Size(53, 20);
            this.yNumericBox.TabIndex = 14;
            // 
            // xNumericBox
            // 
            this.xNumericBox.Location = new System.Drawing.Point(30, 53);
            this.xNumericBox.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.xNumericBox.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.xNumericBox.Name = "xNumericBox";
            this.xNumericBox.Size = new System.Drawing.Size(53, 20);
            this.xNumericBox.TabIndex = 13;
            // 
            // resetPrevPosButton
            // 
            this.resetPrevPosButton.Location = new System.Drawing.Point(10, 131);
            this.resetPrevPosButton.Name = "resetPrevPosButton";
            this.resetPrevPosButton.Size = new System.Drawing.Size(115, 23);
            this.resetPrevPosButton.TabIndex = 12;
            this.resetPrevPosButton.Text = "Reset to Previous";
            this.resetPrevPosButton.UseVisualStyleBackColor = true;
            this.resetPrevPosButton.Click += new System.EventHandler(this.resetPrevPosButton_Click);
            // 
            // savePosButton
            // 
            this.savePosButton.Location = new System.Drawing.Point(10, 102);
            this.savePosButton.Name = "savePosButton";
            this.savePosButton.Size = new System.Drawing.Size(115, 23);
            this.savePosButton.TabIndex = 11;
            this.savePosButton.Text = "Save current position";
            this.savePosButton.UseVisualStyleBackColor = true;
            this.savePosButton.Click += new System.EventHandler(this.savePosButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Y:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "X:";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 269);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.confirmButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SettingsForm";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingsForm_FormClosed);
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yNumericBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xNumericBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button selectFileButton;
        private System.Windows.Forms.Label filePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button savePosButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button resetPrevPosButton;
        private System.Windows.Forms.NumericUpDown yNumericBox;
        private System.Windows.Forms.NumericUpDown xNumericBox;
        private System.Windows.Forms.Button setPositionButton;
    }
}