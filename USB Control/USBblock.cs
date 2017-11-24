using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USB_Control
{
    public partial class USBblock : Form
    {

        public USBblock()
        {
            InitializeComponent();
          
        }



        public static bool IsAdmin()
        {
            WindowsIdentity id = WindowsIdentity.GetCurrent();
            WindowsPrincipal p = new WindowsPrincipal(id);
            return p.IsInRole(WindowsBuiltInRole.Administrator);
        }

        public void RestartElevated()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.UseShellExecute = true;
            startInfo.CreateNoWindow = true;
            startInfo.WorkingDirectory = Environment.CurrentDirectory;
            startInfo.FileName = System.Windows.Forms.Application.ExecutablePath;
            startInfo.Verb = "runas";
            try
            {
                Process p = Process.Start(startInfo);
            }
            catch
            {

            }

            System.Windows.Forms.Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!IsAdmin())
            {
                button1.Show();
                btnDisable.Hide();
                btnenable.Hide();
            }
            else
            {
                button1.Hide();
                btnenable.Show();
                btnDisable.Show();

            }
        }


      


        private void btnDisable_Click(object sender, EventArgs e)
        {

           
            string path = "SYSTEM\\CurrentControlSet\\services\\USBSTOR\\";
            RegistryKey RK = Registry.LocalMachine.OpenSubKey(path, true);

            RK.SetValue("Start", "4", RegistryValueKind.DWord);
            btnDisable.BackColor = Color.Red;
            btnenable.BackColor = Color.White;
            lblshow.Text = "USB Access Disable";
 

   
          
        }

        private void btnenable_Click(object sender, EventArgs e)
        {

            
           
                string path = "SYSTEM\\CurrentControlSet\\services\\USBSTOR\\";
                RegistryKey RK = Registry.LocalMachine.OpenSubKey(path, true);

                RK.SetValue("Start", "3", RegistryValueKind.DWord);
                btnenable.BackColor = Color.Lime;
                btnDisable.BackColor = Color.White;
                lblshow.Text = "USB Access Enabled";
            
        }
   
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Click(object sender, EventArgs e)
        {
           
            }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!IsAdmin())
            {
                RestartElevated();
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
