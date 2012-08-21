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
            this.FtpModeRadio = new System.Windows.Forms.RadioButton();
            this.FilesModeRadio = new System.Windows.Forms.RadioButton();
            this.FtpUsernameTextBox = new System.Windows.Forms.TextBox();
            this.FtpPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SavePasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FtpRemoteExecLogDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FtpHostTextBox = new System.Windows.Forms.TextBox();
            this.FtpServerConsoleLogDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RemoteExecLogFileButton
            // 
            this.RemoteExecLogFileButton.Location = new System.Drawing.Point(14, 137);
            this.RemoteExecLogFileButton.Name = "RemoteExecLogFileButton";
            this.RemoteExecLogFileButton.Size = new System.Drawing.Size(154, 22);
            this.RemoteExecLogFileButton.TabIndex = 0;
            this.RemoteExecLogFileButton.Text = "Select remoteexec.log";
            this.RemoteExecLogFileButton.UseVisualStyleBackColor = true;
            this.RemoteExecLogFileButton.Click += new System.EventHandler(this.RemoteExecLogFileButton_Click);
            // 
            // ServerConsoleLogFileButton
            // 
            this.ServerConsoleLogFileButton.Location = new System.Drawing.Point(14, 165);
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
            this.RemoteExecLogFilePathTextBox.Location = new System.Drawing.Point(174, 141);
            this.RemoteExecLogFilePathTextBox.Name = "RemoteExecLogFilePathTextBox";
            this.RemoteExecLogFilePathTextBox.Size = new System.Drawing.Size(916, 20);
            this.RemoteExecLogFilePathTextBox.TabIndex = 2;
            // 
            // ServerConsoleLogFilePathTextBox
            // 
            this.ServerConsoleLogFilePathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ServerConsoleLogFilePathTextBox.Location = new System.Drawing.Point(174, 167);
            this.ServerConsoleLogFilePathTextBox.Name = "ServerConsoleLogFilePathTextBox";
            this.ServerConsoleLogFilePathTextBox.Size = new System.Drawing.Size(916, 20);
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
            this.ResultOutputTextBox.Location = new System.Drawing.Point(13, 193);
            this.ResultOutputTextBox.Multiline = true;
            this.ResultOutputTextBox.Name = "ResultOutputTextBox";
            this.ResultOutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ResultOutputTextBox.Size = new System.Drawing.Size(1075, 340);
            this.ResultOutputTextBox.TabIndex = 4;
            // 
            // ParseButton
            // 
            this.ParseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ParseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ParseButton.Location = new System.Drawing.Point(13, 539);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(392, 51);
            this.ParseButton.TabIndex = 5;
            this.ParseButton.Text = "Parse ban.txt";
            this.ParseButton.UseVisualStyleBackColor = true;
            this.ParseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // ParseWithComments
            // 
            this.ParseWithComments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ParseWithComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ParseWithComments.Location = new System.Drawing.Point(411, 539);
            this.ParseWithComments.Name = "ParseWithComments";
            this.ParseWithComments.Size = new System.Drawing.Size(418, 51);
            this.ParseWithComments.TabIndex = 6;
            this.ParseWithComments.Text = "Parse ban.txt with comments";
            this.ParseWithComments.UseVisualStyleBackColor = true;
            this.ParseWithComments.Click += new System.EventHandler(this.ParseWithComments_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1007, 539);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Comment string:";
            // 
            // CommentStringTextBox
            // 
            this.CommentStringTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CommentStringTextBox.Location = new System.Drawing.Point(1010, 560);
            this.CommentStringTextBox.Name = "CommentStringTextBox";
            this.CommentStringTextBox.Size = new System.Drawing.Size(79, 20);
            this.CommentStringTextBox.TabIndex = 8;
            this.CommentStringTextBox.Text = "//";
            // 
            // FtpModeRadio
            // 
            this.FtpModeRadio.AutoSize = true;
            this.FtpModeRadio.Location = new System.Drawing.Point(13, 13);
            this.FtpModeRadio.Name = "FtpModeRadio";
            this.FtpModeRadio.Size = new System.Drawing.Size(67, 17);
            this.FtpModeRadio.TabIndex = 9;
            this.FtpModeRadio.TabStop = true;
            this.FtpModeRadio.Text = "Use FTP";
            this.FtpModeRadio.UseVisualStyleBackColor = true;
            this.FtpModeRadio.CheckedChanged += new System.EventHandler(this.FtpModeRadio_CheckedChanged);
            // 
            // FilesModeRadio
            // 
            this.FilesModeRadio.AutoSize = true;
            this.FilesModeRadio.Location = new System.Drawing.Point(13, 114);
            this.FilesModeRadio.Name = "FilesModeRadio";
            this.FilesModeRadio.Size = new System.Drawing.Size(93, 17);
            this.FilesModeRadio.TabIndex = 10;
            this.FilesModeRadio.TabStop = true;
            this.FilesModeRadio.Text = "User local files";
            this.FilesModeRadio.UseVisualStyleBackColor = true;
            this.FilesModeRadio.CheckedChanged += new System.EventHandler(this.FilesModeRadio_CheckedChanged);
            // 
            // FtpUsernameTextBox
            // 
            this.FtpUsernameTextBox.Location = new System.Drawing.Point(411, 10);
            this.FtpUsernameTextBox.Name = "FtpUsernameTextBox";
            this.FtpUsernameTextBox.Size = new System.Drawing.Size(104, 20);
            this.FtpUsernameTextBox.TabIndex = 11;
            // 
            // FtpPasswordTextBox
            // 
            this.FtpPasswordTextBox.Location = new System.Drawing.Point(584, 11);
            this.FtpPasswordTextBox.Name = "FtpPasswordTextBox";
            this.FtpPasswordTextBox.PasswordChar = '*';
            this.FtpPasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.FtpPasswordTextBox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(522, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Password:";
            // 
            // SavePasswordCheckBox
            // 
            this.SavePasswordCheckBox.AutoSize = true;
            this.SavePasswordCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SavePasswordCheckBox.Location = new System.Drawing.Point(521, 38);
            this.SavePasswordCheckBox.Name = "SavePasswordCheckBox";
            this.SavePasswordCheckBox.Size = new System.Drawing.Size(256, 17);
            this.SavePasswordCheckBox.TabIndex = 15;
            this.SavePasswordCheckBox.Text = "Save password (WARNING: Saving in plaintext.)";
            this.SavePasswordCheckBox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Remote exec log FTP directory:";
            // 
            // FtpRemoteExecLogDirectoryTextBox
            // 
            this.FtpRemoteExecLogDirectoryTextBox.Location = new System.Drawing.Point(237, 38);
            this.FtpRemoteExecLogDirectoryTextBox.Name = "FtpRemoteExecLogDirectoryTextBox";
            this.FtpRemoteExecLogDirectoryTextBox.Size = new System.Drawing.Size(278, 20);
            this.FtpRemoteExecLogDirectoryTextBox.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Host:";
            // 
            // FtpHostTextBox
            // 
            this.FtpHostTextBox.Location = new System.Drawing.Point(237, 8);
            this.FtpHostTextBox.Name = "FtpHostTextBox";
            this.FtpHostTextBox.Size = new System.Drawing.Size(104, 20);
            this.FtpHostTextBox.TabIndex = 19;
            // 
            // FtpServerConsoleLogDirectoryTextBox
            // 
            this.FtpServerConsoleLogDirectoryTextBox.Location = new System.Drawing.Point(237, 65);
            this.FtpServerConsoleLogDirectoryTextBox.Name = "FtpServerConsoleLogDirectoryTextBox";
            this.FtpServerConsoleLogDirectoryTextBox.Size = new System.Drawing.Size(278, 20);
            this.FtpServerConsoleLogDirectoryTextBox.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Server console log FTP directory:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 592);
            this.Controls.Add(this.FtpServerConsoleLogDirectoryTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FtpHostTextBox);
            this.Controls.Add(this.FtpRemoteExecLogDirectoryTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SavePasswordCheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FtpPasswordTextBox);
            this.Controls.Add(this.FtpUsernameTextBox);
            this.Controls.Add(this.FilesModeRadio);
            this.Controls.Add(this.FtpModeRadio);
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
            this.Load += new System.EventHandler(this.MainForm_Load);
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
        private System.Windows.Forms.RadioButton FtpModeRadio;
        private System.Windows.Forms.RadioButton FilesModeRadio;
        private System.Windows.Forms.TextBox FtpUsernameTextBox;
        private System.Windows.Forms.TextBox FtpPasswordTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox SavePasswordCheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FtpRemoteExecLogDirectoryTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FtpHostTextBox;
        private System.Windows.Forms.TextBox FtpServerConsoleLogDirectoryTextBox;
        private System.Windows.Forms.Label label6;
    }
}

