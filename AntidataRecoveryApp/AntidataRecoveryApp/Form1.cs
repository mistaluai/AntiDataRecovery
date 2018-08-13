using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Diagnostics;
using MetroFramework;

namespace AntidataRecoveryApp
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void GetAllLogicalDrives()
        {
            LogicalDrives.Items.Clear();
            foreach (string LogicDrive in Environment.GetLogicalDrives())
            {
                LogicalDrives.Items.Add(LogicDrive);
            }
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            GetAllLogicalDrives();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetAllLogicalDrives();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {

                if (LogicalDrives.Text != "" || SizeInteger.Text != "")
                {
                    DialogResult = MetroMessageBox.Show(this, "When Starting Process , You can cancel it but you could lose some data", "Warning", MessageBoxButtons.OKCancel);
                    if (DialogResult == DialogResult.OK)
                    {
                        StopButton.Enabled = true;
                        Start.Enabled = false;
                        LogicalDrives.Enabled = false;
                        SizeInteger.Enabled = false;
                        Refresh.Enabled = false;
                        Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\ADRtemp\");
                        File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\ADRtemp\LogicalDrive.temp", LogicalDrives.Text);
                        File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\ADRtemp\SizeInteger.temp", SizeInteger.Text);
                        Process DataDisabler = new Process();
                        File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\ADRtemp\FileRecoveryDisabler.exe", AntidataRecoveryApp.Properties.Resources.FileRecoveryDisabler);
                        string DataKiller = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\ADRtemp\FileRecoveryDisabler.exe";
                        DataDisabler.StartInfo.FileName = DataKiller;
                        DataDisabler.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                        DataDisabler.Start();
                        Loading.Visible = true;
                        ExitWaiter.RunWorkerAsync();
                        ExitWaiter.DoWork += delegate
                    {
                        DataDisabler.WaitForExit();
                        MetroMessageBox.Show(this, "Operation Has Almost done \n Press Ok to close the app", "Done", MessageBoxButtons.OK);
                    };
                        ExitWaiter.RunWorkerCompleted += delegate 
                        {
                            this.Close();
                        };
                        StopButton.Click += delegate
                        {
                            DialogResult = MetroMessageBox.Show(this, "Are You sure that you want to end the process ?", "Question", MessageBoxButtons.YesNo);
                            if (DialogResult == DialogResult.Yes)
                            {
                                try
                                {
                                    DataDisabler.Kill();
                                    DataDisabler.WaitForExit();
                               
                                foreach (string FileElement in Directory.GetFiles(LogicalDrives.Text + @"\Antidatarecoverytemp\"))
                                {
                                    File.Delete(FileElement);
                                }
                                foreach (string FileElement in Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\ADRtemp\"))
                                {
                                    File.Delete(FileElement);
                                }
                                Directory.Delete(LogicalDrives.Text + @"\Antidatarecoverytemp\");
                                Directory.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\ADRtemp\");
                                     }
                                catch (Exception SystemError)
                                {
                                    DialogResult = MetroMessageBox.Show(this, "Unexcpected error happened \n Contact the developer \n Error Details : " + SystemError.Message + "\n Press Ok to copy error informations to send it to the developer", "There Is Error", MessageBoxButtons.OKCancel);
                                    if (DialogResult == DialogResult.OK)
                                    {
                                        Clipboard.SetText(SystemError.Message);
                                    }
                                }
                                Loading.Visible = false;
                                StopButton.Enabled = false;
                                Start.Enabled = true;
                                LogicalDrives.Enabled = true;
                                SizeInteger.Enabled = true;
                                Refresh.Enabled = true;

                            }
                            else
                            {

                            }
                        };

                    }
                    else
                    {

                    }
                }

                else
                {
                    MetroMessageBox.Show(this, "Please Fill The Needed Fields To Start The Operation", "There Is Error", MessageBoxButtons.OK);
                }

            }
            catch (Exception SystemError)
            {
               DialogResult = MetroMessageBox.Show(this, "Unexcpected error happened \n Contact the developer \n Error Details : " + SystemError.Message + "\n Press Ok to copy error informations to send it to the developer", "There Is Error", MessageBoxButtons.OKCancel);
                if (DialogResult == DialogResult.OK)
                {
                    Clipboard.SetText(SystemError.Message);
                }
            }
        }
        void ActivateElements()
        {
           
        }

        private void Loading_Click(object sender, EventArgs e)
        {

        }
    }
}