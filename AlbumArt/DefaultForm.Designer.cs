namespace AlbumArt
{
    partial class DefaultForm
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
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonSelectImage = new System.Windows.Forms.Button();
            this.buttonApplyImage = new System.Windows.Forms.Button();
            this.buttonResetImage = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(568, 12);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 0;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(12, 14);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(550, 20);
            this.textBoxPath.TabIndex = 1;
            this.textBoxPath.Text = "Source path...";
            this.textBoxPath.Click += new System.EventHandler(this.textBoxPath_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 60);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(326, 368);
            this.listBox1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(354, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 281);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // buttonSelectImage
            // 
            this.buttonSelectImage.Location = new System.Drawing.Point(354, 347);
            this.buttonSelectImage.Name = "buttonSelectImage";
            this.buttonSelectImage.Size = new System.Drawing.Size(289, 38);
            this.buttonSelectImage.TabIndex = 4;
            this.buttonSelectImage.Text = "Select Image";
            this.buttonSelectImage.UseVisualStyleBackColor = true;
            this.buttonSelectImage.Click += new System.EventHandler(this.buttonSelectImage_Click);
            // 
            // buttonApplyImage
            // 
            this.buttonApplyImage.Location = new System.Drawing.Point(354, 391);
            this.buttonApplyImage.Name = "buttonApplyImage";
            this.buttonApplyImage.Size = new System.Drawing.Size(87, 37);
            this.buttonApplyImage.TabIndex = 5;
            this.buttonApplyImage.Text = "Apply Image";
            this.buttonApplyImage.UseVisualStyleBackColor = true;
            this.buttonApplyImage.Click += new System.EventHandler(this.buttonApplyImage_Click);
            // 
            // buttonResetImage
            // 
            this.buttonResetImage.Location = new System.Drawing.Point(447, 391);
            this.buttonResetImage.Name = "buttonResetImage";
            this.buttonResetImage.Size = new System.Drawing.Size(103, 37);
            this.buttonResetImage.TabIndex = 6;
            this.buttonResetImage.Text = "Reset Image";
            this.buttonResetImage.UseVisualStyleBackColor = true;
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(556, 391);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(87, 37);
            this.buttonClose.TabIndex = 7;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // DefaultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(655, 450);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonResetImage);
            this.Controls.Add(this.buttonApplyImage);
            this.Controls.Add(this.buttonSelectImage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.buttonBrowse);
            this.Name = "DefaultForm";
            this.Text = "Assign Cover Art";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonSelectImage;
        private System.Windows.Forms.Button buttonApplyImage;
        private System.Windows.Forms.Button buttonResetImage;
        private System.Windows.Forms.Button buttonClose;
    }
}

