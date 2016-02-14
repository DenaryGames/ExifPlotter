using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExifPlotter
{
    public partial class MainForm : Form
    {
        private string folderPath = null;
        private bool scanSubFolders = false;
        private PictureFiles picFiles;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            if(folderPath != null)
            {
                folderBrowserDialog1.SelectedPath = folderPath;
            }

            DialogResult result = folderBrowserDialog1.ShowDialog();

            if(result == DialogResult.OK)
            {
                folderPath = folderBrowserDialog1.SelectedPath;
                btnGo.Enabled = true;
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            List<string> selectedFileTypes = new List<string>();
            Util util = new Util();

            if (lbFileTypes.SelectedItems.Count > 0)
            {

                picFiles = util.FindFiles(folderPath, util.GetPattern(lbFileTypes.SelectedItems), chkSubfolders.Checked);
            }
            else
            {
                MessageBox.Show("Please select at least one file type", "Select File Types", MessageBoxButtons.OK);
            }
        }
    }
}
