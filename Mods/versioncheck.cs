using System;
using System.Net.Http;
using System.Threading.Tasks;
using UnityEngine;
using StupidTemplate.Notifications;
using System.Diagnostics;

namespace Zloths_Simple_Menu.Mods
{
    internal class VersionChecker : MonoBehaviour
    {
        private const string versionUrl = "https://raw.githubusercontent.com/ZlothGT/Zloth-Simple-Menu-Version/main/zloth-menu-version.txt";
        private const string currentVersion = "1.0.1";
        private static bool hasRun = false;
        private static bool notificationSent = false;

        private void Start()
        {
            CheckForUpdates();
        }

        public async void CheckForUpdates()
        {
            if (hasRun) return;
            hasRun = true;

            string latestVersion = await GetLatestVersionAsync();
            if (latestVersion != null && latestVersion != currentVersion)
            {
                if (!notificationSent)
                {
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = "https://discord.gg/N9HCctJu2z",
                        UseShellExecute = true
                    });
                    NotifiLib.SendNotification("<color=red>[MENU] - [VERSION]-[ERROR]</color> A new version is available! Please update to version " + latestVersion);
                    notificationSent = true;
                }
            }
            else
            {
                if (!notificationSent)
                {
                    NotifiLib.SendNotification("<color=green>[MENU]-[VERSION]</color> You are using the latest version.");
                    notificationSent = true;
                }
            }
        }

        private async Task<string> GetLatestVersionAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string latestVersion = await client.GetStringAsync(versionUrl);
                    return latestVersion.Trim();
                }
                catch (Exception ex)
                {
                    UnityEngine.Debug.LogError("Error fetching the latest version: " + ex.Message); // Fully qualified UnityEngine.Debug
                    return null;
                }
            }
        }
    }
}
