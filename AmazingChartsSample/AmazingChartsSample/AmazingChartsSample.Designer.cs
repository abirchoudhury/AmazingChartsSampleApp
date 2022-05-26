namespace AmazingChartsSample
{
    partial class AmazingChartsSample
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AmazingChartsSample));
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnGetContacts = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnAddNewContact = new System.Windows.Forms.Button();
			this.btnDeleteContact = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToOrderColumns = true;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(57, 32);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 25;
			this.dataGridView1.Size = new System.Drawing.Size(526, 331);
			this.dataGridView1.TabIndex = 0;
			// 
			// btnGetContacts
			// 
			this.btnGetContacts.Location = new System.Drawing.Point(57, 382);
			this.btnGetContacts.Name = "btnGetContacts";
			this.btnGetContacts.Size = new System.Drawing.Size(109, 43);
			this.btnGetContacts.TabIndex = 1;
			this.btnGetContacts.Text = "Get Contacts";
			this.btnGetContacts.UseVisualStyleBackColor = true;
			this.btnGetContacts.Click += new System.EventHandler(this.btnGetContacts_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(57, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 15);
			this.label1.TabIndex = 3;
			this.label1.Text = "Contacts: ";
			// 
			// btnAddNewContact
			// 
			this.btnAddNewContact.Location = new System.Drawing.Point(172, 382);
			this.btnAddNewContact.Name = "btnAddNewContact";
			this.btnAddNewContact.Size = new System.Drawing.Size(109, 43);
			this.btnAddNewContact.TabIndex = 4;
			this.btnAddNewContact.Text = "Add New";
			this.btnAddNewContact.UseVisualStyleBackColor = true;
			this.btnAddNewContact.Click += new System.EventHandler(this.btnAddNewContact_Click);
			// 
			// btnDeleteContact
			// 
			this.btnDeleteContact.Location = new System.Drawing.Point(287, 382);
			this.btnDeleteContact.Name = "btnDeleteContact";
			this.btnDeleteContact.Size = new System.Drawing.Size(109, 43);
			this.btnDeleteContact.TabIndex = 5;
			this.btnDeleteContact.Text = "Delete Selected";
			this.btnDeleteContact.UseVisualStyleBackColor = true;
			this.btnDeleteContact.Click += new System.EventHandler(this.btnDeleteContact_Click);
			// 
			// AmazingChartsSample
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(663, 479);
			this.Controls.Add(this.btnDeleteContact);
			this.Controls.Add(this.btnAddNewContact);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnGetContacts);
			this.Controls.Add(this.dataGridView1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "AmazingChartsSample";
			this.Text = "Amazing Charts Sample";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private DataGridView dataGridView1;
		private Button btnGetContacts;
		private Label label1;
		private Button btnAddNewContact;
		private Button btnDeleteContact;
	}
}