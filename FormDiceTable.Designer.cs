namespace BrowerYahtzee
{
    partial class FormDiceTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDiceTable));
            this.buttonRoll = new System.Windows.Forms.Button();
            this.labelRollCountLabel = new System.Windows.Forms.Label();
            this.labelRollCountNumber = new System.Windows.Forms.Label();
            this.imageListDieFaces = new System.Windows.Forms.ImageList(this.components);
            this.pictureBoxDie1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDie2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDie3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDie4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDie5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDie1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDie2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDie3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDie4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDie5)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRoll
            // 
            this.buttonRoll.Location = new System.Drawing.Point(328, 189);
            this.buttonRoll.Name = "buttonRoll";
            this.buttonRoll.Size = new System.Drawing.Size(101, 44);
            this.buttonRoll.TabIndex = 10;
            this.buttonRoll.Text = "Roll";
            this.buttonRoll.UseVisualStyleBackColor = true;
            this.buttonRoll.Click += new System.EventHandler(this.buttonRoll_Click);
            // 
            // labelRollCountLabel
            // 
            this.labelRollCountLabel.AutoSize = true;
            this.labelRollCountLabel.Location = new System.Drawing.Point(12, 205);
            this.labelRollCountLabel.Name = "labelRollCountLabel";
            this.labelRollCountLabel.Size = new System.Drawing.Size(69, 13);
            this.labelRollCountLabel.TabIndex = 11;
            this.labelRollCountLabel.Text = "Roll number: ";
            // 
            // labelRollCountNumber
            // 
            this.labelRollCountNumber.AutoSize = true;
            this.labelRollCountNumber.Location = new System.Drawing.Point(87, 205);
            this.labelRollCountNumber.Name = "labelRollCountNumber";
            this.labelRollCountNumber.Size = new System.Drawing.Size(13, 13);
            this.labelRollCountNumber.TabIndex = 12;
            this.labelRollCountNumber.Text = "0";
            // 
            // imageListDieFaces
            // 
            this.imageListDieFaces.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListDieFaces.ImageStream")));
            this.imageListDieFaces.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListDieFaces.Images.SetKeyName(0, "Die1.bmp");
            this.imageListDieFaces.Images.SetKeyName(1, "Die2.bmp");
            this.imageListDieFaces.Images.SetKeyName(2, "Die3.bmp");
            this.imageListDieFaces.Images.SetKeyName(3, "Die4.bmp");
            this.imageListDieFaces.Images.SetKeyName(4, "Die5.bmp");
            this.imageListDieFaces.Images.SetKeyName(5, "Die6.bmp");
            // 
            // pictureBoxDie1
            // 
            this.pictureBoxDie1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDie1.Image")));
            this.pictureBoxDie1.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxDie1.Name = "pictureBoxDie1";
            this.pictureBoxDie1.Size = new System.Drawing.Size(80, 80);
            this.pictureBoxDie1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDie1.TabIndex = 0;
            this.pictureBoxDie1.TabStop = false;
            this.pictureBoxDie1.Click += new System.EventHandler(this.pictureBoxDie1_Click);
            // 
            // pictureBoxDie2
            // 
            this.pictureBoxDie2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDie2.Image")));
            this.pictureBoxDie2.Location = new System.Drawing.Point(98, 12);
            this.pictureBoxDie2.Name = "pictureBoxDie2";
            this.pictureBoxDie2.Size = new System.Drawing.Size(80, 80);
            this.pictureBoxDie2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDie2.TabIndex = 13;
            this.pictureBoxDie2.TabStop = false;
            this.pictureBoxDie2.Click += new System.EventHandler(this.pictureBoxDie2_Click);
            // 
            // pictureBoxDie3
            // 
            this.pictureBoxDie3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDie3.Image")));
            this.pictureBoxDie3.Location = new System.Drawing.Point(184, 12);
            this.pictureBoxDie3.Name = "pictureBoxDie3";
            this.pictureBoxDie3.Size = new System.Drawing.Size(80, 80);
            this.pictureBoxDie3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDie3.TabIndex = 14;
            this.pictureBoxDie3.TabStop = false;
            this.pictureBoxDie3.Click += new System.EventHandler(this.pictureBoxDie3_Click);
            // 
            // pictureBoxDie4
            // 
            this.pictureBoxDie4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDie4.Image")));
            this.pictureBoxDie4.Location = new System.Drawing.Point(270, 12);
            this.pictureBoxDie4.Name = "pictureBoxDie4";
            this.pictureBoxDie4.Size = new System.Drawing.Size(80, 80);
            this.pictureBoxDie4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDie4.TabIndex = 15;
            this.pictureBoxDie4.TabStop = false;
            this.pictureBoxDie4.Click += new System.EventHandler(this.pictureBoxDie4_Click);
            // 
            // pictureBoxDie5
            // 
            this.pictureBoxDie5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDie5.Image")));
            this.pictureBoxDie5.Location = new System.Drawing.Point(356, 12);
            this.pictureBoxDie5.Name = "pictureBoxDie5";
            this.pictureBoxDie5.Size = new System.Drawing.Size(80, 80);
            this.pictureBoxDie5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDie5.TabIndex = 16;
            this.pictureBoxDie5.TabStop = false;
            this.pictureBoxDie5.Click += new System.EventHandler(this.pictureBoxDie5_Click);
            // 
            // FormDiceTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(448, 251);
            this.Controls.Add(this.pictureBoxDie5);
            this.Controls.Add(this.pictureBoxDie4);
            this.Controls.Add(this.pictureBoxDie3);
            this.Controls.Add(this.pictureBoxDie2);
            this.Controls.Add(this.pictureBoxDie1);
            this.Controls.Add(this.labelRollCountNumber);
            this.Controls.Add(this.labelRollCountLabel);
            this.Controls.Add(this.buttonRoll);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDiceTable";
            this.Text = "Dice";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDie1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDie2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDie3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDie4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDie5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonRoll;
        private System.Windows.Forms.Label labelRollCountLabel;
        private System.Windows.Forms.Label labelRollCountNumber;
        private System.Windows.Forms.ImageList imageListDieFaces;
        private System.Windows.Forms.PictureBox pictureBoxDie1;
        private System.Windows.Forms.PictureBox pictureBoxDie2;
        private System.Windows.Forms.PictureBox pictureBoxDie3;
        private System.Windows.Forms.PictureBox pictureBoxDie4;
        private System.Windows.Forms.PictureBox pictureBoxDie5;
    }
}

