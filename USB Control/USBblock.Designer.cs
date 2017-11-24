namespace USB_Control
{
    partial class USBblock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(USBblock));
            this.btnenable = new System.Windows.Forms.Button();
            this.btnDisable = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.lblshow = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnenable
            // 
            this.btnenable.BackColor = System.Drawing.Color.White;
            this.btnenable.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnenable.Location = new System.Drawing.Point(17, 103);
            this.btnenable.Name = "btnenable";
            this.btnenable.Size = new System.Drawing.Size(115, 53);
            this.btnenable.TabIndex = 0;
            this.btnenable.Text = "Enable";
            this.btnenable.UseVisualStyleBackColor = false;
            this.btnenable.Click += new System.EventHandler(this.btnenable_Click);
            // 
            // btnDisable
            // 
            this.btnDisable.BackColor = System.Drawing.Color.White;
            this.btnDisable.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDisable.Location = new System.Drawing.Point(147, 103);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(115, 53);
            this.btnDisable.TabIndex = 1;
            this.btnDisable.Text = "Disable";
            this.btnDisable.UseVisualStyleBackColor = false;
            this.btnDisable.Click += new System.EventHandler(this.btnDisable_Click);
            // 
            // lbl
            // 
            this.lbl.BackColor = System.Drawing.Color.Transparent;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.Blue;
            this.lbl.Location = new System.Drawing.Point(86, 42);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(111, 40);
            this.lbl.TabIndex = 6;
            this.lbl.Text = "RUBICTRON";
            this.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl.Click += new System.EventHandler(this.lbl_Click);
            // 
            // lblshow
            // 
            this.lblshow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblshow.BackColor = System.Drawing.Color.Transparent;
            this.lblshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblshow.ForeColor = System.Drawing.Color.Yellow;
            this.lblshow.Location = new System.Drawing.Point(12, 169);
            this.lblshow.Name = "lblshow";
            this.lblshow.Size = new System.Drawing.Size(260, 37);
            this.lblshow.TabIndex = 7;
            this.lblshow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(203, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 75);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::USB_Control.Properties.Resources.Untitled_1_copy;
            this.pictureBox1.Location = new System.Drawing.Point(5, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(14, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 46);
            this.label1.TabIndex = 8;
            this.label1.Text = "You can Enable Or Disable Your USB Flash Driver Access";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 41);
            this.button1.TabIndex = 9;
            this.button1.Text = "Click To Run As Administrator";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // USBblock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::USB_Control.Properties.Resources.Untitled_1_cofgfgfpy;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnDisable);
            this.Controls.Add(this.btnenable);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblshow);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "USBblock";
            this.Text = "USB block";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnenable;
        private System.Windows.Forms.Button btnDisable;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblshow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

