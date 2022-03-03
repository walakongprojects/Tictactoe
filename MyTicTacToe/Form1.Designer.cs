﻿
namespace MyTicTacToe
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.A1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.playersTurnLabel = new System.Windows.Forms.Label();
            this.player_2_Score_lbl = new System.Windows.Forms.Label();
            this.player_1_Score_lbl = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(474, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // A1
            // 
            this.A1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.A1.ForeColor = System.Drawing.Color.Cornsilk;
            this.A1.Location = new System.Drawing.Point(14, 38);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(86, 85);
            this.A1.TabIndex = 1;
            this.A1.UseVisualStyleBackColor = true;
            this.A1.Click += new System.EventHandler(this.ticTacToeBttns);
            // 
            // A2
            // 
            this.A2.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.A2.Location = new System.Drawing.Point(106, 38);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(86, 85);
            this.A2.TabIndex = 2;
            this.A2.UseVisualStyleBackColor = true;
            this.A2.Click += new System.EventHandler(this.ticTacToeBttns);
            // 
            // A3
            // 
            this.A3.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.A3.Location = new System.Drawing.Point(199, 38);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(86, 85);
            this.A3.TabIndex = 3;
            this.A3.UseVisualStyleBackColor = true;
            this.A3.Click += new System.EventHandler(this.ticTacToeBttns);
            // 
            // B1
            // 
            this.B1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B1.Location = new System.Drawing.Point(15, 133);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(86, 85);
            this.B1.TabIndex = 1;
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.ticTacToeBttns);
            // 
            // B2
            // 
            this.B2.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B2.Location = new System.Drawing.Point(107, 133);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(86, 85);
            this.B2.TabIndex = 2;
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.ticTacToeBttns);
            // 
            // B3
            // 
            this.B3.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B3.Location = new System.Drawing.Point(199, 133);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(86, 85);
            this.B3.TabIndex = 3;
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.ticTacToeBttns);
            // 
            // C1
            // 
            this.C1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.C1.Location = new System.Drawing.Point(15, 224);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(86, 85);
            this.C1.TabIndex = 1;
            this.C1.UseVisualStyleBackColor = true;
            this.C1.Click += new System.EventHandler(this.ticTacToeBttns);
            // 
            // C2
            // 
            this.C2.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.C2.Location = new System.Drawing.Point(107, 224);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(86, 85);
            this.C2.TabIndex = 2;
            this.C2.UseVisualStyleBackColor = true;
            this.C2.Click += new System.EventHandler(this.ticTacToeBttns);
            // 
            // C3
            // 
            this.C3.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.C3.Location = new System.Drawing.Point(199, 224);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(86, 85);
            this.C3.TabIndex = 3;
            this.C3.UseVisualStyleBackColor = true;
            this.C3.Click += new System.EventHandler(this.ticTacToeBttns);
            // 
            // playersTurnLabel
            // 
            this.playersTurnLabel.AutoSize = true;
            this.playersTurnLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playersTurnLabel.Location = new System.Drawing.Point(26, 341);
            this.playersTurnLabel.Name = "playersTurnLabel";
            this.playersTurnLabel.Size = new System.Drawing.Size(97, 41);
            this.playersTurnLabel.TabIndex = 4;
            this.playersTurnLabel.Text = "label1";
            // 
            // player_2_Score_lbl
            // 
            this.player_2_Score_lbl.AutoSize = true;
            this.player_2_Score_lbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.player_2_Score_lbl.Location = new System.Drawing.Point(306, 122);
            this.player_2_Score_lbl.Name = "player_2_Score_lbl";
            this.player_2_Score_lbl.Size = new System.Drawing.Size(81, 35);
            this.player_2_Score_lbl.TabIndex = 6;
            this.player_2_Score_lbl.Text = "label1";
            // 
            // player_1_Score_lbl
            // 
            this.player_1_Score_lbl.AutoSize = true;
            this.player_1_Score_lbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.player_1_Score_lbl.Location = new System.Drawing.Point(306, 51);
            this.player_1_Score_lbl.Name = "player_1_Score_lbl";
            this.player_1_Score_lbl.Size = new System.Drawing.Size(81, 35);
            this.player_1_Score_lbl.TabIndex = 7;
            this.player_1_Score_lbl.Text = "label1";
            this.player_1_Score_lbl.Click += new System.EventHandler(this.player_1_Score_lbl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(474, 388);
            this.Controls.Add(this.player_1_Score_lbl);
            this.Controls.Add(this.player_2_Score_lbl);
            this.Controls.Add(this.playersTurnLabel);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "TicTacToe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.Label playersTurnLabel;
        private System.Windows.Forms.Label player_2_Score_lbl;
        private System.Windows.Forms.Label player_1_Score_lbl;
    }
}

