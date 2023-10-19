using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Security;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Management.Automation;
using System.Management.Automation.Runspaces;

namespace tag_replicator
{
    partial class Form1
    {
        string path = @"C:\Users\chris\Desktop\cgi\test.txt";

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            tagListTextBox = new TextBox();
            tagList = new Label();
            sourceServer = new Label();
            textBox1 = new TextBox();
            destinationServerTextBox = new TextBox();
            destinationServer = new Label();
            startBtn = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            dateFin = new Label();
            dateDebut = new Label();
            SuspendLayout();
            // 
            // tagListTextBox
            // 
            tagListTextBox.Location = new Point(240, 59);
            tagListTextBox.Multiline = true;
            tagListTextBox.Name = "tagListTextBox";
            tagListTextBox.ScrollBars = ScrollBars.Vertical;
            tagListTextBox.Size = new Size(313, 379);
            tagListTextBox.TabIndex = 0;
            // 
            // tagList
            // 
            tagList.AutoSize = true;
            tagList.Location = new Point(369, 41);
            tagList.Name = "tagList";
            tagList.Size = new Size(58, 15);
            tagList.TabIndex = 1;
            tagList.Text = "TAGS LIST";
            // 
            // sourceServer
            // 
            sourceServer.AutoSize = true;
            sourceServer.Location = new Point(78, 62);
            sourceServer.Name = "sourceServer";
            sourceServer.Size = new Size(78, 15);
            sourceServer.TabIndex = 2;
            sourceServer.Text = "Source Server";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(8, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(223, 23);
            textBox1.TabIndex = 3;
            // 
            // destinationServerTextBox
            // 
            destinationServerTextBox.Location = new Point(8, 141);
            destinationServerTextBox.Name = "destinationServerTextBox";
            destinationServerTextBox.Size = new Size(223, 23);
            destinationServerTextBox.TabIndex = 6;
            // 
            // destinationServer
            // 
            destinationServer.AutoSize = true;
            destinationServer.Location = new Point(69, 123);
            destinationServer.Name = "destinationServer";
            destinationServer.Size = new Size(102, 15);
            destinationServer.TabIndex = 5;
            destinationServer.Text = "Destination Server";
            // 
            // startBtn
            // 
            startBtn.Location = new Point(8, 357);
            startBtn.Name = "startBtn";
            startBtn.Size = new Size(223, 81);
            startBtn.TabIndex = 8;
            startBtn.Text = "START";
            startBtn.UseVisualStyleBackColor = true;
            startBtn.Click += startBtn_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.HotTrack;
            textBox2.Location = new Point(578, 59);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ScrollBars = ScrollBars.Vertical;
            textBox2.Size = new Size(574, 379);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(8, 256);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(223, 23);
            textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 311);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(219, 23);
            textBox4.TabIndex = 11;
            // 
            // label1
            // 
            dateFin.AutoSize = true;
            dateFin.Location = new Point(91, 293);
            dateFin.Name = "label1";
            dateFin.Size = new Size(48, 15);
            dateFin.TabIndex = 12;
            dateFin.Text = "Date fin";
            // 
            // label2
            // 
            dateDebut.AutoSize = true;
            dateDebut.Location = new Point(78, 238);
            dateDebut.Name = "label2";
            dateDebut.Size = new Size(65, 15);
            dateDebut.TabIndex = 13;
            dateDebut.Text = "Date debut";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1175, 450);
            Controls.Add(dateDebut);
            Controls.Add(dateFin);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(startBtn);
            Controls.Add(textBox2);
            Controls.Add(destinationServerTextBox);
            Controls.Add(destinationServer);
            Controls.Add(textBox1);
            Controls.Add(sourceServer);
            Controls.Add(tagList);
            Controls.Add(tagListTextBox);
            Name = "Form1";
            Text = "TAG REPLICATOR";
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private TextBox tagListTextBox;
        private Label tagList;
        private Label sourceServer;
        private TextBox textBox1;
        private TextBox destinationServerTextBox;
        private Label destinationServer;
        private Button startBtn;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label dateFin;
        private Label dateDebut;
    }
}