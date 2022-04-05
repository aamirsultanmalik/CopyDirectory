using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CopyLib;

namespace CopyDirectory
{
    public partial class Form1 : Form
    {
        string sourcePath = string.Empty;
        string destinationPath = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSource_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            sourcePath = folderBrowserDialog1.SelectedPath;
            txt_source.Text = sourcePath;
        }

        private void btn_destination_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            destinationPath = folderBrowserDialog1.SelectedPath;
            txt_destination.Text = destinationPath;
        }

        private async  void button1_Click(object sender, EventArgs e)
        {
            await CopyTask();
        }
        Task CopyTask()
        {
            return Task.Run(() =>
            {
                //var directories = Directory.GetDirectories(sourcePath);
                //foreach (var sourceSubDir in directories)
                //{
                //    var dirName = new DirectoryInfo(sourceSubDir).Name;
                //    var destinationSubDir = Path.Combine(destinationPath, dirName);
                //    Directory.CreateDirectory(destinationSubDir);
                //    CopyController.CopyLite(sourceSubDir, destinationSubDir);

                //}
                //var files = Directory.GetFiles(sourcePath);

                //foreach (var file in files)
                //{
                //    CopyController.CopyLite(file, destinationPath);
                //    this.current_copy.Text = file;
                //}
                CopyController.Copy(sourcePath, destinationPath);
                SetText(CopyController.currentFileName);
            });
        }
        delegate void SetTextCallback(string text);
        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.current_copy.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.current_copy.Text = text;
            }
        }
    }
}
