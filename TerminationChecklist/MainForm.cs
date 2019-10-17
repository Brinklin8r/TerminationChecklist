using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerminationChecklist {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        public string[] _DigitalTestComputers = {
                "10.110.35.10",  // CalCoast
                "10.110.23.10",  // Cornerstone
                "10.110.27.10",  // Finnancial Partners
                "10.110.31.10",  // Inves Tex
                "10.110.21.10",  // Mutual Savings
                "10.110.30.10",  // Nassau
                "10.110.33.10",  // Passadena
                "10.110.28.10",  // Penn East
                "10.110.22.10",  // Popa
                "10.110.20.10",  // Sky One
                "10.110.29.10",  // Space Age
                "10.110.34.10",  // True North
                "10.110.24.10",  // U of K
                "10.110.25.10",  // Whitefish
                "10.110.32.10"}; // Winsouth 

        public string[] _DigitalProductionComputers = {
                "10.110.35.11", "10.110.35.12",
                "10.110.35.13", "10.110.35.14",  // CalCoast
                "10.110.23.11", "10.110.23.12",  // Cornerstone
                "10.110.27.11", "10.110.27.12",  // FFinnancial Partners
                "10.110.31.11", "10.110.31.12",  // Inves Tex
                "10.110.21.11", "10.110.21.12",  // Mutual Savings
                "10.110.30.11", "10.110.30.12",  // Nassau
                "10.110.33.11", "10.110.33.12",  // Passadena
                "10.110.28.11", "10.110.28.12",  // Penn East
                "10.110.22.11", "10.110.22.12",  // Popa
                "10.110.20.11", "10.110.20.12",  // Sky One
                "10.110.29.11", "10.110.29.12",  // Space Age
                "10.110.34.11", "10.110.34.12",  // True North
                "10.110.24.11", "10.110.24.12",  // U of K
                "10.110.25.11", "10.110.25.12",  // Whitefish
                "10.110.32.11", "10.110.32.12"}; // Winsouth

        public string[] _CUCBComputers = {
                "10.110.2.10", "10.110.2.11",    // Infrastructure
                "10.110.8.10", "10.110.8.11",    // ECM
                "10.110.5.10", "10.110.5.12",
                "10.110.5.13", "10.110.5.14",
                "10.110.5.15", "10.110.5.16",
                "10.110.5.18", "10.110.5.19",
                "10.110.5.20",                   // IP
                "10.110.100.20" };               // CAT

        public string[] _LFIComputers = {
                "10.110.5.18", "10.110.5.19",
                "10.110.5.20",                   // IP
                "10.110.100.20" };               // CAT


        private void btnStart_Click(object sender, EventArgs e) {
            List<string> Servers = new List<string>(_CUCBComputers);

            foreach (var server in Servers) {
                rtbOutput.Text += server + "\r\n";
            }

        }
    }
}
