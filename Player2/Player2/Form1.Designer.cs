namespace Player2
{
    partial class Player2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Player2));
            this.media = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Volumedwonbutton = new System.Windows.Forms.Button();
            this.Volumeupbutton = new System.Windows.Forms.Button();
            this.playerbutton = new System.Windows.Forms.Button();
            this.muetbutton = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.openbutton = new System.Windows.Forms.Button();
            this.paushebutton = new System.Windows.Forms.Button();
            this.unmutebutton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.media)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // media
            // 
            this.media.Enabled = true;
            this.media.Location = new System.Drawing.Point(1, 7);
            this.media.Name = "media";
            this.media.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("media.OcxState")));
            this.media.Size = new System.Drawing.Size(780, 389);
            this.media.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.unmutebutton);
            this.panel1.Controls.Add(this.paushebutton);
            this.panel1.Controls.Add(this.Volumedwonbutton);
            this.panel1.Controls.Add(this.Volumeupbutton);
            this.panel1.Controls.Add(this.playerbutton);
            this.panel1.Controls.Add(this.muetbutton);
            this.panel1.Controls.Add(this.exitbutton);
            this.panel1.Controls.Add(this.openbutton);
            this.panel1.Location = new System.Drawing.Point(12, 402);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 50);
            this.panel1.TabIndex = 1;
            // 
            // Volumedwonbutton
            // 
            this.Volumedwonbutton.Location = new System.Drawing.Point(564, 7);
            this.Volumedwonbutton.Name = "Volumedwonbutton";
            this.Volumedwonbutton.Size = new System.Drawing.Size(75, 37);
            this.Volumedwonbutton.TabIndex = 5;
            this.Volumedwonbutton.Text = "Volume Dwon";
            this.Volumedwonbutton.UseVisualStyleBackColor = true;
            this.Volumedwonbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Volumeupbutton
            // 
            this.Volumeupbutton.Location = new System.Drawing.Point(483, 7);
            this.Volumeupbutton.Name = "Volumeupbutton";
            this.Volumeupbutton.Size = new System.Drawing.Size(75, 37);
            this.Volumeupbutton.TabIndex = 4;
            this.Volumeupbutton.Text = "VolumeUP";
            this.Volumeupbutton.UseVisualStyleBackColor = true;
            this.Volumeupbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // playerbutton
            // 
            this.playerbutton.Location = new System.Drawing.Point(119, 9);
            this.playerbutton.Name = "playerbutton";
            this.playerbutton.Size = new System.Drawing.Size(75, 35);
            this.playerbutton.TabIndex = 3;
            this.playerbutton.Text = "Player";
            this.playerbutton.UseVisualStyleBackColor = true;
            this.playerbutton.Click += new System.EventHandler(this.playerbutton_Click);
            // 
            // muetbutton
            // 
            this.muetbutton.Location = new System.Drawing.Point(302, 7);
            this.muetbutton.Name = "muetbutton";
            this.muetbutton.Size = new System.Drawing.Size(75, 37);
            this.muetbutton.TabIndex = 2;
            this.muetbutton.Text = "Mute";
            this.muetbutton.UseVisualStyleBackColor = true;
            this.muetbutton.Click += new System.EventHandler(this.button3_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.Location = new System.Drawing.Point(645, 7);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(75, 37);
            this.exitbutton.TabIndex = 1;
            this.exitbutton.Text = "Exit";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // openbutton
            // 
            this.openbutton.Location = new System.Drawing.Point(23, 7);
            this.openbutton.Name = "openbutton";
            this.openbutton.Size = new System.Drawing.Size(75, 37);
            this.openbutton.TabIndex = 0;
            this.openbutton.Text = "Open";
            this.openbutton.UseVisualStyleBackColor = true;
            this.openbutton.Click += new System.EventHandler(this.openbutton_Click);
            // 
            // paushebutton
            // 
            this.paushebutton.Location = new System.Drawing.Point(212, 7);
            this.paushebutton.Name = "paushebutton";
            this.paushebutton.Size = new System.Drawing.Size(75, 37);
            this.paushebutton.TabIndex = 6;
            this.paushebutton.Text = "Paushe";
            this.paushebutton.UseVisualStyleBackColor = true;
            this.paushebutton.Click += new System.EventHandler(this.aushebutton_Click);
            // 
            // unmutebutton
            // 
            this.unmutebutton.Location = new System.Drawing.Point(393, 7);
            this.unmutebutton.Name = "unmutebutton";
            this.unmutebutton.Size = new System.Drawing.Size(75, 37);
            this.unmutebutton.TabIndex = 7;
            this.unmutebutton.Text = "Unmute";
            this.unmutebutton.UseVisualStyleBackColor = true;
            this.unmutebutton.Click += new System.EventHandler(this.unmutebutton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Player2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 458);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.media);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Player2";
            this.Text = "Player2";
            this.Load += new System.EventHandler(this.Player2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.media)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer media;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button playerbutton;
        private System.Windows.Forms.Button muetbutton;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Button openbutton;
        private System.Windows.Forms.Button Volumedwonbutton;
        private System.Windows.Forms.Button Volumeupbutton;
        private System.Windows.Forms.Button paushebutton;
        private System.Windows.Forms.Button unmutebutton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

