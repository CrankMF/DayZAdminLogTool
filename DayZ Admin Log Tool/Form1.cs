using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

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
            var data = ParseWithFiles();

            var textRepresentation = "";

            foreach (var playerInfo in data.Values.Where(playerInfo => !string.IsNullOrWhiteSpace(playerInfo.Guid) && !string.IsNullOrWhiteSpace(playerInfo.Id)).OrderBy(playerInfo => playerInfo.UserName))
            {
                textRepresentation += string.Format("{0}" + Environment.NewLine, playerInfo.Id);

            }

            ResultOutputTextBox.Text = textRepresentation;
            Clipboard.SetText(textRepresentation);

            MessageBox.Show("Love, result in clipboard.");
        }

        private Dictionary<string, PlayerInfo> ParseWithFiles()
        {
            var remoteExecLog = "";
            try
            {
                remoteExecLog = File.ReadAllText(RemoteExecLogFilePathTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot parse remoteExec.log file: " + RemoteExecLogFilePathTextBox.Text);
                return null;
            }

            var serverConsoleLog = "";
            try
            {
                serverConsoleLog = File.ReadAllText(ServerConsoleLogFilePathTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot parse Server_console.log file: " + ServerConsoleLogFilePathTextBox.Text);
                return null;
            }

            return DayZLogFilesParser.ParseIdGuidPairs(remoteExecLog, serverConsoleLog);
        }

        private void ParseWithComments_Click(object sender, EventArgs e)
        {
            var data = ParseWithFiles();

            var textRepresentation = "";

            foreach (var playerInfo in data.Values.Where(playerInfo => !string.IsNullOrWhiteSpace(playerInfo.Guid) && !string.IsNullOrWhiteSpace(playerInfo.Id)).OrderBy(playerInfo => playerInfo.LastOccurence))
            {
                textRepresentation += string.Format("{0} {1} {2} {3} {4}" + Environment.NewLine, playerInfo.Id, CommentStringTextBox.Text, playerInfo.LastOccurence, playerInfo.UserName, playerInfo.Guid);

            }

            ResultOutputTextBox.Text = textRepresentation;
            Clipboard.SetText(textRepresentation);

            MessageBox.Show("Love, result in clipboard.");
        }


    }
}
