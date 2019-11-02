namespace TeslaDashcamPlayer
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
            this.axWindowsMediaPlayerLeft = new AxWMPLib.AxWindowsMediaPlayer();
            this.axWindowsMediaPlayerFront = new AxWMPLib.AxWindowsMediaPlayer();
            this.axWindowsMediaPlayerRight = new AxWMPLib.AxWindowsMediaPlayer();
            this.currentStateLabel = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayerBack = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerFront)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerBack)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayerLeft
            // 
            this.axWindowsMediaPlayerLeft.Enabled = true;
            this.axWindowsMediaPlayerLeft.Location = new System.Drawing.Point(340, 42);
            this.axWindowsMediaPlayerLeft.Name = "axWindowsMediaPlayerLeft";
            this.axWindowsMediaPlayerLeft.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayerLeft.OcxState")));
            this.axWindowsMediaPlayerLeft.Size = new System.Drawing.Size(640, 480);
            this.axWindowsMediaPlayerLeft.TabIndex = 0;
            // 
            // axWindowsMediaPlayerFront
            // 
            this.axWindowsMediaPlayerFront.Enabled = true;
            this.axWindowsMediaPlayerFront.Location = new System.Drawing.Point(980, 42);
            this.axWindowsMediaPlayerFront.Name = "axWindowsMediaPlayerFront";
            this.axWindowsMediaPlayerFront.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayerFront.OcxState")));
            this.axWindowsMediaPlayerFront.Size = new System.Drawing.Size(640, 480);
            this.axWindowsMediaPlayerFront.TabIndex = 3;
            this.axWindowsMediaPlayerFront.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer2_PlayStateChange);
            // 
            // axWindowsMediaPlayerRight
            // 
            this.axWindowsMediaPlayerRight.Enabled = true;
            this.axWindowsMediaPlayerRight.Location = new System.Drawing.Point(1620, 42);
            this.axWindowsMediaPlayerRight.Name = "axWindowsMediaPlayerRight";
            this.axWindowsMediaPlayerRight.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayerRight.OcxState")));
            this.axWindowsMediaPlayerRight.Size = new System.Drawing.Size(640, 480);
            this.axWindowsMediaPlayerRight.TabIndex = 4;
            // 
            // currentStateLabel
            // 
            this.currentStateLabel.Location = new System.Drawing.Point(794, 16);
            this.currentStateLabel.Name = "currentStateLabel";
            this.currentStateLabel.Size = new System.Drawing.Size(693, 20);
            this.currentStateLabel.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 60);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(150, 212);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Recent Clips:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Saved Clips:";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(16, 306);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(150, 212);
            this.listBox2.TabIndex = 9;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(184, 306);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(150, 212);
            this.listBox3.TabIndex = 10;
            this.listBox3.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Select Folder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // axWindowsMediaPlayerBack
            // 
            this.axWindowsMediaPlayerBack.Enabled = true;
            this.axWindowsMediaPlayerBack.Location = new System.Drawing.Point(980, 522);
            this.axWindowsMediaPlayerBack.Name = "axWindowsMediaPlayerBack";
            this.axWindowsMediaPlayerBack.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayerBack.OcxState")));
            this.axWindowsMediaPlayerBack.Size = new System.Drawing.Size(640, 480);
            this.axWindowsMediaPlayerBack.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2272, 1011);
            this.Controls.Add(this.axWindowsMediaPlayerBack);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.currentStateLabel);
            this.Controls.Add(this.axWindowsMediaPlayerRight);
            this.Controls.Add(this.axWindowsMediaPlayerFront);
            this.Controls.Add(this.axWindowsMediaPlayerLeft);
            this.Name = "Form1";
            this.Text = "Tesla Dashcam Player";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerFront)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayerLeft;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayerFront;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayerRight;
        private System.Windows.Forms.TextBox currentStateLabel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button button1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayerBack;
    }
}

