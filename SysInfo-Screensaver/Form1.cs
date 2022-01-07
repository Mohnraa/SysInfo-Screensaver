using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SysInfo_Screensaver;

namespace SysInfo_Screensaver
{
    public partial class mainForm : Form
    {
        WMIC_Interface controller = new WMIC_Interface();
        public mainForm()
        {
            InitializeComponent();
            getInfo();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            getInfo();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = CPUlabel;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            allClear();
        }

        private void allClear()
        {
            CPUtextbox.Clear();
            RAMtextbox.Clear();
            HDDtextbox.Clear();
            GPUtextbox.Clear();
        }

        private void getInfo()
        {
            allClear();
            CPUtextbox.Text = controller.getCPU();
            RAMtextbox.Text = controller.getRAM();
            HDDtextbox.Text = controller.getHDD();
            GPUtextbox.Text = controller.getGPU();
            CPUtextbox.Select(0,0);
        }
    }
}
