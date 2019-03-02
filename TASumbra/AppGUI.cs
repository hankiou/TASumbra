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
            DataGridView1.TopLeftHeaderCell.Value = "Frame n°";
            //dataGridView1.RowHeadersVisible = false;
            foreach (DataGridViewColumn column in DataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            DataGridView1.RowsAdded += DataGridView1_RowsAdded;
            //DataGridView1.DefaultValuesNeeded += dataGridView1_DefaultValuesNeeded;
            DataGridView1_RowsAdded(null,null);
        }

        private void DataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int lastVal = 0;
            foreach (DataGridViewRow row in DataGridView1.Rows)
            {
                if(row.Cells["FrameNumber"].Value != null)
                {
                    lastVal = int.Parse((string)row.Cells["FrameNumber"].Value);
                }
                else
                {
                    row.Cells["FrameNumber"].Value = ++lastVal;
                }
                row.Cells["MouseX"].Value = "0";
                row.Cells["MouseY"].Value = "0";
            }
        }

        private void DataGridView1__CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            bool validClick = (e.RowIndex != -1 && e.ColumnIndex != -1); //Make sure the clicked row/column is valid.
            var datagridview = sender as DataGridView;

            // Check to make sure the cell clicked is the cell containing the combobox 
            if (datagridview.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn && validClick)
            {
                datagridview.BeginEdit(true);
                ((ComboBox)datagridview.EditingControl).DroppedDown = true;
            }
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
                string penumbraExePath = fileDialog.FileName;
                PenumbraPathTextBox.Text = penumbraExePath;
                RunLauncher.penumbraPath = penumbraExePath;
            }
        }

        private void Settings_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Dabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
