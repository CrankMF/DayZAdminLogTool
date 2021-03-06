﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DayZ_Admin_Log_Tool
{
    public static class DayZLogFilesParser
    {
        public static Func<string, bool> IdsLineFilter = (line => line.Contains("connected") && line.Contains("id=") && line.Contains("Player") && !line.Contains("disconnected"));
        public static Func<string, bool> GuidsLineFilter = (line => !line.Contains("BIS_Effects_AirDestruction") && !line.Contains("BIS_Effects_Burn"));

        public static Dictionary<string, PlayerInfo> ParseIdGuidPairs(string remoteExecLog, string serverConsoleLog, string[] ignoredIds)
        {
            var dataCollector = new Dictionary<string, PlayerInfo>();

            CollectIds(dataCollector, serverConsoleLog);
            CollectGuids(dataCollector, remoteExecLog, ignoredIds);

            return dataCollector;
        }

        private static void CollectGuids(Dictionary<string, PlayerInfo> dataCollector, string remoteExecLog, string[] whitelist)
        {
            foreach (var line in remoteExecLog.Split('\n').Where(GuidsLineFilter))
            {
                try
                {
                    var occurenceDate = DateTime.Parse(line.Substring(0, 19));
                    var cropped = line.Substring(21, line.Length - 21);
                    var nick = cropped.Substring(0, cropped.IndexOf(" ("));
                    var guid = cropped.Substring(cropped.IndexOf(" - #") - 32, 32);

                    if (!dataCollector.Keys.Contains(nick))
                    {
                        dataCollector.Add(nick, new PlayerInfo { Guid = guid, UserName = nick, LastOccurence = occurenceDate });
                    }
                    else
                    {
                        var playerData = dataCollector[nick];
                        if (whitelist.Contains(playerData.Id))
                        {
                            continue;
                        }
                        playerData.Guid = guid;
                        dataCollector[nick] = playerData;
                        playerData.LastOccurence = occurenceDate;
                    }
                }
                catch (Exception)
                {
                    //bogus line
                }
            }
        }

        private static void CollectIds(Dictionary<string, PlayerInfo> dataCollector, string serverConsoleLog)
        {
            try
            {
                foreach (var line in serverConsoleLog.Split('\n').Where(IdsLineFilter))
                {
                    var cropped = line.Substring(16, line.Length - 16);
                    var nick = cropped.Substring(0, cropped.LastIndexOf(" connected"));
                    cropped = cropped.Substring(nick.Length);
                    var id = cropped.Substring(cropped.IndexOf("(id=") + 4, cropped.IndexOf(")") - (cropped.IndexOf("(id=") + 4));

                    if (!dataCollector.Keys.Contains(nick))
                    {
                        dataCollector.Add(nick, new PlayerInfo { Id = id, UserName = nick });
                    }
                    else
                    {
                        var playerData = dataCollector[nick];
                        playerData.Id = id;
                        dataCollector[nick] = playerData;
                    }
                }
            }
            catch (Exception)
            {
                //bogus line
            }
        }
    }

    public class PlayerInfo
    {
        public string UserName { get; set; }
        public string Id { get; set; }
        public string Guid { get; set; }
        public DateTime LastOccurence { get; set; }
    }

    public enum LogFilesMode
    {
        FTP, LocalFiles
    }
}
