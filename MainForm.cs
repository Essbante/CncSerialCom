using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CncSerialCom
{
    public partial class MainForm : Form
    {

        delegate void AppendTextCallback(string text);

        private void AppendText(string text)
        {
            if (this.textBox.InvokeRequired)
            {
                AppendTextCallback d = new AppendTextCallback(AppendText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                text.Replace("\r\n", "\n");
                this.textBox.AppendText(text);
                rxString = String.Empty;

                if (sendingFile && !cbPause.Checked)
                {
                    SendFileLine();
                }
            }
        }

        private void SendLine(string line)
        {
            try
            {
                if (line.Trim() != "")
                {
                    textBox.AppendText(">> " + line + "\n");
                    textBox.ScrollToCaret();
                    serialPort.Write(line + "\r");
                }
            }
            catch (SystemException)
            {
                MessageBox.Show("Unable to send line: " + line);
            }
        }

        private void ManualMove(String axis)
        {
            String line;

            decimal xyVal = nudXY.Value;

            decimal zVal = nudZ.Value;

            if (rbSeek.Checked)
            {
                line = "G0 ";
            }
            else if (rbLinear.Checked)
            {
                line = "G1 ";
            }
            else
            {
                line = "error";
            }

            switch (axis)
            {
                case "X-Y-":
                    line += "X-" + xyVal + " Y-" + xyVal;
                    break;
                case "X-":
                    line += "X-" + xyVal;
                    break;
                case "X-Y":
                    line += "X-" + xyVal + " Y" + xyVal;
                    break;
                case "Y-":
                    line += "Y-" + xyVal;
                    break;
                case "Y":
                    line += "Y" + xyVal;
                    break;
                case "XY-":
                    line += "X" + xyVal + " Y-" + xyVal;
                    break;
                case "X":
                    line += "X" + xyVal;
                    break;
                case "XY":
                    line += "X" + xyVal + " Y" + xyVal;
                    break;
                case "Z":
                    line += "Z" + zVal;
                    break;
                case "Z-":
                    line += "Z-" + zVal;
                    break;
            }
            SendLine(line);
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.Open();

                serialPort.Write("$\r\n");

                lblConnectedSts.Text = serialPort.PortName;

                splitContainer.Enabled = true;

                toolStrip.Enabled = true;

            }
            catch (SystemException)
            {
                MessageBox.Show("Unable to open port: " + serialPort.PortName);
            }
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.Close();

                lblConnectedSts.Text = "No";

                splitContainer.Enabled = false;

                toolStrip.Enabled = false;
            }
            catch (SystemException)
            {
                MessageBox.Show("Unable to close port: " + serialPort.PortName);
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                serialPort.Close();
            }
            catch (SystemException)
            {
                MessageBox.Show("Unable to close port: " + serialPort.PortName);
            }
        }

        private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                rxString += serialPort.ReadExisting();

                if (rxString.EndsWith("\r\n"))
                {
                    AppendText(rxString);
                }
            }
            catch (SystemException)
            {
                MessageBox.Show("Error reading port: " + serialPort.PortName);
            }
        }

        private void rbInch_CheckedChanged(object sender, EventArgs e)
        {
            if (rbInch.Checked)
            {
                SendLine("G20");
            }
        }

        private void rbMM_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMM.Checked)
            {
                SendLine("G21");
            }
        }

        private void rbAbsolute_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAbsolute.Checked)
            {
                SendLine("G90");
            }
        }

        private void rbRelative_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRelative.Checked)
            {
                SendLine("G91");
            }
        }

        private void rbXY_CheckedChanged(object sender, EventArgs e)
        {
            if (rbXY.Checked)
            {
                SendLine("G17");
            }
        }

        private void rbXZ_CheckedChanged(object sender, EventArgs e)
        {
            if (rbXZ.Checked)
            {
                SendLine("G18");
            }
        }

        private void rbYZ_CheckedChanged(object sender, EventArgs e)
        {
            if (rbYZ.Checked)
            {
                SendLine("G19");
            }
        }

        private void rbInverse_CheckedChanged(object sender, EventArgs e)
        {
            if (rbInverse.Checked)
            {
                SendLine("G93");
            }
        }

        private void rbUPM_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUPM.Checked)
            {
                SendLine("G94");
            }
        }

        private void btnXsubYsub_Click(object sender, EventArgs e)
        {
            ManualMove("X-Y-");
        }

        private void btnXsub_Click(object sender, EventArgs e)
        {
            ManualMove("X-");
        }

        private void btnXsubYadd_Click(object sender, EventArgs e)
        {
            ManualMove("X-Y");
        }

        private void btnZadd_Click(object sender, EventArgs e)
        {
            ManualMove("Z");
        }

        private void btnYsub_Click(object sender, EventArgs e)
        {
            ManualMove("Y-");
        }

        private void btnYadd_Click(object sender, EventArgs e)
        {
            ManualMove("Y");
        }

        private void btnXaddYsub_Click(object sender, EventArgs e)
        {
            ManualMove("XY-");
        }

        private void btnXadd_Click(object sender, EventArgs e)
        {
            ManualMove("X");
        }

        private void btnXaddYAdd_Click(object sender, EventArgs e)
        {
            ManualMove("XY");
        }

        private void btnZsub_Click(object sender, EventArgs e)
        {
            ManualMove("Z-");
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 0)
            {
                gbDistance.Enabled = true;
            }
            else if (tabControl.SelectedIndex == 1)
            {
                rbRelative.Checked = true;
                gbDistance.Enabled = false;
            }

        }

        private void tabControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (tabControl.SelectedIndex == 1)
            {
                switch (e.KeyCode)
                {
                    case Keys.Q:
                        ManualMove("X-Y-");
                        break;
                    case Keys.W:
                        ManualMove("X-");
                        break;
                    case Keys.E:
                        ManualMove("X-Y");
                        break;
                    case Keys.F:
                        ManualMove("Z-");
                        break;
                    case Keys.A:
                        ManualMove("Y-");
                        break;
                    case Keys.D:
                        ManualMove("Y");
                        break;
                    case Keys.Z:
                        ManualMove("XY-");
                        break;
                    case Keys.X:
                        ManualMove("X");
                        break;
                    case Keys.C:
                        ManualMove("XY");
                        break;
                    case Keys.R:
                        ManualMove("Z");
                        break;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox.Clear();
            textBox.ScrollToCaret();
        }

        private void btnGoHome_Click(object sender, EventArgs e)
        {
            SendLine("G0 X0 Y0 Z0");
        }

        private void btnSetHome_Click(object sender, EventArgs e)
        {
            SendLine("G92 X0 Y0 Z0");
        }

        private void displaySettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendLine("$");
        }

        private void tabControl_Leave(object sender, EventArgs e)
        {
            tableLayoutPanel.BackColor = Color.Salmon;
            lblHotkeysSts.Text = "Disabled";
        }

        private void tabControl_Enter(object sender, EventArgs e)
        {
            tableLayoutPanel.BackColor = Color.LightGreen;
            lblHotkeysSts.Text = "Enabled";
        }

        private void txtSeekRate_DoubleClick(object sender, EventArgs e)
        {
            SendLine("$5=" + txtSeekRate.Text);
        }

        private void txtFeedRate_DoubleClick(object sender, EventArgs e)
        {
            SendLine("$4=" + txtFeedRate.Text);
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "G-code Files(*.CNC;*.NC;*.TAP;*.TXT)|" +
                                    "*.CNC;*.NC;*.TAP;*.TXT|" +
                                    "All files (*.*)|" +
                                    "*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                String file = openFileDialog.FileName;


                if (File.Exists(file))
                {
                    using (StreamReader sr = new StreamReader(file))
                    {
                        string line = String.Empty;
                        int lines = 0;

                        while ((line = sr.ReadLine()) != null)
                        {
                            if (line.Trim() != "")
                                lines++;
                        }
                        SentLines = 0;
                        FileLines = lines;
                        pbProgress.Value = 0;
                        pbProgress.Minimum = 0;
                        pbProgress.Maximum = lines;                        
                        sr.Close();
                    }
                    txtFile.Text = file;
                }
                else
                {
                    MessageBox.Show("Unable to open file: \n" + file);
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog();
        }

        private void btnSendFile_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(txtFile.Text))
            {
                streamReader = new System.IO.StreamReader(txtFile.Text);
                sendingFile = true;
                btnSendFile.Enabled = false;
                SendFileLine();
            }
            else
            {
                MessageBox.Show("Unable to open file: \n" + txtFile.Text);
            }
        }

        private void SendFileLine()
        {
            try
            {
                if (SentLines < FileLines)
                {
                    String line = streamReader.ReadLine();
                    SendLine(line.Trim());
                    pbProgress.Value += 1;
                    pbProgress.Value -= 1;
                    pbProgress.Value += 1;
                    SentLines += 1;
                }
                else
                {
                    MessageBox.Show("File send successfully.");
                    sendingFile = false;
                    streamReader.Close();
                    SentLines = 0;
                    pbProgress.Value = 0;
                    btnSendFile.Enabled = true;
                }
            }
            catch (SystemException)
            {
                MessageBox.Show("Error ");
            }
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void txtCommand_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendLine(txtCommand.Text);
                txtCommand.Text = String.Empty;
            }
        }

        private void cbPause_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPause.Checked)
            {
                cbPause.Text = "Resume";
            }
            else
            {
                cbPause.Text = "Pause";
                if (sendingFile)
                {
                    SendFileLine();
                }
            }
        }

        private void btnStopFile_Click(object sender, EventArgs e)
        {
            sendingFile = false;
            btnSendFile.Enabled = true;
            cbPause.Checked = false;
            pbProgress.Value = 0;
            SentLines = 0;            
        }

        private void txtSeekRate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendLine("$5=" + txtSeekRate.Text);
                txtSeekRate.Text = String.Empty;
            }
        }

        private void txtFeedRate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendLine("$4=" + txtFeedRate.Text);
                txtFeedRate.Text = String.Empty;
            }
        }
    }
}
