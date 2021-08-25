using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CureItImproved
{
    public partial class MainForm : Form
    {
        private Point _mouseOffset;
        private List<DriveInfo> _flashDrives = new List<DriveInfo>();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        
        /// <summary>
        /// Constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            cureBtn.Enabled = false;
            GetRemovableDrives();
        }
        
        /// <summary>
        /// Close button click event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        /// <summary>
        /// Minimize button click event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        
        /// <summary>
        /// On Form Load event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAppLoad(object sender, EventArgs e)
        {
            freeSpace.Value = 0;
            freeSpace.Minimum = 0;
            freeSpace.Maximum = 100;
            freeSpace.SuperscriptText = "_GB";
            UsedSpace.Value = 0;
            UsedSpace.Minimum = 0;
            UsedSpace.Maximum = 100;
            UsedSpace.SuperscriptText = "_GB";
            copyright.Text = "© " + DateTime.Now.Year;
        }
        
        /// <summary>
        /// Method gets all removable drive connected to the computer
        /// </summary>
        private void GetRemovableDrives()
        {
            var driveList = DriveInfo.GetDrives();
            _flashDrives.Clear();
            foreach (DriveInfo drive in driveList)
            {
                if (drive.DriveType == DriveType.Removable && drive.IsReady)
                {
                    _flashDrives.Add(drive);
                    if (!flashList.Items.Contains(drive.RootDirectory.FullName))
                    {
                        flashList.Items.Add(drive.RootDirectory.FullName);
                    }
                }
            }
            dCount.Text = _flashDrives.Count.ToString();
        }
        
        /// <summary>
        /// Cure Button click event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void CureBtn_Click(object sender, EventArgs e)
        {
            cureBtn.Enabled = false;
            procStatus.Text = "Starting....";
            string selected = flashList.SelectedItem.ToString();
            await DriveCleaner.Clean(Directory.GetFiles(selected));
            procStatus.Text = "Done!";
            Console.Beep();
            cureBtn.Enabled = true;
        }
        
        /// <summary>
        /// Credits Label click handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreditsLabel_Click(object sender, EventArgs e)
        {
            Credits creditsWindow = new Credits();
            creditsWindow.Show();
        }
        
        /// <summary>
        /// Detect button click handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetectBtn_Click(object sender, EventArgs e)
        {
            GetRemovableDrives();  
        }
        
        /// <summary>
        /// Handler for Drive selection in combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DriveSelected(object sender, EventArgs e)
        {
            cureBtn.Enabled = true;
            long bytesInGB = 1073741824;
            var driveLet = flashList.SelectedItem.ToString();
            
            DriveInfo drive = _flashDrives.Find(dr => dr.RootDirectory.FullName.Equals(driveLet));
            
            var fullsize = Math.Round((double)drive.TotalSize/bytesInGB,2);
            var free_space = Math.Round((double)drive.AvailableFreeSpace/bytesInGB,2);
            var used_space = fullsize - free_space;
            var freePercent = (int)Math.Round((free_space / fullsize)*100);
            var usedPercent = (int)Math.Round((used_space / fullsize)*100);
            dName.Text = drive.VolumeLabel;
            dSize.Text = fullsize + " GB";
            freeSpace.SuperscriptText = free_space + " GB";
            UsedSpace.SuperscriptText = used_space + " GB";

            DrawAnimateProgress(freePercent, usedPercent);
                      
        }
        
        /// <summary>
        /// Circular progress animation
        /// </summary>
        /// <param name="leftChartValue"></param>
        /// <param name="rightChartValue"></param>
        private void DrawAnimateProgress(int leftChartValue, int rightChartValue)
        {
            for (int i = 0; i <= leftChartValue;i++ )
            {
                Thread.Sleep(5);
                freeSpace.Value = i;
                freeSpace.Update();
            }

            for (int i = 0; i <= rightChartValue; i++)
            {
                Thread.Sleep(5);
                UsedSpace.Value = i;
                UsedSpace.Update();
            }
        }

        /// <summary>
        /// Form drag event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormDrag(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(_mouseOffset.X, _mouseOffset.Y);
                Location = mousePos;
            }
        }
        
        /// <summary>
        /// Mouse down event handler to allow form dragging
        /// </summary>
        /// <param name="e"></param>
        private void HandleMouseDown(MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            HandleMouseDown(e);
        }

        private void HeaderMouseDown(object sender, MouseEventArgs e)
        {
            HandleMouseDown(e);
        }

        private void LogoMouseDown(object sender, MouseEventArgs e)
        {
            HandleMouseDown(e);
        }

        private void TopLableMouseDown(object sender, MouseEventArgs e)
        {
            HandleMouseDown(e);
        }

       
    }
}
