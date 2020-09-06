using System;
using System.IO;
using System.Net;

namespace HellFire0x_RScripts
{
    internal class Program
    {
        public static string Dir = "RScripts";
        public static string Space = "----------------------------------";

        /// <summary>
        /// Download Function.
        /// </summary>
        /// <param name="URL">File URL</param>
        /// <param name="FileName">File Name</param>
        private static void Download(string URL, string FileName)
        {
            using (WebClient client = new WebClient())
            {
                client.DownloadFile(URL.ToString(), FileName.ToString());
                Console.WriteLine("Downloaded: " + FileName.Replace("RScripts", null));
            }
        }

        /// <summary>
        /// Setup for the Console and files.
        /// </summary>
        /// <param name="Title">Console Title</param>
        /// <param name="DirectoryName">Directory Name</param>
        private static void Setup(string Title, string DirectoryName)
        {
            Console.Title = Title.ToString();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Directory.CreateDirectory(DirectoryName.ToString());
        }

        /// <summary>
        /// Download Lua Files.
        /// </summary>
        private static void Downloader()
        {
            Download(URL: "https://raw.githubusercontent.com/HellFire0x/Big-Brain-Simulator/master/main.lua", FileName: $"{Dir}Big-Brain-Simulator.lua");
            Download(URL: "https://raw.githubusercontent.com/HellFire0x/Blade-Simulator/master/main.lua", FileName: $"{Dir}Blade-Simulator.lua");
            Download(URL: "https://raw.githubusercontent.com/HellFire0x/Coffee-Simulator/master/main.lua", FileName: $"{Dir}Coffee-Simulator.lua");
        }

        /// <summary>
        /// Main instance.
        /// </summary>
        private static void Main()
        {
            Setup(Title: "HellFire0x RScripts", DirectoryName: Dir);
            Console.WriteLine($"Welcome to HellFire0x RScripts\n{Space}\nDir Name: {Dir}\nDir Hash: {Dir.GetHashCode()}\n{Space}\nDownloading Scripts...");
            Downloader();
            Console.WriteLine($"{Space}\nDone Downloading. Files are in {Dir}. Press any key to close.");
            Console.ReadKey();
        }
    }
}