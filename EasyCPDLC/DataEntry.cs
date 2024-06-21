﻿/*  EASYCPDLC: CPDLC Client for the VATSIM Network
    Copyright (C) 2021 Joshua Seagrave joshseagrave@googlemail.com

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <https://www.gnu.org/licenses/>.
*/



using System;
using System.Windows.Forms;

namespace EasyCPDLC
{
    public partial class DataEntry : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ReleaseCapture();
        public string HoppieLogonCode { get; set; }
        public int IVAOVid { get; set; }
        public bool Remember { get; set; }
        public DataEntry(object _hoppieLogonCode = null, object _ivaovid = null)
        {
            InitializeComponent();

            try
            {

                if (_hoppieLogonCode is not null)
                {
                    hoppieCodeTextBox.Text = _hoppieLogonCode.ToString();
                }
                else
                {
                    throw new Exception();
                }
                if (_ivaovid is not null)
                {
                    ivaoVIDTextBox.Text = _ivaovid.ToString();
                }
                else
                {
                    throw new Exception();
                }
                rememberCheckBox.Checked = true;
            }

            catch (Exception)
            {
                hoppieCodeTextBox.Text = "";
                ivaoVIDTextBox.Text = "";
                rememberCheckBox.Checked = false;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            try
            {
                HoppieLogonCode = hoppieCodeTextBox.Text;
                IVAOVid = Convert.ToInt32(ivaoVIDTextBox.Text);
                Remember = rememberCheckBox.Checked;

                this.DialogResult = DialogResult.OK;
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid CID/Code, please check and try again.", "Error!", MessageBoxButtons.OK);
            }

        }

        private void HoppieCodeTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (ivaoVIDTextBox.Text.Length < 1 || hoppieCodeTextBox.Text.Length < 1)
                {
                    throw new FormatException();
                }

                Convert.ToInt32(ivaoVIDTextBox.Text);
                connectButton.Enabled = true;

            }
            catch (FormatException)
            {
                connectButton.Enabled = false;
            }
        }

        private void IvaoVidTextBoxTextChanged(object sender, EventArgs e)
        {
            try
            {
                if (ivaoVIDTextBox.Text.Length < 1 || hoppieCodeTextBox.Text.Length < 1)
                {
                    throw new FormatException();
                }

                Convert.ToInt32(ivaoVIDTextBox.Text);
                connectButton.Enabled = true;

            }
            catch (FormatException)
            {
                connectButton.Enabled = false;
            }
        }

        private void DataEntry_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                _ = SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void NumsOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
