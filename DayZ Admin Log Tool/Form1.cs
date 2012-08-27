using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using dayztool.Properties;

namespace DayZ_Admin_Log_Tool
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void RemoteExecLogFileButton_Click(object sender, EventArgs e)
        {
            // Show the dialog and get result.
            DialogResult result = RemoteExecLogFileOpenFileDialog.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                RemoteExecLogFilePathTextBox.Text = RemoteExecLogFileOpenFileDialog.FileName;
            }
            
        }

        private void ServerConsoleLogFileButton_Click(object sender, EventArgs e)
        {
            // Show the dialog and get result.
            DialogResult result = ServerConsoleLogFileOpenFileDialog.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                ServerConsoleLogFilePathTextBox.Text = ServerConsoleLogFileOpenFileDialog.FileName;
            }
            
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            if (ResultOutputTextBox.Enabled)
            {
                ParseWork.RunWorkerAsync();
            }
        }

        private Dictionary<string, PlayerInfo> ParseWithFiles()
        {
            var ignoredIds = WhiteListTextBox.Text.Split('.').ToArray();
            var remoteExecFilePath = RemoteExecLogFilePathTextBox.Text;
            var serverConsoleFilePath = ServerConsoleLogFilePathTextBox.Text;

            if (Settings.Default.SelectedMode == "FTP")
            {
                if(!DownloadFilesFromFtp())
                    return null;
                remoteExecFilePath = "remoteexec.log";
                serverConsoleFilePath = "server_console.log";
            }
            var remoteExecLog = "";
            try
            {
                remoteExecLog = File.ReadAllText(remoteExecFilePath);
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot parse remoteExec.log file: " + RemoteExecLogFilePathTextBox.Text);
                return null;
            }

            var serverConsoleLog = "";
            try
            {
                serverConsoleLog = File.ReadAllText(serverConsoleFilePath);
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot parse Server_console.log file: " + ServerConsoleLogFilePathTextBox.Text);
                return null;
            }

            return DayZLogFilesParser.ParseIdGuidPairs(remoteExecLog, serverConsoleLog, ignoredIds);
        }

        private bool DownloadFilesFromFtp()
        {
            var request = new WebClient();
            request.Credentials = new NetworkCredential(FtpUsernameTextBox.Text, FtpPasswordTextBox.Text);

            try
            {
                var remoteExecUri = "ftp://" + FtpHostTextBox.Text + (FtpRemoteExecLogDirectoryTextBox.Text.StartsWith("/") ? "" : "/") + FtpRemoteExecLogDirectoryTextBox.Text + (FtpRemoteExecLogDirectoryTextBox.Text.EndsWith("/") ? "" : "/") + "remoteexec.log";
                request.DownloadFile(remoteExecUri, "remoteexec.log");
                var serverConsoleExecUri = "ftp://" + FtpHostTextBox.Text + (FtpServerConsoleLogDirectoryTextBox.Text.StartsWith("/") ? "" : "/") + FtpServerConsoleLogDirectoryTextBox.Text + (FtpRemoteExecLogDirectoryTextBox.Text.EndsWith("/") ? "" : "/") + "server_console.log";
                request.DownloadFile(serverConsoleExecUri, "server_console.log");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }

        private void ParseWithComments_Click(object sender, EventArgs e)
        {
            if (ResultOutputTextBox.Enabled)
            {
                ParseWithCommentsWork.RunWorkerAsync();
            }
        }

        private void DisplayResult(string textRepresentation)
        {
            ResultOutputTextBox.Invoke(new UpdateTextCallback(this.UpdateText),
            new object[] { textRepresentation });


        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SavePasswordCheckBox.Checked = Settings.Default.SavePassword;
            FtpUsernameTextBox.Text = Settings.Default.FtpUser;
            FtpPasswordTextBox.Text = Settings.Default.FtpPassword;
            FtpRemoteExecLogDirectoryTextBox.Text = Settings.Default.FtpRemoteExecLogFilePath;
            FtpHostTextBox.Text = Settings.Default.FtpHost;

            RemoteExecLogFilePathTextBox.Text = Settings.Default.RemoteExecLogFilePath;
            ServerConsoleLogFilePathTextBox.Text = Settings.Default.ServerConsoleLogFilePath;

            FtpRemoteExecLogDirectoryTextBox.Text = Settings.Default.FtpRemoteExecLogFilePath;
            FtpServerConsoleLogDirectoryTextBox.Text = Settings.Default.FtpServerConsoleLogFilePath;

            WhiteListTextBox.Text = Settings.Default.WhiteList;

            FtpModeRadio.Select();
            if (Settings.Default.SelectedMode == "LocalFiles")
            {
                FilesModeRadio.Select();
            }
        }

        private void SaveSettings()
        {
            Settings.Default.FtpUser = FtpUsernameTextBox.Text;
            Settings.Default.FtpPassword = FtpPasswordTextBox.Text;
            Settings.Default.FtpRemoteExecLogFilePath = FtpRemoteExecLogDirectoryTextBox.Text;
            Settings.Default.FtpHost = FtpHostTextBox.Text;

            Settings.Default.FtpRemoteExecLogFilePath = FtpRemoteExecLogDirectoryTextBox.Text;
            Settings.Default.FtpServerConsoleLogFilePath = FtpServerConsoleLogDirectoryTextBox.Text;

            Settings.Default.RemoteExecLogFilePath = RemoteExecLogFilePathTextBox.Text;
            Settings.Default.ServerConsoleLogFilePath = ServerConsoleLogFilePathTextBox.Text;
            Settings.Default.SavePassword = SavePasswordCheckBox.Checked;

            Settings.Default.WhiteList = WhiteListTextBox.Text;

            Settings.Default.Save();
        }

        private void FtpModeRadio_CheckedChanged(object sender, EventArgs e)
        {
            RemoteExecLogFilePathTextBox.Enabled = false;
            RemoteExecLogFileButton.Enabled = false;
            ServerConsoleLogFilePathTextBox.Enabled = false;
            ServerConsoleLogFileButton.Enabled = false;

            FtpUsernameTextBox.Enabled = true;
            FtpPasswordTextBox.Enabled = true;
            FtpRemoteExecLogDirectoryTextBox.Enabled = true;
            Settings.Default.SelectedMode = "FTP";
            Settings.Default.Save();
        }

        private void FilesModeRadio_CheckedChanged(object sender, EventArgs e)
        {
            RemoteExecLogFilePathTextBox.Enabled = true;
            RemoteExecLogFileButton.Enabled = true;
            ServerConsoleLogFilePathTextBox.Enabled = true;
            ServerConsoleLogFileButton.Enabled = true;

            FtpUsernameTextBox.Enabled = false;
            FtpPasswordTextBox.Enabled = false;
            FtpRemoteExecLogDirectoryTextBox.Enabled = false;
            Settings.Default.SelectedMode = "Local";
            Settings.Default.Save();
        }

        private void ParseWork_DoWork(object sender, DoWorkEventArgs e)
        {
            var data = ParseWithFiles();
            if (data == null)
            {
                MessageBox.Show("Something is wrong, cannot parse files.");
                return;
            }
            var textRepresentation = "";
            var whitelist = WhiteListTextBox.Text.Split(',');
            var sorted = data.Values.Where(playerInfo => !string.IsNullOrWhiteSpace(playerInfo.Guid) && !string.IsNullOrWhiteSpace(playerInfo.Id)).OrderBy(playerInfo => playerInfo.LastOccurence);
            foreach (var playerInfo in sorted)
            {
                if (!whitelist.Contains(playerInfo.Id))
                {
                    textRepresentation += string.Format("{0}" + Environment.NewLine, playerInfo.Id);
                }

            }

            DisplayResult(textRepresentation);
            
        }

        private void ParseWithCommentsWork_DoWork(object sender, DoWorkEventArgs e)
        {
            var data = ParseWithFiles();
            if (data == null)
            {
                MessageBox.Show("Something is wrong, cannot parse files.");
                return;
            }

            var textRepresentation = "";
            var whitelist = WhiteListTextBox.Text.Split(',');
            var sorted = data.Values.Where(playerInfo => !string.IsNullOrWhiteSpace(playerInfo.Guid) && !string.IsNullOrWhiteSpace(playerInfo.Id)).OrderBy(playerInfo => playerInfo.LastOccurence);
            foreach (var playerInfo in sorted)
            {
                if (!whitelist.Contains(playerInfo.Id))
                {
                    textRepresentation += string.Format("{0} {1} {2} {3} {4}" + Environment.NewLine, playerInfo.Id, CommentStringTextBox.Text, playerInfo.LastOccurence, playerInfo.UserName, playerInfo.Guid);
                }

            }

            DisplayResult(textRepresentation);

        }

        private void UpdateText(string textRepresentation)
        {
            // Set the textbox text.
            ResultOutputTextBox.Text = textRepresentation;

            if (!string.IsNullOrEmpty(textRepresentation))
            {
                Clipboard.SetText(textRepresentation);

                MessageBox.Show("Love, result in clipboard.");
                SaveSettings();
            }
            else
            {
                MessageBox.Show("Something is wrong, no output available, or no cheaters in logs. :-D");
            }
        }

        public delegate void UpdateTextCallback(string textRepresentation);

    }
}
