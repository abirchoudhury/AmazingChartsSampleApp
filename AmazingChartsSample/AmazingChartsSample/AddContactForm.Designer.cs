namespace AmazingChartsSample
{
	partial class AddContactForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddContactForm));
			this.txtFirstName = new System.Windows.Forms.TextBox();
			this.txtLastName = new System.Windows.Forms.TextBox();
			this.txtPhone = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnSaveNewContact = new System.Windows.Forms.Button();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.SuspendLayout();
			// 
			// txtFirstName
			// 
			this.txtFirstName.Location = new System.Drawing.Point(130, 49);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.Size = new System.Drawing.Size(100, 23);
			this.txtFirstName.TabIndex = 0;
			// 
			// txtLastName
			// 
			this.txtLastName.Location = new System.Drawing.Point(130, 92);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.Size = new System.Drawing.Size(100, 23);
			this.txtLastName.TabIndex = 1;
			// 
			// txtPhone
			// 
			this.txtPhone.Location = new System.Drawing.Point(130, 173);
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size(100, 23);
			this.txtPhone.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(57, 52);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 15);
			this.label1.TabIndex = 4;
			this.label1.Text = "First Name:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(57, 95);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 15);
			this.label2.TabIndex = 5;
			this.label2.Text = "Last Name:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(43, 138);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 15);
			this.label3.TabIndex = 6;
			this.label3.Text = "Date Of Birth: ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(79, 181);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(44, 15);
			this.label4.TabIndex = 7;
			this.label4.Text = "Phone:";
			// 
			// btnSaveNewContact
			// 
			this.btnSaveNewContact.Location = new System.Drawing.Point(119, 220);
			this.btnSaveNewContact.Name = "btnSaveNewContact";
			this.btnSaveNewContact.Size = new System.Drawing.Size(111, 46);
			this.btnSaveNewContact.TabIndex = 8;
			this.btnSaveNewContact.Text = "Save And Close";
			this.btnSaveNewContact.UseVisualStyleBackColor = true;
			this.btnSaveNewContact.Click += new System.EventHandler(this.btnSaveNewContact_Click);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(130, 138);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
			this.dateTimePicker1.TabIndex = 9;
			// 
			// AddContactForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(356, 297);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.btnSaveNewContact);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtPhone);
			this.Controls.Add(this.txtLastName);
			this.Controls.Add(this.txtFirstName);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "AddContactForm";
			this.Text = "AddContactForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private TextBox txtFirstName;
		private TextBox txtLastName;
		private TextBox txtPhone;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Button btnSaveNewContact;
		private DateTimePicker dateTimePicker1;
	}
}