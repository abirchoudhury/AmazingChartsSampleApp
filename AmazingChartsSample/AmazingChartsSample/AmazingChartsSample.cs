namespace AmazingChartsSample
{
    public partial class AmazingChartsSample : Form
    {
		//Author: Abir Choudhury 
		//Date: 25/05/2022
        public dsContacts _dsContacts;
		private string localFilePath = @"C:\Users\beerw\OneDrive\Desktop\AmazingChartsSampleApp\AmazingChartsSample\AmazingChartsSample\contacts.xml";
		//TODO: Change the file path above and on line 53 to test locally 

		public AmazingChartsSample()
        {
            InitializeComponent();
			//initialize new dsContact and read xml from localFilePath
            _dsContacts = new();
			_dsContacts.ReadXml(localFilePath);
		}

		private void btnGetContacts_Click(object sender, EventArgs e)
		{
			//setup data grid view and set data source to dsContacts dataset
			dataGridView1.Refresh();
			dataGridView1.DataSource = _dsContacts;
			dataGridView1.DataMember = "contact";
			SetupDataGridView();                        
		}
		
		private void btnAddNewContact_Click(object sender, EventArgs e)
		{
			//Opens a add contact form by passing in the dataset
            AddContactForm addContactForm = new AddContactForm(_dsContacts);
            addContactForm.ShowDialog();
		}

		/// <summary>
		/// Sets the datagridview formatting
		/// </summary>
		private void SetupDataGridView()
		{
			
			dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);
			dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single;
			dataGridView1.GridColor = Color.Black;
			dataGridView1.AutoSize = true;
			dataGridView1.MultiSelect = false;

		}

		/// <summary>
		/// Saves the dataset to a new XML file.
		/// </summary>
		/// <param name="ds"></param>
		public static void Save(dsContacts ds)
		{
			
			//Write the contents to EventLog
			using (var eventLog = new System.Diagnostics.EventLog("Application"))
			{
				eventLog.Source = "Application";
				eventLog.WriteEntry(ds.GetXml(), System.Diagnostics.EventLogEntryType.Information, 101, 1);
			}
			ds.GetXml();
			//Using guid to ensure new file will be created per the requirement documentation.
			ds.WriteXml(string.Format(@"C:\Users\beerw\OneDrive\Desktop\AmazingChartsSampleApp\AmazingChartsSample\AmazingChartsSample\contacts{0}.xml",Guid.NewGuid().ToString()));
			//TODO: change above path to test locally.
		}

		private void btnDeleteContact_Click(object sender, EventArgs e)
		{
			//Get the selected row
			var selectedRow = dataGridView1.SelectedRows;
			if (selectedRow != null && selectedRow.Count > 0)
			{
				DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this row?", "Confirm Delete", MessageBoxButtons.YesNoCancel);
				if (dialogResult == DialogResult.Yes)
				{
					//User wants to remove the row, remove it.
					dataGridView1.Rows.RemoveAt(selectedRow[0].Index);
					dataGridView1.Refresh();
				}
			}
			else
			{
				MessageBox.Show("Invalid selection, please select the whole row by clicking the arrow to the left.");
			}

									
		}
	}
}