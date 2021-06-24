
namespace AwsTranslateTextInImage
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbImg = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rtbTranslatedText = new System.Windows.Forms.RichTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gbTranslate = new System.Windows.Forms.GroupBox();
            this.cbTo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbFrom = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbImage = new System.Windows.Forms.GroupBox();
            this.txtImgPath = new System.Windows.Forms.TextBox();
            this.btnOpenImg = new System.Windows.Forms.Button();
            this.btnReloadBucket = new System.Windows.Forms.Button();
            this.cbListBucket = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.openFileImg = new System.Windows.Forms.OpenFileDialog();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtStatus = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.gbTranslate.SuspendLayout();
            this.gbImage.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbImg);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // pbImg
            // 
            this.pbImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbImg.Location = new System.Drawing.Point(462, 0);
            this.pbImg.Name = "pbImg";
            this.pbImg.Size = new System.Drawing.Size(338, 450);
            this.pbImg.TabIndex = 1;
            this.pbImg.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rtbTranslatedText);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(462, 450);
            this.panel2.TabIndex = 0;
            // 
            // rtbTranslatedText
            // 
            this.rtbTranslatedText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbTranslatedText.Location = new System.Drawing.Point(0, 243);
            this.rtbTranslatedText.Name = "rtbTranslatedText";
            this.rtbTranslatedText.ReadOnly = true;
            this.rtbTranslatedText.Size = new System.Drawing.Size(462, 207);
            this.rtbTranslatedText.TabIndex = 1;
            this.rtbTranslatedText.Text = "";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.gbTranslate);
            this.panel4.Controls.Add(this.gbImage);
            this.panel4.Controls.Add(this.btnTranslate);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(462, 187);
            this.panel4.TabIndex = 0;
            // 
            // gbTranslate
            // 
            this.gbTranslate.Controls.Add(this.cbTo);
            this.gbTranslate.Controls.Add(this.label4);
            this.gbTranslate.Controls.Add(this.cbFrom);
            this.gbTranslate.Controls.Add(this.label3);
            this.gbTranslate.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbTranslate.Location = new System.Drawing.Point(0, 85);
            this.gbTranslate.Name = "gbTranslate";
            this.gbTranslate.Size = new System.Drawing.Size(462, 70);
            this.gbTranslate.TabIndex = 6;
            this.gbTranslate.TabStop = false;
            this.gbTranslate.Text = "Translate Config";
            // 
            // cbTo
            // 
            this.cbTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTo.FormattingEnabled = true;
            this.cbTo.Location = new System.Drawing.Point(282, 27);
            this.cbTo.Name = "cbTo";
            this.cbTo.Size = new System.Drawing.Size(158, 23);
            this.cbTo.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "to";
            // 
            // cbFrom
            // 
            this.cbFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFrom.FormattingEnabled = true;
            this.cbFrom.Location = new System.Drawing.Point(94, 27);
            this.cbFrom.Name = "cbFrom";
            this.cbFrom.Size = new System.Drawing.Size(158, 23);
            this.cbFrom.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Translate from";
            // 
            // gbImage
            // 
            this.gbImage.Controls.Add(this.txtImgPath);
            this.gbImage.Controls.Add(this.btnOpenImg);
            this.gbImage.Controls.Add(this.btnReloadBucket);
            this.gbImage.Controls.Add(this.cbListBucket);
            this.gbImage.Controls.Add(this.label1);
            this.gbImage.Controls.Add(this.label2);
            this.gbImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbImage.Location = new System.Drawing.Point(0, 0);
            this.gbImage.Name = "gbImage";
            this.gbImage.Size = new System.Drawing.Size(462, 85);
            this.gbImage.TabIndex = 2;
            this.gbImage.TabStop = false;
            this.gbImage.Text = "Image Config";
            // 
            // txtImgPath
            // 
            this.txtImgPath.Location = new System.Drawing.Point(73, 51);
            this.txtImgPath.Name = "txtImgPath";
            this.txtImgPath.ReadOnly = true;
            this.txtImgPath.Size = new System.Drawing.Size(290, 23);
            this.txtImgPath.TabIndex = 0;
            // 
            // btnOpenImg
            // 
            this.btnOpenImg.Location = new System.Drawing.Point(369, 50);
            this.btnOpenImg.Name = "btnOpenImg";
            this.btnOpenImg.Size = new System.Drawing.Size(84, 23);
            this.btnOpenImg.TabIndex = 1;
            this.btnOpenImg.Text = "Open Img";
            this.btnOpenImg.UseVisualStyleBackColor = true;
            this.btnOpenImg.Click += new System.EventHandler(this.btnOpenImg_Click);
            // 
            // btnReloadBucket
            // 
            this.btnReloadBucket.Location = new System.Drawing.Point(369, 21);
            this.btnReloadBucket.Name = "btnReloadBucket";
            this.btnReloadBucket.Size = new System.Drawing.Size(84, 23);
            this.btnReloadBucket.TabIndex = 6;
            this.btnReloadBucket.Text = "Refresh";
            this.btnReloadBucket.UseVisualStyleBackColor = true;
            this.btnReloadBucket.Click += new System.EventHandler(this.btnReloadBucket_Click);
            // 
            // cbListBucket
            // 
            this.cbListBucket.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbListBucket.FormattingEnabled = true;
            this.cbListBucket.Location = new System.Drawing.Point(73, 21);
            this.cbListBucket.Name = "cbListBucket";
            this.cbListBucket.Size = new System.Drawing.Size(290, 23);
            this.cbListBucket.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bucket";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Image Path";
            // 
            // btnTranslate
            // 
            this.btnTranslate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnTranslate.Enabled = false;
            this.btnTranslate.Location = new System.Drawing.Point(0, 154);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(462, 33);
            this.btnTranslate.TabIndex = 5;
            this.btnTranslate.Text = "Translate";
            this.btnTranslate.UseVisualStyleBackColor = true;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // openFileImg
            // 
            this.openFileImg.FileName = "openFileDialog1";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.progressBar1);
            this.panel3.Controls.Add(this.txtStatus);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 187);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(462, 56);
            this.panel3.TabIndex = 1;
            // 
            // txtStatus
            // 
            this.txtStatus.AutoSize = true;
            this.txtStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtStatus.Location = new System.Drawing.Point(153, 3);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(0, 21);
            this.txtStatus.TabIndex = 0;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 27);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(441, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.gbTranslate.ResumeLayout(false);
            this.gbTranslate.PerformLayout();
            this.gbImage.ResumeLayout(false);
            this.gbImage.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pbImg;
        private System.Windows.Forms.GroupBox gbTranslate;
        private System.Windows.Forms.ComboBox cbTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbImage;
        private System.Windows.Forms.TextBox txtImgPath;
        private System.Windows.Forms.Button btnOpenImg;
        private System.Windows.Forms.Button btnReloadBucket;
        private System.Windows.Forms.ComboBox cbListBucket;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.OpenFileDialog openFileImg;
        private System.Windows.Forms.RichTextBox rtbTranslatedText;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label txtStatus;
    }
}

