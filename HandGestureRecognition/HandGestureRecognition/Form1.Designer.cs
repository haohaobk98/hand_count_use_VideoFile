﻿namespace HandGestureRecognition
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
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("number of hand");
            this.imageBoxFrameGrabber = new Emgu.CV.UI.ImageBox();
            this.splitContainerFrames = new System.Windows.Forms.SplitContainer();
            this.Lsv = new System.Windows.Forms.ListView();
            this.imageBoxSkin = new Emgu.CV.UI.ImageBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).BeginInit();
            this.splitContainerFrames.Panel1.SuspendLayout();
            this.splitContainerFrames.Panel2.SuspendLayout();
            this.splitContainerFrames.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxSkin)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageBoxFrameGrabber
            // 
            this.imageBoxFrameGrabber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBoxFrameGrabber.Location = new System.Drawing.Point(0, 24);
            this.imageBoxFrameGrabber.Name = "imageBoxFrameGrabber";
            this.imageBoxFrameGrabber.Size = new System.Drawing.Size(466, 361);
            this.imageBoxFrameGrabber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBoxFrameGrabber.TabIndex = 2;
            this.imageBoxFrameGrabber.TabStop = false;
            this.imageBoxFrameGrabber.Click += new System.EventHandler(this.imageBoxFrameGrabber_Click);
            // 
            // splitContainerFrames
            // 
            this.splitContainerFrames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerFrames.Location = new System.Drawing.Point(0, 0);
            this.splitContainerFrames.Name = "splitContainerFrames";
            // 
            // splitContainerFrames.Panel1
            // 
            this.splitContainerFrames.Panel1.Controls.Add(this.imageBoxFrameGrabber);
            this.splitContainerFrames.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainerFrames.Panel2
            // 
            this.splitContainerFrames.Panel2.Controls.Add(this.Lsv);
            this.splitContainerFrames.Panel2.Controls.Add(this.imageBoxSkin);
            this.splitContainerFrames.Size = new System.Drawing.Size(988, 385);
            this.splitContainerFrames.SplitterDistance = 466;
            this.splitContainerFrames.TabIndex = 3;
            // 
            // Lsv
            // 
            this.Lsv.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem7});
            this.Lsv.Location = new System.Drawing.Point(402, 3);
            this.Lsv.Name = "Lsv";
            this.Lsv.Size = new System.Drawing.Size(116, 165);
            this.Lsv.TabIndex = 3;
            this.Lsv.UseCompatibleStateImageBehavior = false;
            this.Lsv.View = System.Windows.Forms.View.SmallIcon;
            // 
            // imageBoxSkin
            // 
            this.imageBoxSkin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBoxSkin.Location = new System.Drawing.Point(0, 0);
            this.imageBoxSkin.Name = "imageBoxSkin";
            this.imageBoxSkin.Size = new System.Drawing.Size(518, 385);
            this.imageBoxSkin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBoxSkin.TabIndex = 2;
            this.imageBoxSkin.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(466, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 385);
            this.Controls.Add(this.splitContainerFrames);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).EndInit();
            this.splitContainerFrames.Panel1.ResumeLayout(false);
            this.splitContainerFrames.Panel1.PerformLayout();
            this.splitContainerFrames.Panel2.ResumeLayout(false);
            this.splitContainerFrames.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxSkin)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBoxFrameGrabber;
        private System.Windows.Forms.SplitContainer splitContainerFrames;
        private Emgu.CV.UI.ImageBox imageBoxSkin;
        private System.Windows.Forms.ListView Lsv;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

