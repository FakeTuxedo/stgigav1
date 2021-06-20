using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Net;
using CSCore.CoreAudioAPI;
using NAudio.Wave;
using System.Globalization;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Diagnostics;
namespace stmegatest
{
    public partial class Form1 : Form
    {
        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;
        public string lowdir;
        public string vlowdir;
        public string middir;
        public string highdir;
        public string vhighdir;
        string JSONOutput;
        bool iferror;

        public Form1()
        {
            InitializeComponent();
        }

        // Gets the default device for the system
        public static MMDevice GetDefaultRenderDevice()
        {
            using (var enumerator = new MMDeviceEnumerator())
            {
                return enumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Console);
            }
        }

        // Checks if audio is playing on a certain device
        public static bool IsAudioPlaying(MMDevice device)
        {
            using (var meter = AudioMeterInformation.FromDevice(device))
            {
                return meter.PeakValue > 0;
            }
        }
        private void OnPlaybackStopped(object sender, StoppedEventArgs args)
        {
            outputDevice.Dispose();
            outputDevice = null;
            audioFile.Dispose();
            audioFile = null;
        }
        private decimal GetLevel()
        {   //sends json request with variables from gui                        
            JSONOutput = new WebClient().DownloadString("https://api.tidesandcurrents.noaa.gov/api/prod/datagetter?date=latest&station=" + StationID.Text +
            "&product=water_level&datum=" + Datum.Text + "&units=" + Units.SelectedItem + "&time_zone=gmt&application=web_services&format=JSON");
            //filters to get the water level
            int startPos = JSONOutput.LastIndexOf(@"""v"":""") + @"""v"":""".Length;
            int length = JSONOutput.IndexOf(@""", ""s""") - startPos;
            string lvl = JSONOutput.Substring(startPos, length);
            decimal lvldec = Math.Round(decimal.Parse(lvl, NumberStyles.AllowDecimalPoint), 2);
            return lvldec;           
        }

