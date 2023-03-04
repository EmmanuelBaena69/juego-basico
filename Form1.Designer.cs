namespace juego_pai
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            picNave = new PictureBox();
            btnStart = new Button();
            tmrStart = new System.Windows.Forms.Timer(components);
            btnPause = new Button();
            picMonster = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picNave).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMonster).BeginInit();
            SuspendLayout();
            // 
            // picNave
            // 
            picNave.BackColor = Color.Transparent;
            picNave.Image = (Image)resources.GetObject("picNave.Image");
            picNave.Location = new Point(351, 327);
            picNave.Name = "picNave";
            picNave.Size = new Size(87, 74);
            picNave.SizeMode = PictureBoxSizeMode.Zoom;
            picNave.TabIndex = 0;
            picNave.TabStop = false;
            picNave.Click += picNave_Click;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(2, 418);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(94, 29);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // tmrStart
            // 
            tmrStart.Tick += tmrStart_Tick;
            // 
            // btnPause
            // 
            btnPause.Location = new Point(102, 418);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(94, 29);
            btnPause.TabIndex = 2;
            btnPause.Text = "Pause";
            btnPause.UseVisualStyleBackColor = true;
            btnPause.Click += btnPause_Click;
            // 
            // picMonster
            // 
            picMonster.BackColor = Color.Transparent;
            picMonster.BackgroundImageLayout = ImageLayout.Center;
            picMonster.Image = (Image)resources.GetObject("picMonster.Image");
            picMonster.Location = new Point(351, 12);
            picMonster.Name = "picMonster";
            picMonster.Size = new Size(87, 71);
            picMonster.SizeMode = PictureBoxSizeMode.Zoom;
            picMonster.TabIndex = 3;
            picMonster.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(picMonster);
            Controls.Add(btnPause);
            Controls.Add(btnStart);
            Controls.Add(picNave);
            KeyPreview = true;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            KeyUp += Form1_KeyUp;
            ((System.ComponentModel.ISupportInitialize)picNave).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMonster).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picNave;
        private Button btnStart;
        private System.Windows.Forms.Timer tmrStart;
        private Button btnPause;
        private PictureBox picMonster;
    }
}