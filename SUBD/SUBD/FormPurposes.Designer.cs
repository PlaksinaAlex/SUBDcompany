
namespace SUBD
{
	partial class FormPurposes
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
			this.buttonAdd = new System.Windows.Forms.Button();
			this.textBoxHoursCount = new System.Windows.Forms.TextBox();
			this.buttonRefresh = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.labelIDStaff = new System.Windows.Forms.Label();
			this.labelWorkDay = new System.Windows.Forms.Label();
			this.buttonUpdate = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.textBoxIdUpdate = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxHoursCountUpdate = new System.Windows.Forms.TextBox();
			this.textBoxIDStaffUpdate = new System.Windows.Forms.TextBox();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.textBoxIdDelete = new System.Windows.Forms.TextBox();
			this.Id = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxFiltered = new System.Windows.Forms.TextBox();
			this.labelHoursCount = new System.Windows.Forms.Label();
			this.textBoxIDStaff = new System.Windows.Forms.TextBox();
			this.dateTimePickerWorkDay = new System.Windows.Forms.DateTimePicker();
			this.dateTimePickerWorkDayUpdate = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.workday = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.hourscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idstaff = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(45, 9);
			this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(130, 38);
			this.buttonAdd.TabIndex = 0;
			this.buttonAdd.Text = "Добавить";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// textBoxHoursCount
			// 
			this.textBoxHoursCount.Location = new System.Drawing.Point(122, 74);
			this.textBoxHoursCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBoxHoursCount.Name = "textBoxHoursCount";
			this.textBoxHoursCount.Size = new System.Drawing.Size(37, 23);
			this.textBoxHoursCount.TabIndex = 2;
			// 
			// buttonRefresh
			// 
			this.buttonRefresh.Location = new System.Drawing.Point(58, 224);
			this.buttonRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.buttonRefresh.Name = "buttonRefresh";
			this.buttonRefresh.Size = new System.Drawing.Size(125, 38);
			this.buttonRefresh.TabIndex = 4;
			this.buttonRefresh.Text = "Получить список назначений";
			this.buttonRefresh.UseVisualStyleBackColor = true;
			this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dateTimePickerWorkDay);
			this.groupBox1.Controls.Add(this.textBoxIDStaff);
			this.groupBox1.Controls.Add(this.labelHoursCount);
			this.groupBox1.Controls.Add(this.labelIDStaff);
			this.groupBox1.Controls.Add(this.labelWorkDay);
			this.groupBox1.Controls.Add(this.textBoxHoursCount);
			this.groupBox1.Location = new System.Drawing.Point(6, 51);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Size = new System.Drawing.Size(221, 152);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			// 
			// labelIDStaff
			// 
			this.labelIDStaff.AutoSize = true;
			this.labelIDStaff.Location = new System.Drawing.Point(6, 111);
			this.labelIDStaff.Name = "labelIDStaff";
			this.labelIDStaff.Size = new System.Drawing.Size(83, 15);
			this.labelIDStaff.TabIndex = 4;
			this.labelIDStaff.Text = "Id сотрудника";
			// 
			// labelWorkDay
			// 
			this.labelWorkDay.AutoSize = true;
			this.labelWorkDay.Location = new System.Drawing.Point(6, 36);
			this.labelWorkDay.Name = "labelWorkDay";
			this.labelWorkDay.Size = new System.Drawing.Size(83, 15);
			this.labelWorkDay.TabIndex = 3;
			this.labelWorkDay.Text = "Рабочий день";
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(697, 11);
			this.buttonUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.buttonUpdate.Name = "buttonUpdate";
			this.buttonUpdate.Size = new System.Drawing.Size(129, 38);
			this.buttonUpdate.TabIndex = 6;
			this.buttonUpdate.Text = "Обновить значение";
			this.buttonUpdate.UseVisualStyleBackColor = true;
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.dateTimePickerWorkDayUpdate);
			this.groupBox2.Controls.Add(this.textBoxIdUpdate);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.textBoxHoursCountUpdate);
			this.groupBox2.Controls.Add(this.textBoxIDStaffUpdate);
			this.groupBox2.Location = new System.Drawing.Point(620, 51);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox2.Size = new System.Drawing.Size(256, 169);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			// 
			// textBoxIdUpdate
			// 
			this.textBoxIdUpdate.Location = new System.Drawing.Point(136, 24);
			this.textBoxIdUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBoxIdUpdate.Name = "textBoxIdUpdate";
			this.textBoxIdUpdate.Size = new System.Drawing.Size(37, 23);
			this.textBoxIdUpdate.TabIndex = 6;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(5, 29);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(17, 15);
			this.label6.TabIndex = 5;
			this.label6.Text = "Id";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 137);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(83, 15);
			this.label4.TabIndex = 4;
			this.label4.Text = "Id сотрудника";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(5, 67);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(83, 15);
			this.label5.TabIndex = 3;
			this.label5.Text = "Рабочий день";
			// 
			// textBoxHoursCountUpdate
			// 
			this.textBoxHoursCountUpdate.Location = new System.Drawing.Point(136, 103);
			this.textBoxHoursCountUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBoxHoursCountUpdate.Name = "textBoxHoursCountUpdate";
			this.textBoxHoursCountUpdate.Size = new System.Drawing.Size(37, 23);
			this.textBoxHoursCountUpdate.TabIndex = 1;
			// 
			// textBoxIDStaffUpdate
			// 
			this.textBoxIDStaffUpdate.Location = new System.Drawing.Point(136, 134);
			this.textBoxIDStaffUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBoxIDStaffUpdate.Name = "textBoxIDStaffUpdate";
			this.textBoxIDStaffUpdate.Size = new System.Drawing.Size(37, 23);
			this.textBoxIDStaffUpdate.TabIndex = 2;
			// 
			// buttonDelete
			// 
			this.buttonDelete.Location = new System.Drawing.Point(705, 224);
			this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(108, 32);
			this.buttonDelete.TabIndex = 7;
			this.buttonDelete.Text = "Удалить";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// textBoxIdDelete
			// 
			this.textBoxIdDelete.Location = new System.Drawing.Point(80, 26);
			this.textBoxIdDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBoxIdDelete.Name = "textBoxIdDelete";
			this.textBoxIdDelete.Size = new System.Drawing.Size(64, 23);
			this.textBoxIdDelete.TabIndex = 8;
			// 
			// Id
			// 
			this.Id.AutoSize = true;
			this.Id.Location = new System.Drawing.Point(15, 28);
			this.Id.Name = "Id";
			this.Id.Size = new System.Drawing.Size(17, 15);
			this.Id.TabIndex = 9;
			this.Id.Text = "Id";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.Id);
			this.groupBox3.Controls.Add(this.textBoxIdDelete);
			this.groupBox3.Location = new System.Drawing.Point(682, 260);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox3.Size = new System.Drawing.Size(172, 67);
			this.groupBox3.TabIndex = 10;
			this.groupBox3.TabStop = false;
			// 
			// dataGridView
			// 
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.workday,
            this.hourscount,
            this.idstaff});
			this.dataGridView.Location = new System.Drawing.Point(233, 51);
			this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowHeadersWidth = 51;
			this.dataGridView.RowTemplate.Height = 29;
			this.dataGridView.Size = new System.Drawing.Size(381, 273);
			this.dataGridView.TabIndex = 11;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(45, 275);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(151, 13);
			this.label1.TabIndex = 19;
			this.label1.Text = "Фильтрация по сотруднику";
			// 
			// textBoxFiltered
			// 
			this.textBoxFiltered.Location = new System.Drawing.Point(58, 301);
			this.textBoxFiltered.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBoxFiltered.Name = "textBoxFiltered";
			this.textBoxFiltered.Size = new System.Drawing.Size(110, 23);
			this.textBoxFiltered.TabIndex = 18;
			// 
			// labelHoursCount
			// 
			this.labelHoursCount.AutoSize = true;
			this.labelHoursCount.Location = new System.Drawing.Point(6, 77);
			this.labelHoursCount.Name = "labelHoursCount";
			this.labelHoursCount.Size = new System.Drawing.Size(107, 15);
			this.labelHoursCount.TabIndex = 5;
			this.labelHoursCount.Text = "Количество часов";
			// 
			// textBoxIDStaff
			// 
			this.textBoxIDStaff.Location = new System.Drawing.Point(122, 108);
			this.textBoxIDStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBoxIDStaff.Name = "textBoxIDStaff";
			this.textBoxIDStaff.Size = new System.Drawing.Size(37, 23);
			this.textBoxIDStaff.TabIndex = 6;
			// 
			// dateTimePickerWorkDay
			// 
			this.dateTimePickerWorkDay.Location = new System.Drawing.Point(102, 30);
			this.dateTimePickerWorkDay.Name = "dateTimePickerWorkDay";
			this.dateTimePickerWorkDay.Size = new System.Drawing.Size(113, 23);
			this.dateTimePickerWorkDay.TabIndex = 20;
			// 
			// dateTimePickerWorkDayUpdate
			// 
			this.dateTimePickerWorkDayUpdate.Location = new System.Drawing.Point(106, 67);
			this.dateTimePickerWorkDayUpdate.Name = "dateTimePickerWorkDayUpdate";
			this.dateTimePickerWorkDayUpdate.Size = new System.Drawing.Size(144, 23);
			this.dateTimePickerWorkDayUpdate.TabIndex = 21;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 106);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(107, 15);
			this.label2.TabIndex = 20;
			this.label2.Text = "Количество часов";
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.dataGridViewTextBoxColumn1.HeaderText = "Id";
			this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.Width = 42;
			// 
			// workday
			// 
			this.workday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.workday.HeaderText = "Рабочий день";
			this.workday.MinimumWidth = 6;
			this.workday.Name = "workday";
			// 
			// hourscount
			// 
			this.hourscount.HeaderText = "Количество часов";
			this.hourscount.Name = "hourscount";
			// 
			// idstaff
			// 
			this.idstaff.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.idstaff.HeaderText = "Id сотрудника";
			this.idstaff.MinimumWidth = 6;
			this.idstaff.Name = "idstaff";
			// 
			// FormPurposes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(888, 338);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxFiltered);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.buttonUpdate);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.buttonRefresh);
			this.Controls.Add(this.buttonAdd);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "FormPurposes";
			this.Text = "Назначения";
			this.Load += new System.EventHandler(this.FormPurposes_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.TextBox textBoxHoursCount;
		private System.Windows.Forms.Button buttonRefresh;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label labelIDStaff;
		private System.Windows.Forms.Label labelWorkDay;
		private System.Windows.Forms.Button buttonUpdate;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox textBoxIdUpdate;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxHoursCountUpdate;
		private System.Windows.Forms.TextBox textBoxIDStaffUpdate;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.TextBox textBoxIdDelete;
		private System.Windows.Forms.Label Id;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxFiltered;
		private System.Windows.Forms.Label labelHoursCount;
		private System.Windows.Forms.TextBox textBoxIDStaff;
		private System.Windows.Forms.DateTimePicker dateTimePickerWorkDay;
		private System.Windows.Forms.DateTimePicker dateTimePickerWorkDayUpdate;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn workday;
		private System.Windows.Forms.DataGridViewTextBoxColumn hourscount;
		private System.Windows.Forms.DataGridViewTextBoxColumn idstaff;
	}
}