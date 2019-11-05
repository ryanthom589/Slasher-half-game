namespace Slasher_half_game
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
            this.gameLabel = new System.Windows.Forms.Label();
            this.leftPictureBox = new System.Windows.Forms.PictureBox();
            this.middlePictureBox = new System.Windows.Forms.PictureBox();
            this.rightPictureBox = new System.Windows.Forms.PictureBox();
            this.questionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.leftPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.middlePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // gameLabel
            // 
            this.gameLabel.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameLabel.Location = new System.Drawing.Point(-2, -1);
            this.gameLabel.Name = "gameLabel";
            this.gameLabel.Size = new System.Drawing.Size(807, 203);
            this.gameLabel.TabIndex = 0;
            this.gameLabel.Text = "Dont split up";
            this.gameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gameLabel.Click += new System.EventHandler(this.Label1_Click);
            // 
            // leftPictureBox
            // 
            this.leftPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.leftPictureBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.leftPictureBox.Location = new System.Drawing.Point(12, 344);
            this.leftPictureBox.Name = "leftPictureBox";
            this.leftPictureBox.Size = new System.Drawing.Size(158, 94);
            this.leftPictureBox.TabIndex = 4;
            this.leftPictureBox.TabStop = false;
            // 
            // middlePictureBox
            // 
            this.middlePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.middlePictureBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.middlePictureBox.Location = new System.Drawing.Point(262, 344);
            this.middlePictureBox.Name = "middlePictureBox";
            this.middlePictureBox.Size = new System.Drawing.Size(158, 94);
            this.middlePictureBox.TabIndex = 5;
            this.middlePictureBox.TabStop = false;
            // 
            // rightPictureBox
            // 
            this.rightPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rightPictureBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rightPictureBox.Location = new System.Drawing.Point(581, 344);
            this.rightPictureBox.Name = "rightPictureBox";
            this.rightPictureBox.Size = new System.Drawing.Size(158, 94);
            this.rightPictureBox.TabIndex = 6;
            this.rightPictureBox.TabStop = false;
            // 
            // questionLabel
            // 
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.Location = new System.Drawing.Point(13, 197);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(775, 128);
            this.questionLabel.TabIndex = 7;
            this.questionLabel.Text = "label1";
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.rightPictureBox);
            this.Controls.Add(this.middlePictureBox);
            this.Controls.Add(this.leftPictureBox);
            this.Controls.Add(this.gameLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.leftPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.middlePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label gameLabel;
        private System.Windows.Forms.PictureBox leftPictureBox;
        private System.Windows.Forms.PictureBox middlePictureBox;
        private System.Windows.Forms.PictureBox rightPictureBox;
        private System.Windows.Forms.Label questionLabel;
    }
}

