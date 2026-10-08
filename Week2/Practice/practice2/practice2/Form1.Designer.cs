namespace practice2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_label = new System.Windows.Forms.Button();
            this.clearlabel = new System.Windows.Forms.Button();
            this.closeform = new System.Windows.Forms.Button();
            this.label_display = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_label
            // 
            this.button_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_label.Location = new System.Drawing.Point(93, 108);
            this.button_label.Name = "button_label";
            this.button_label.Size = new System.Drawing.Size(164, 62);
            this.button_label.TabIndex = 0;
            this.button_label.Text = "lbl_text";
            this.button_label.UseVisualStyleBackColor = true;
            this.button_label.Click += new System.EventHandler(this.button_label_Click);
            // 
            // clearlabel
            // 
            this.clearlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearlabel.Location = new System.Drawing.Point(311, 42);
            this.clearlabel.Name = "clearlabel";
            this.clearlabel.Size = new System.Drawing.Size(168, 63);
            this.clearlabel.TabIndex = 1;
            this.clearlabel.Text = "lbl_text2";
            this.clearlabel.UseVisualStyleBackColor = true;
            this.clearlabel.Click += new System.EventHandler(this.clearlabel_Click);
            // 
            // closeform
            // 
            this.closeform.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeform.Location = new System.Drawing.Point(523, 108);
            this.closeform.Name = "closeform";
            this.closeform.Size = new System.Drawing.Size(176, 62);
            this.closeform.TabIndex = 2;
            this.closeform.Text = "close";
            this.closeform.UseVisualStyleBackColor = true;
            this.closeform.Click += new System.EventHandler(this.closeform_Click);
            // 
            // label_display
            // 
            this.label_display.AutoSize = true;
            this.label_display.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_display.Location = new System.Drawing.Point(358, 196);
            this.label_display.Name = "label_display";
            this.label_display.Size = new System.Drawing.Size(123, 22);
            this.label_display.TabIndex = 3;
            this.label_display.Text = "label_practice";
            this.label_display.Click += new System.EventHandler(this.label_display_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(223, 265);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(389, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_display);
            this.Controls.Add(this.closeform);
            this.Controls.Add(this.clearlabel);
            this.Controls.Add(this.button_label);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_label;
        private System.Windows.Forms.Button clearlabel;
        private System.Windows.Forms.Button closeform;
        private System.Windows.Forms.Label label_display;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

