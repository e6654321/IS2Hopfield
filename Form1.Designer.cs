
namespace IS2HopfieldNetwork
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
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.imageMagnifier1 = new ImageMagnifier.ImageMagnifier();
            this.imageMagnifier2 = new ImageMagnifier.ImageMagnifier();
            this.button2 = new System.Windows.Forms.Button();
            this.imageMagnifier3 = new ImageMagnifier.ImageMagnifier();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // imageMagnifier1
            // 
            this.imageMagnifier1.ImageToMagnify = null;
            this.imageMagnifier1.Location = new System.Drawing.Point(12, 12);
            this.imageMagnifier1.MagnificationCoefficient = 1;
            this.imageMagnifier1.Name = "imageMagnifier1";
            this.imageMagnifier1.Size = new System.Drawing.Size(202, 181);
            this.imageMagnifier1.TabIndex = 4;
            this.imageMagnifier1.Text = "imageMagnifier1";
            // 
            // imageMagnifier2
            // 
            this.imageMagnifier2.ImageToMagnify = null;
            this.imageMagnifier2.Location = new System.Drawing.Point(220, 12);
            this.imageMagnifier2.MagnificationCoefficient = 1;
            this.imageMagnifier2.Name = "imageMagnifier2";
            this.imageMagnifier2.Size = new System.Drawing.Size(202, 181);
            this.imageMagnifier2.TabIndex = 5;
            this.imageMagnifier2.Text = "imageMagnifier2";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Run";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // imageMagnifier3
            // 
            this.imageMagnifier3.ImageToMagnify = null;
            this.imageMagnifier3.Location = new System.Drawing.Point(428, 12);
            this.imageMagnifier3.MagnificationCoefficient = 1;
            this.imageMagnifier3.Name = "imageMagnifier3";
            this.imageMagnifier3.Size = new System.Drawing.Size(202, 181);
            this.imageMagnifier3.TabIndex = 7;
            this.imageMagnifier3.Text = "imageMagnifier3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 373);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imageMagnifier3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.imageMagnifier2);
            this.Controls.Add(this.imageMagnifier1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private ImageMagnifier.ImageMagnifier imageMagnifier1;
        private ImageMagnifier.ImageMagnifier imageMagnifier2;
        private System.Windows.Forms.Button button2;
        private ImageMagnifier.ImageMagnifier imageMagnifier3;
        private System.Windows.Forms.Label label1;
    }
}

