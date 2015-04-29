namespace CatProject
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
            this.components = new System.ComponentModel.Container();
            this.catCountDown = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.catTimerLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.saveFileCatDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // catCountDown
            // 
            this.catCountDown.Interval = 1000;
            this.catCountDown.Tick += new System.EventHandler(this.catCountDown_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 216);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // catTimerLabel
            // 
            this.catTimerLabel.AutoSize = true;
            this.catTimerLabel.Location = new System.Drawing.Point(12, 8);
            this.catTimerLabel.Name = "catTimerLabel";
            this.catTimerLabel.Size = new System.Drawing.Size(259, 13);
            this.catTimerLabel.TabIndex = 1;
            this.catTimerLabel.Text = "У тебя 2 минуты на то, чтобы нарисовать  котика";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(0, 24);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(283, 23);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Начать!!!";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.catTimerLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer catCountDown;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label catTimerLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.SaveFileDialog saveFileCatDialog;
    }
}

