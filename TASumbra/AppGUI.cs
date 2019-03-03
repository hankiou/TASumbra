using System;
using System.Threading;
using System.Windows.Forms;

namespace TASumbra
{
    
    public partial class AppGUI : Form
    {
        bool runStarted = false;

        public AppGUI()
        {
            InitializeComponent();
        }

        private void App_Load(object sender, EventArgs e)
        {
            tabControl.Anchor = AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left;
            dataGridView1.TopLeftHeaderCell.Value = "Frame n°";
            //dataGridView1.RowHeadersVisible = false;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dataGridView1.RowsAdded += DataGridView1_RowsAdded;
            //DataGridView1.DefaultValuesNeeded += dataGridView1_DefaultValuesNeeded;
            DataGridView1_RowsAdded(null,null);
        }

        private void DataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int lastVal = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if(row.Cells["FrameNumber"].Value != null)
                {
                    lastVal = int.Parse(row.Cells["FrameNumber"].Value.ToString());
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
                PenumbraPathTextBox.Text = fileDialog.FileName;
            }
        }

        private void Settings_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TimeText_Click(object sender, EventArgs e)
        {

        }

        private void GetTime_Click(object sender, EventArgs e)
        {
            if (!runStarted)
            {
                runStarted = true;
                RunLauncher runLauncher = new RunLauncher(PenumbraPathTextBox.Text,penumbraTimeText);
                runLauncher.Start();
                
            }
             //penumbraTimeText.Text = MemoryReader.ReadPenumbraMemory().ToString();
        }
    }
}
