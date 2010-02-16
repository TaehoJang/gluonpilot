﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace Gluonpilot
{
    public partial class ConnectDialog : Form
    {
        public string SelectedPort()
        {
            return _cbPorts.SelectedItem.ToString();
        }

        public int SelectedBaudrate()
        {
            return int.Parse(_cbBaud.SelectedItem.ToString());
        }

        public ConnectDialog()
        {
            InitializeComponent();

            foreach (string s in SerialPort.GetPortNames())
            {
                int i = _cbPorts.Items.Add(s);
                if (s == "COM25")
                    _cbPorts.SelectedIndex = i;
            }
            _cbBaud.SelectedIndex = 6;
        }

        private void _btnConnect_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