        //Opens Dialog
        public void button4_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = "C:\\Users";
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                 vhighdir = dialog.FileName;
            }
        }
        //Opens Dialog
        public void button3_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = "C:\\Users";
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                highdir = dialog.FileName;
            }
        }
        //Opens Dialog
        public void button2_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = "C:\\Users";
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                middir = dialog.FileName;
            }
        }
        //Opens Dialog
        public void button6_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = "C:\\Users";
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                lowdir = dialog.FileName;
            }
        }
        //Opens Dialog
        public void button7_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = "C:\\Users";
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                vlowdir = dialog.FileName;
            }
        }
        public static void GoToSite(string url)
        {
            bool isaudio = IsAudioPlaying(GetDefaultRenderDevice());
            if (isaudio == false)
            {
                SendKeys.Send(" ");
                Process.Start("cmd", "/c start " + url);
                Thread.Sleep(5000);
                SendKeys.Send(" ");
            }

        }
        
        public void button1_Click(object sender, EventArgs e)
        {
        Start:
                try
                {
                    //rounds and assigns levels based on GUI input
                    decimal Vhighh = Math.Round(decimal.Parse(vfasth.Text, NumberStyles.AllowDecimalPoint), 2);
                    decimal Highh = Math.Round(decimal.Parse(fasth.Text, NumberStyles.AllowDecimalPoint), 2);
                    decimal Midh = Math.Round(decimal.Parse(midh.Text, NumberStyles.AllowDecimalPoint), 2);
                    decimal Lowh = Math.Round(decimal.Parse(slowh.Text, NumberStyles.AllowDecimalPoint), 2);
                    decimal Vlowh = Math.Round(decimal.Parse(vslowh.Text, NumberStyles.AllowDecimalPoint), 2);
                    //checks levels and plays appropriate audio files

                    //if level very high                   
                    if (GetLevel() >= Vhighh) //GetLevel() sends a JSON request and retrives a number every time it is called
                    {
                    if (vhighlnk.Text != "")
                    {
                        GoToSite(vhighlnk.Text);
                    }
                    else
                    {
                        // List of files from directory
                        string[] filePaths = Directory.GetFiles(vhighdir);
                        // Random number from 0 to the amount of files you have
                        Random rnd = new Random(Guid.NewGuid().GetHashCode());
                        int choices = rnd.Next(filePaths.Length);
                        using (var output = new WaveOutEvent())
                        using (var player = new AudioFileReader(filePaths[choices]))
                        {
                            output.Init(player);
                            output.Play();
                            while (output.PlaybackState == PlaybackState.Playing)
                            {
                                Thread.Sleep(500);
                            }
                        }
                    }
                    }
                    //if level high
                    if (GetLevel() >= Highh && GetLevel() < Vhighh)
                    {
                    if (highlnk.Text != "")
                    {
                        
                          GoToSite(highlnk.Text);
                     
                    }
                    else
                    {
                        // List of files from directory
                        string[] filePaths = Directory.GetFiles(highdir);
                        // Random number from 0 to the amount of files you have
                        Random rnd = new Random(Guid.NewGuid().GetHashCode());
                        int choices = rnd.Next(filePaths.Length);


                        using (var output = new WaveOutEvent())
                        using (var player = new AudioFileReader(filePaths[choices]))
                        {
                            output.Init(player);
                            output.Play();
                            while (output.PlaybackState == PlaybackState.Playing)
                            {
                                Thread.Sleep(500);
                            }
                        }
                    }
                    }
                    //if level mid
                    if (GetLevel() >= Midh && GetLevel() < Highh)
                    {
                    if (midlnk.Text != "")
                    {
                          GoToSite(midlnk.Text);
                    }
                    else
                    {
                        // List of files from directory
                        string[] filePaths = Directory.GetFiles(middir);
                        // Random number from 0 to the amount of files you have
                        Random rnd = new Random(Guid.NewGuid().GetHashCode());
                        int choices = rnd.Next(filePaths.Length);
                        using (var output = new WaveOutEvent())
                        using (var player = new AudioFileReader(filePaths[choices]))
                        {
                            output.Init(player);
                            output.Play();
                            while (output.PlaybackState == PlaybackState.Playing)
                            {
                                Thread.Sleep(500);
                            }
                        }
                    }
                    }
                    //if water level low
                    if (GetLevel() >= Lowh && GetLevel() < Midh)
                    {
                    if (lowlnk.Text != "")
                    {
                        GoToSite(lowlnk.Text);
                    }
                    else
                    {
                        // List of files from directory
                        string[] filePaths = Directory.GetFiles(lowdir);
                        // Random number from 0 to the amount of files you have
                        Random rnd = new Random(Guid.NewGuid().GetHashCode());
                        int choices = rnd.Next(filePaths.Length);
                        using (var output = new WaveOutEvent())
                        using (var player = new AudioFileReader(filePaths[choices]))
                        {
                            output.Init(player);
                            output.Play();
                            while (output.PlaybackState == PlaybackState.Playing)
                            {
                                Thread.Sleep(500);
                            }
                        }
                    }
                    }
                //if level very low
                if (GetLevel() <= Vlowh)
                {
                    if (vlowlnk.Text != "")
                    {
                        GoToSite(vlowlnk.Text);
                    }
                    else
                    {
                        // List of files from directory,
                        string[] filePaths = Directory.GetFiles(vlowdir);
                        // Random number from 0 to the amount of files you have
                        Random rnd = new Random(Guid.NewGuid().GetHashCode());
                        int choices = rnd.Next(filePaths.Length);
                        using (var output = new WaveOutEvent())
                        using (var player = new AudioFileReader(filePaths[choices]))
                        {
                            output.Init(player);
                            output.Play();
                            while (output.PlaybackState == PlaybackState.Playing)
                            {
                                Thread.Sleep(500);
                            }
                        }
                    }
                }
                }
                catch(Exception)
                {
                    MessageBox.Show("There was an issue playing audio, check if you have selected all directories, or properly formatted your URL's", "Error", MessageBoxButtons.OK);
                iferror = true;


                }
            if (iferror == false)
            {
                goto Start;
            }         
            }
        }
    }  
    