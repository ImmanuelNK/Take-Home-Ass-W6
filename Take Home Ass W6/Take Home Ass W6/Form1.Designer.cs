namespace Take_Home_Ass_W6
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
            this.textBoxsize = new System.Windows.Forms.TextBox();
            this.labeljudul = new System.Windows.Forms.Label();
            this.buttonenter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxsize
            // 
            this.textBoxsize.Location = new System.Drawing.Point(517, 170);
            this.textBoxsize.Name = "textBoxsize";
            this.textBoxsize.Size = new System.Drawing.Size(159, 22);
            this.textBoxsize.TabIndex = 0;
            // 
            // labeljudul
            // 
            this.labeljudul.AutoSize = true;
            this.labeljudul.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeljudul.Location = new System.Drawing.Point(509, 91);
            this.labeljudul.Name = "labeljudul";
            this.labeljudul.Size = new System.Drawing.Size(179, 48);
            this.labeljudul.TabIndex = 1;
            this.labeljudul.Text = "WORDLE";
            // 
            // buttonenter
            // 
            this.buttonenter.Location = new System.Drawing.Point(541, 212);
            this.buttonenter.Name = "buttonenter";
            this.buttonenter.Size = new System.Drawing.Size(112, 40);
            this.buttonenter.TabIndex = 2;
            this.buttonenter.Text = "Enter";
            this.buttonenter.UseVisualStyleBackColor = true;
            this.buttonenter.Click += new System.EventHandler(this.buttonenter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 586);
            this.Controls.Add(this.buttonenter);
            this.Controls.Add(this.labeljudul);
            this.Controls.Add(this.textBoxsize);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxsize;
        private System.Windows.Forms.Label labeljudul;
        private System.Windows.Forms.Button buttonenter;
    }
}

