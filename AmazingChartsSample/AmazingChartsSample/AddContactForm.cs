using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmazingChartsSample
{
	/// <summary>
	/// Class for a add form popup
	/// </summary>
	public partial class AddContactForm : Form
	{
		private dsContacts _dsContacts;
		
		public AddContactForm(dsContacts ds)
		{
			InitializeComponent();
			this._dsContacts = ds;
		}

		private void AddContactForm_Load(object sender, EventArgs e)
		{

		}

		/// <summary>
		/// Adds a new row to the dataset and saves it as a new XML file
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnSaveNewContact_Click(object sender, EventArgs e)
		{
			if(_dsContacts != null)
			{
				DataRow dr = _dsContacts.Tables[0].NewRow();
				dr["first"] = txtFirstName.Text;
				dr["last"] = txtLastName.Text;
				dr["dob"] = dateTimePicker1.Value.ToString("yyyy-MM-dd");
				dr["phone"] = txtPhone.Text;
								
				_dsContacts.AcceptChanges();
				_dsContacts.Tables[0].Rows.Add(dr);
				this.Close();
				AmazingChartsSample.Save(this._dsContacts);
			}			
		}

		
	}
}
