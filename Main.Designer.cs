﻿
namespace MovieFInderApp
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.buttonLoginandPlay = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonPlayasaGuest = new System.Windows.Forms.Button();
            this.buttonRanking = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLoginandPlay
            // 
            this.buttonLoginandPlay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonLoginandPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonLoginandPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLoginandPlay.FlatAppearance.BorderSize = 0;
            this.buttonLoginandPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoginandPlay.ForeColor = System.Drawing.Color.Transparent;
            this.buttonLoginandPlay.Location = new System.Drawing.Point(354, 265);
            this.buttonLoginandPlay.Name = "buttonLoginandPlay";
            this.buttonLoginandPlay.Size = new System.Drawing.Size(284, 64);
            this.buttonLoginandPlay.TabIndex = 8;
            this.buttonLoginandPlay.Text = "Login and Play";
            this.buttonLoginandPlay.UseVisualStyleBackColor = false;
            this.buttonLoginandPlay.Click += new System.EventHandler(this.buttonLoginandPlay_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Transparent;
            this.panelHeader.Controls.Add(this.labelHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(978, 83);
            this.panelHeader.TabIndex = 9;
            // 
            // labelHeader
            // 
            this.labelHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelHeader.AutoSize = true;
            this.labelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelHeader.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.ForeColor = System.Drawing.Color.Crimson;
            this.labelHeader.Location = new System.Drawing.Point(328, 15);
            this.labelHeader.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(390, 54);
            this.labelHeader.TabIndex = 1;
            this.labelHeader.Text = "Movie Finder Game";
            this.labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonRegister
            // 
            this.buttonRegister.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegister.FlatAppearance.BorderSize = 0;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.ForeColor = System.Drawing.Color.Transparent;
            this.buttonRegister.Location = new System.Drawing.Point(354, 335);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(284, 67);
            this.buttonRegister.TabIndex = 7;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // buttonPlayasaGuest
            // 
            this.buttonPlayasaGuest.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonPlayasaGuest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonPlayasaGuest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPlayasaGuest.FlatAppearance.BorderSize = 0;
            this.buttonPlayasaGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlayasaGuest.ForeColor = System.Drawing.Color.Transparent;
            this.buttonPlayasaGuest.Location = new System.Drawing.Point(354, 193);
            this.buttonPlayasaGuest.Name = "buttonPlayasaGuest";
            this.buttonPlayasaGuest.Size = new System.Drawing.Size(284, 66);
            this.buttonPlayasaGuest.TabIndex = 6;
            this.buttonPlayasaGuest.Text = "Play as a guest";
            this.buttonPlayasaGuest.UseVisualStyleBackColor = false;
            this.buttonPlayasaGuest.Click += new System.EventHandler(this.buttonPlayasaGuest_Click);
            // 
            // buttonRanking
            // 
            this.buttonRanking.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonRanking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonRanking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRanking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRanking.FlatAppearance.BorderSize = 0;
            this.buttonRanking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRanking.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRanking.ForeColor = System.Drawing.Color.Transparent;
            this.buttonRanking.Image = ((System.Drawing.Image)(resources.GetObject("buttonRanking.Image")));
            this.buttonRanking.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRanking.Location = new System.Drawing.Point(354, 408);
            this.buttonRanking.Name = "buttonRanking";
            this.buttonRanking.Padding = new System.Windows.Forms.Padding(40, 0, 50, 0);
            this.buttonRanking.Size = new System.Drawing.Size(284, 67);
            this.buttonRanking.TabIndex = 10;
            this.buttonRanking.Text = "Ranking";
            this.buttonRanking.UseVisualStyleBackColor = false;
            this.buttonRanking.Click += new System.EventHandler(this.buttonRanking_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(978, 499);
            this.Controls.Add(this.buttonRanking);
            this.Controls.Add(this.buttonLoginandPlay);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.buttonPlayasaGuest);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MinimumSize = new System.Drawing.Size(1000, 550);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movie Finder Game";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLoginandPlay;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonPlayasaGuest;
        private System.Windows.Forms.Button buttonRanking;
    }
}

