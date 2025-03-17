namespace BrowerYahtzee
{
    partial class FormGameControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGameControl));
            this.labelNumPlayers = new System.Windows.Forms.Label();
            this.numericNumPlayers = new System.Windows.Forms.NumericUpDown();
            this.buttonStartGame = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelPlayerFour = new System.Windows.Forms.Label();
            this.labelPlayerThree = new System.Windows.Forms.Label();
            this.textBoxPlayerTwo = new System.Windows.Forms.TextBox();
            this.labelPlayerTwo = new System.Windows.Forms.Label();
            this.textBoxPlayerThree = new System.Windows.Forms.TextBox();
            this.textBoxPlayerFour = new System.Windows.Forms.TextBox();
            this.textBoxPlayerOne = new System.Windows.Forms.TextBox();
            this.labelPlayerOne = new System.Windows.Forms.Label();
            this.imageListDieFaces = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericNumPlayers)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNumPlayers
            // 
            this.labelNumPlayers.AutoSize = true;
            this.labelNumPlayers.Location = new System.Drawing.Point(12, 9);
            this.labelNumPlayers.Name = "labelNumPlayers";
            this.labelNumPlayers.Size = new System.Drawing.Size(92, 13);
            this.labelNumPlayers.TabIndex = 20;
            this.labelNumPlayers.Text = "Number of players";
            // 
            // numericNumPlayers
            // 
            this.numericNumPlayers.Location = new System.Drawing.Point(110, 7);
            this.numericNumPlayers.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericNumPlayers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericNumPlayers.Name = "numericNumPlayers";
            this.numericNumPlayers.Size = new System.Drawing.Size(48, 20);
            this.numericNumPlayers.TabIndex = 12;
            this.numericNumPlayers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonStartGame
            // 
            this.buttonStartGame.Location = new System.Drawing.Point(164, 4);
            this.buttonStartGame.Name = "buttonStartGame";
            this.buttonStartGame.Size = new System.Drawing.Size(164, 23);
            this.buttonStartGame.TabIndex = 11;
            this.buttonStartGame.Text = "Begin Game";
            this.buttonStartGame.UseVisualStyleBackColor = true;
            this.buttonStartGame.Click += new System.EventHandler(this.buttonStartGame_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelPlayerFour);
            this.groupBox1.Controls.Add(this.labelPlayerThree);
            this.groupBox1.Controls.Add(this.textBoxPlayerTwo);
            this.groupBox1.Controls.Add(this.labelPlayerTwo);
            this.groupBox1.Controls.Add(this.textBoxPlayerThree);
            this.groupBox1.Controls.Add(this.textBoxPlayerFour);
            this.groupBox1.Controls.Add(this.textBoxPlayerOne);
            this.groupBox1.Controls.Add(this.labelPlayerOne);
            this.groupBox1.Location = new System.Drawing.Point(15, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 64);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Scores";
            // 
            // labelPlayerFour
            // 
            this.labelPlayerFour.AutoSize = true;
            this.labelPlayerFour.Location = new System.Drawing.Point(231, 16);
            this.labelPlayerFour.Name = "labelPlayerFour";
            this.labelPlayerFour.Size = new System.Drawing.Size(45, 13);
            this.labelPlayerFour.TabIndex = 29;
            this.labelPlayerFour.Text = "Player 4";
            this.labelPlayerFour.Visible = false;
            // 
            // labelPlayerThree
            // 
            this.labelPlayerThree.AutoSize = true;
            this.labelPlayerThree.Location = new System.Drawing.Point(155, 16);
            this.labelPlayerThree.Name = "labelPlayerThree";
            this.labelPlayerThree.Size = new System.Drawing.Size(45, 13);
            this.labelPlayerThree.TabIndex = 28;
            this.labelPlayerThree.Text = "Player 3";
            this.labelPlayerThree.Visible = false;
            // 
            // textBoxPlayerTwo
            // 
            this.textBoxPlayerTwo.Location = new System.Drawing.Point(82, 32);
            this.textBoxPlayerTwo.Name = "textBoxPlayerTwo";
            this.textBoxPlayerTwo.ReadOnly = true;
            this.textBoxPlayerTwo.Size = new System.Drawing.Size(70, 20);
            this.textBoxPlayerTwo.TabIndex = 27;
            this.textBoxPlayerTwo.Visible = false;
            // 
            // labelPlayerTwo
            // 
            this.labelPlayerTwo.AutoSize = true;
            this.labelPlayerTwo.Location = new System.Drawing.Point(79, 16);
            this.labelPlayerTwo.Name = "labelPlayerTwo";
            this.labelPlayerTwo.Size = new System.Drawing.Size(45, 13);
            this.labelPlayerTwo.TabIndex = 24;
            this.labelPlayerTwo.Text = "Player 2";
            this.labelPlayerTwo.Visible = false;
            // 
            // textBoxPlayerThree
            // 
            this.textBoxPlayerThree.Location = new System.Drawing.Point(158, 32);
            this.textBoxPlayerThree.Name = "textBoxPlayerThree";
            this.textBoxPlayerThree.ReadOnly = true;
            this.textBoxPlayerThree.Size = new System.Drawing.Size(70, 20);
            this.textBoxPlayerThree.TabIndex = 26;
            this.textBoxPlayerThree.Visible = false;
            // 
            // textBoxPlayerFour
            // 
            this.textBoxPlayerFour.Location = new System.Drawing.Point(234, 32);
            this.textBoxPlayerFour.Name = "textBoxPlayerFour";
            this.textBoxPlayerFour.ReadOnly = true;
            this.textBoxPlayerFour.Size = new System.Drawing.Size(70, 20);
            this.textBoxPlayerFour.TabIndex = 25;
            this.textBoxPlayerFour.Visible = false;
            // 
            // textBoxPlayerOne
            // 
            this.textBoxPlayerOne.Location = new System.Drawing.Point(6, 32);
            this.textBoxPlayerOne.Name = "textBoxPlayerOne";
            this.textBoxPlayerOne.ReadOnly = true;
            this.textBoxPlayerOne.Size = new System.Drawing.Size(70, 20);
            this.textBoxPlayerOne.TabIndex = 23;
            this.textBoxPlayerOne.Visible = false;
            // 
            // labelPlayerOne
            // 
            this.labelPlayerOne.AutoSize = true;
            this.labelPlayerOne.Location = new System.Drawing.Point(6, 16);
            this.labelPlayerOne.Name = "labelPlayerOne";
            this.labelPlayerOne.Size = new System.Drawing.Size(45, 13);
            this.labelPlayerOne.TabIndex = 22;
            this.labelPlayerOne.Text = "Player 1";
            this.labelPlayerOne.Visible = false;
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
            // FormGameControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 107);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelNumPlayers);
            this.Controls.Add(this.numericNumPlayers);
            this.Controls.Add(this.buttonStartGame);
            this.Name = "FormGameControl";
            this.Text = "Game control";
            ((System.ComponentModel.ISupportInitialize)(this.numericNumPlayers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelNumPlayers;
        private System.Windows.Forms.NumericUpDown numericNumPlayers;
        private System.Windows.Forms.Button buttonStartGame;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelPlayerFour;
        private System.Windows.Forms.Label labelPlayerThree;
        private System.Windows.Forms.TextBox textBoxPlayerTwo;
        private System.Windows.Forms.Label labelPlayerTwo;
        private System.Windows.Forms.TextBox textBoxPlayerThree;
        private System.Windows.Forms.TextBox textBoxPlayerFour;
        private System.Windows.Forms.TextBox textBoxPlayerOne;
        private System.Windows.Forms.ImageList imageListDieFaces;
        private System.Windows.Forms.Label labelPlayerOne;
    }
}