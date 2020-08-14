using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Web;
using System.Windows.Forms;

namespace cmd_gui
{

    public partial class FrmMain : Form
    {
        private class Global
        {
            public static string DisplayText = String.Empty;

        }
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            Global.DisplayText = string.Empty;
            if (!string.IsNullOrEmpty(txtExecutable.Text.Trim()))
            {
                StreamReader outputReader = null;
                StreamReader errorReader = null;

                try
                {
                    BtnStart.Enabled = false;

                    //Create Process Start information
                    ProcessStartInfo processStartInfo =
                        new ProcessStartInfo(txtExecutable.Text.Trim(), txtParameter.Text.Trim())
                        {
                            ErrorDialog = false,
                            UseShellExecute = false,
                            RedirectStandardError = true,
                            RedirectStandardInput = true,
                            RedirectStandardOutput = true
                        };

                    //Execute the process
                    Process process = new Process {StartInfo = processStartInfo};

                    bool processStarted = process.Start();
                    if (processStarted)
                    {
                        //Get the output stream
                        outputReader = process.StandardOutput;
                        errorReader = process.StandardError;
                        //process.WaitForExit();
                        String sb = outputReader.ReadToEnd();
                        //sb.Replace("TCP", "<b>TCP</b>");
                        //Display the result
                        //string displayText = "Output" + Environment.NewLine + "==============" + Environment.NewLine;
                        Global.DisplayText = sb; //outputReader.ReadToEnd();
                        Global.DisplayText += Environment.NewLine + "Error" + Environment.NewLine + "==============" +
                                              Environment.NewLine;
                        Global.DisplayText += errorReader.ReadToEnd();
                        string demo = TextToHtml(Global.DisplayText);
                        demo = Regex.Replace(demo, "TCP", "<b>TCP</b>");
                        demo = Regex.Replace(demo, "ESTABLISHED", "<span style='color: green; '>ESTABLISHED</span>");
                        demo = Regex.Replace(demo, "LISTENING", "<span style='color: yellow; '>LISTENING</span>");
                        demo = Regex.Replace(demo, "CLOSE_WAIT", "<span style='color: red; '>CLOSE_WAIT</span>");
                        demo = Regex.Replace(demo, "TIME_WAIT", "<span style='color: red; '>TIME_WAIT</span>");
                        demo = Regex.Replace(demo, ":443 ", "<span style='color: red; '>:443 </span>");
                        demo = Regex.Replace(demo, ":80 ", "<span style='color:DD5A0B; '>:80 </span>");
                        demo = Regex.Replace(demo, ":22 ", "<span style='color:#9928E7; '>:22 </span>");
                        webBrowser1.DocumentText = demo;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    outputReader?.Close();
                    errorReader?.Close();
                    BtnStart.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show(@"Please select executable.");
            }
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDlg = new OpenFileDialog
            {
                Multiselect = false, Filter = @"Executables|*.exe|All Files |*.*", 
                Title = @"Open executable to run"
            };
            if (openDlg.ShowDialog() == DialogResult.OK)
            {
                txtExecutable.Text = openDlg.FileName;
            }

        }

        private static string TextToHtml(string text)
        {
            text = HttpUtility.HtmlEncode(text);
            text = text.Replace("\r\n", "\r");
            text = text.Replace("\n", "\r");
            text = text.Replace("\r", "<br>\r\n");
            text = text.Replace("  ", " &nbsp;");
            return text;
        }
        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Global.DisplayText))
            {
                Clipboard.SetText(Global.DisplayText);
            }
        }

        private void txtExecutable_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


