using System;
using System.Threading;
using System.Windows.Forms;

namespace TASumbra
{
    
    public partial class AppGUI : Form
    {
        private FolderBrowserDialog folderBrowserDialog1;
        

        public AppGUI()
        {
            InitializeComponent();
        }

        private void App_Load(object sender, EventArgs e)
        {
            tabControl.Anchor = AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left;
            dataGridView1.TopLeftHeaderCell.Value = "Frame n°";
            dataGridView1.RowHeadersVisible = false;
        }
        
        private void Label1_Click(object sender, EventArgs e)
        {   
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog fileDialog = new OpenFileDialog
            {
                Filter = "Penumbra.exe|Penumbra.exe",
                FilterIndex = 1,
                Multiselect = false,
                Title = "Select the Penumbra executable in your 'Steam/steamapps/common/Penumbra Black Plague' folder"                
            };

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string PenumbraExePath = fileDialog.FileName;
                PenumbraPathTextBox.Text = fileDialog.FileName;
            }
        }

        private void Settings_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
