namespace DayZ_Admin_Log_Tool
{
    partial class MainForm
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
            this.RemoteExecLogFileButton = new System.Windows.Forms.Button();
            this.ServerConsoleLogFileButton = new System.Windows.Forms.Button();
            this.RemoteExecLogFilePathTextBox = new System.Windows.Forms.TextBox();
            this.ServerConsoleLogFilePathTextBox = new System.Windows.Forms.TextBox();
            this.RemoteExecLogFileOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ServerConsoleLogFileOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ResultOutputTextBox = new System.Windows.Forms.TextBox();
            this.ParseButton = new System.Windows.Forms.Button();
            this.ParseWithComments = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CommentStringTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RemoteExecLogFileButton
            // 
            this.RemoteExecLogFileButton.Location = new System.Drawing.Point(12, 10);
            this.RemoteExecLogFileButton.Name = "RemoteExecLogFileButton";
            this.RemoteExecLogFileButton.Size = new System.Drawing.Size(154, 22);
            this.RemoteExecLogFileButton.TabIndex = 0;
            this.RemoteExecLogFileButton.Text = "Select remoteexec.log";
            this.RemoteExecLogFileButton.UseVisualStyleBackColor = true;
            this.RemoteExecLogFileButton.Click += new System.EventHandler(this.RemoteExecLogFileButton_Click);
            // 
            // ServerConsoleLogFileButton
            // 
            this.ServerConsoleLogFileButton.Location = new System.Drawing.Point(12, 38);
            this.ServerConsoleLogFileButton.Name = "ServerConsoleLogFileButton";
            this.ServerConsoleLogFileButton.Size = new System.Drawing.Size(154, 22);
            this.ServerConsoleLogFileButton.TabIndex = 1;
            this.ServerConsoleLogFileButton.Text = "Select Server_console.log ";
            this.ServerConsoleLogFileButton.UseVisualStyleBackColor = true;
            this.ServerConsoleLogFileButton.Click += new System.EventHandler(this.ServerConsoleLogFileButton_Click);
            // 
            // RemoteExecLogFilePathTextBox
            // 
            this.RemoteExecLogFilePathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoteExecLogFilePathTextBox.Location = new System.Drawing.Point(172, 14);
            this.RemoteExecLogFilePathTextBox.Name = "RemoteExecLogFilePathTextBox";
            this.RemoteExecLogFilePathTextBox.Size = new System.Drawing.Size(718, 20);
            this.RemoteExecLogFilePathTextBox.TabIndex = 2;
            // 
            // ServerConsoleLogFilePathTextBox
            // 
            this.ServerConsoleLogFilePathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ServerConsoleLogFilePathTextBox.Location = new System.Drawing.Point(172, 40);
            this.ServerConsoleLogFilePathTextBox.Name = "ServerConsoleLogFilePathTextBox";
            this.ServerConsoleLogFilePathTextBox.Size = new System.Drawing.Size(718, 20);
            this.ServerConsoleLogFilePathTextBox.TabIndex = 3;
            // 
            // RemoteExecLogFileOpenFileDialog
            // 
            this.RemoteExecLogFileOpenFileDialog.FileName = "remoteexec.log";
            // 
            // ServerConsoleLogFileOpenFileDialog
            // 
            this.ServerConsoleLogFileOpenFileDialog.FileName = "openFileDialog1";
            // 
            // ResultOutputTextBox
            // 
            this.ResultOutputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultOutputTextBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ResultOutputTextBox.Location = new System.Drawing.Point(13, 67);
            this.ResultOutputTextBox.Multiline = true;
            this.ResultOutputTextBox.Name = "ResultOutputTextBox";
            this.ResultOutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ResultOutputTextBox.Size = new System.Drawing.Size(877, 408);
            this.ResultOutputTextBox.TabIndex = 4;
            // 
            // ParseButton
            // 
            this.ParseButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ParseButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ParseButton.Location = new System.Drawing.Point(13, 481);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(392, 51);
            this.ParseButton.TabIndex = 5;
            this.ParseButton.Text = "Pasre plz!";
            this.ParseButton.UseVisualStyleBackColor = true;
            this.ParseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // ParseWithComments
            // 
            this.ParseWithComments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ParseWithComments.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ParseWithComments.Location = new System.Drawing.Point(411, 481);
            this.ParseWithComments.Name = "ParseWithComments";
            this.ParseWithComments.Size = new System.Drawing.Size(392, 51);
            this.ParseWithComments.TabIndex = 6;
            this.ParseWithComments.Text = "Pasre with comments plz!";
            this.ParseWithComments.UseVisualStyleBackColor = true;
            this.ParseWithComments.Click += new System.EventHandler(this.ParseWithComments_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(810, 481);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Comment string:";
            // 
            // CommentStringTextBox
            // 
            this.CommentStringTextBox.Location = new System.Drawing.Point(813, 502);
            this.CommentStringTextBox.Name = "CommentStringTextBox";
            this.CommentStringTextBox.Size = new System.Drawing.Size(79, 20);
            this.CommentStringTextBox.TabIndex = 8;
            this.CommentStringTextBox.Text = "//";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 534);
            this.Controls.Add(this.CommentStringTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ParseWithComments);
            this.Controls.Add(this.ParseButton);
            this.Controls.Add(this.ResultOutputTextBox);
            this.Controls.Add(this.ServerConsoleLogFilePathTextBox);
            this.Controls.Add(this.RemoteExecLogFilePathTextBox);
            this.Controls.Add(this.ServerConsoleLogFileButton);
            this.Controls.Add(this.RemoteExecLogFileButton);
            this.Name = "MainForm";
            this.Text = "DayZ Admin Log Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RemoteExecLogFileButton;
        private System.Windows.Forms.Button ServerConsoleLogFileButton;
        private System.Windows.Forms.TextBox RemoteExecLogFilePathTextBox;
        private System.Windows.Forms.TextBox ServerConsoleLogFilePathTextBox;
        private System.Windows.Forms.OpenFileDialog RemoteExecLogFileOpenFileDialog;
        private System.Windows.Forms.OpenFileDialog ServerConsoleLogFileOpenFileDialog;
        private System.Windows.Forms.TextBox ResultOutputTextBox;
        private System.Windows.Forms.Button ParseButton;
        private System.Windows.Forms.Button ParseWithComments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CommentStringTextBox;
    }
}

