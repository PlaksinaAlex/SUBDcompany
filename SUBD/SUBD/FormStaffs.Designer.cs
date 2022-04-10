
namespace SUBD
{
	partial class FormStaffs
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
			this.textBoxStaffName = new System.Windows.Forms.TextBox();
			this.buttonRefresh = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textBoxStaffRate = new System.Windows.Forms.TextBox();
			this.labelHoursCount = new System.Windows.Forms.Label();
			this.labelIDStaff = new System.Windows.Forms.Label();
			this.labelWorkDay = new System.Windows.Forms.Label();
			this.buttonUpdate = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxIdUpdate = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxStaffNameUpdate = new System.Windows.Forms.TextBox();
			this.textBoxIDPostUpdate = new System.Windows.Forms.TextBox();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.textBoxIdDelete = new System.Windows.Forms.TextBox();
			this.Id = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxFiltered = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxIDPost = new System.Windows.Forms.TextBox();
			this.textBoxIDProject = new System.Windows.Forms.TextBox();
			this.textBoxIDProjectUpdate = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBoxStaffRateUpdate = new System.Windows.Forms.TextBox();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.staffname = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.staffrate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idpost = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idproject = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(53, 18);
			this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(130, 38);
			this.buttonAdd.TabIndex = 0;
			this.buttonAdd.Text = "Добавить";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// textBoxStaffName
			// 
			this.textBoxStaffName.Location = new System.Drawing.Point(6, 42);
			this.textBoxStaffName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBoxStaffName.Name = "textBoxStaffName";
			this.textBoxStaffName.Size = new System.Drawing.Size(197, 23);
			this.textBoxStaffName.TabIndex = 2;
			// 
			// buttonRefresh
			// 
			this.buttonRefresh.Location = new System.Drawing.Point(58, 244);
			this.buttonRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.buttonRefresh.Name = "buttonRefresh";
			this.buttonRefresh.Size = new System.Drawing.Size(125, 38);
			this.buttonRefresh.TabIndex = 4;
			this.buttonRefresh.Text = "Получить список сотрудников";
			this.buttonRefresh.UseVisualStyleBackColor = true;
			this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBoxIDProject);
			this.groupBox1.Controls.Add(this.textBoxIDPost);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.textBoxStaffRate);
			this.groupBox1.Controls.Add(this.labelHoursCount);
			this.groupBox1.Controls.Add(this.labelIDStaff);
			this.groupBox1.Controls.Add(this.labelWorkDay);
			this.groupBox1.Controls.Add(this.textBoxStaffName);
			this.groupBox1.Location = new System.Drawing.Point(6, 60);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Size = new System.Drawing.Size(221, 169);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			// 
			// textBoxStaffRate
			// 
			this.textBoxStaffRate.Location = new System.Drawing.Point(146, 77);
			this.textBoxStaffRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBoxStaffRate.Name = "textBoxStaffRate";
			this.textBoxStaffRate.Size = new System.Drawing.Size(57, 23);
			this.textBoxStaffRate.TabIndex = 6;
			// 
			// labelHoursCount
			// 
			this.labelHoursCount.AutoSize = true;
			this.labelHoursCount.Location = new System.Drawing.Point(6, 77);
			this.labelHoursCount.Name = "labelHoursCount";
			this.labelHoursCount.Size = new System.Drawing.Size(125, 15);
			this.labelHoursCount.TabIndex = 5;
			this.labelHoursCount.Text = "Надбавка сотруднику";
			// 
			// labelIDStaff
			// 
			this.labelIDStaff.AutoSize = true;
			this.labelIDStaff.Location = new System.Drawing.Point(6, 111);
			this.labelIDStaff.Name = "labelIDStaff";
			this.labelIDStaff.Size = new System.Drawing.Size(81, 15);
			this.labelIDStaff.TabIndex = 4;
			this.labelIDStaff.Text = "Id должности";
			// 
			// labelWorkDay
			// 
			this.labelWorkDay.AutoSize = true;
			this.labelWorkDay.Location = new System.Drawing.Point(52, 18);
			this.labelWorkDay.Name = "labelWorkDay";
			this.labelWorkDay.Size = new System.Drawing.Size(100, 15);
			this.labelWorkDay.TabIndex = 3;
			this.labelWorkDay.Text = "Имя сотрудника:";
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
			this.groupBox2.Controls.Add(this.textBoxStaffRateUpdate);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.textBoxIDProjectUpdate);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.textBoxIdUpdate);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.textBoxStaffNameUpdate);
			this.groupBox2.Controls.Add(this.textBoxIDPostUpdate);
			this.groupBox2.Location = new System.Drawing.Point(653, 51);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox2.Size = new System.Drawing.Size(223, 231);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(5, 127);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(125, 15);
			this.label2.TabIndex = 20;
			this.label2.Text = "Надбавка сотруднику";
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
			this.label6.Location = new System.Drawing.Point(71, 27);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(17, 15);
			this.label6.TabIndex = 5;
			this.label6.Text = "Id";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(22, 163);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(81, 15);
			this.label4.TabIndex = 4;
			this.label4.Text = "Id должности";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(71, 67);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 15);
			this.label5.TabIndex = 3;
			this.label5.Text = "Имя сотрудника:";
			// 
			// textBoxStaffNameUpdate
			// 
			this.textBoxStaffNameUpdate.Location = new System.Drawing.Point(22, 86);
			this.textBoxStaffNameUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBoxStaffNameUpdate.Name = "textBoxStaffNameUpdate";
			this.textBoxStaffNameUpdate.Size = new System.Drawing.Size(185, 23);
			this.textBoxStaffNameUpdate.TabIndex = 1;
			// 
			// textBoxIDPostUpdate
			// 
			this.textBoxIDPostUpdate.Location = new System.Drawing.Point(157, 160);
			this.textBoxIDPostUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBoxIDPostUpdate.Name = "textBoxIDPostUpdate";
			this.textBoxIDPostUpdate.Size = new System.Drawing.Size(50, 23);
			this.textBoxIDPostUpdate.TabIndex = 2;
			// 
			// buttonDelete
			// 
			this.buttonDelete.Location = new System.Drawing.Point(705, 292);
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
			this.groupBox3.Location = new System.Drawing.Point(669, 322);
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
            this.staffname,
            this.staffrate,
            this.idpost,
            this.idproject});
			this.dataGridView.Location = new System.Drawing.Point(233, 51);
			this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowHeadersWidth = 51;
			this.dataGridView.RowTemplate.Height = 29;
			this.dataGridView.Size = new System.Drawing.Size(414, 273);
			this.dataGridView.TabIndex = 11;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(45, 292);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(141, 13);
			this.label1.TabIndex = 19;
			this.label1.Text = "Фильтрация по надбавке";
			// 
			// textBoxFiltered
			// 
			this.textBoxFiltered.Location = new System.Drawing.Point(58, 322);
			this.textBoxFiltered.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBoxFiltered.Name = "textBoxFiltered";
			this.textBoxFiltered.Size = new System.Drawing.Size(110, 23);
			this.textBoxFiltered.TabIndex = 18;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 142);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 15);
			this.label3.TabIndex = 7;
			this.label3.Text = "Id проекта";
			// 
			// textBoxIDPost
			// 
			this.textBoxIDPost.Location = new System.Drawing.Point(146, 108);
			this.textBoxIDPost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBoxIDPost.Name = "textBoxIDPost";
			this.textBoxIDPost.Size = new System.Drawing.Size(57, 23);
			this.textBoxIDPost.TabIndex = 8;
			// 
			// textBoxIDProject
			// 
			this.textBoxIDProject.Location = new System.Drawing.Point(146, 137);
			this.textBoxIDProject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBoxIDProject.Name = "textBoxIDProject";
			this.textBoxIDProject.Size = new System.Drawing.Size(57, 23);
			this.textBoxIDProject.TabIndex = 9;
			// 
			// textBoxIDProjectUpdate
			// 
			this.textBoxIDProjectUpdate.Location = new System.Drawing.Point(157, 193);
			this.textBoxIDProjectUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBoxIDProjectUpdate.Name = "textBoxIDProjectUpdate";
			this.textBoxIDProjectUpdate.Size = new System.Drawing.Size(50, 23);
			this.textBoxIDProjectUpdate.TabIndex = 21;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(25, 196);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(64, 15);
			this.label7.TabIndex = 22;
			this.label7.Text = "Id проекта";
			// 
			// textBoxStaffRateUpdate
			// 
			this.textBoxStaffRateUpdate.Location = new System.Drawing.Point(157, 124);
			this.textBoxStaffRateUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBoxStaffRateUpdate.Name = "textBoxStaffRateUpdate";
			this.textBoxStaffRateUpdate.Size = new System.Drawing.Size(50, 23);
			this.textBoxStaffRateUpdate.TabIndex = 23;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.dataGridViewTextBoxColumn1.HeaderText = "Id";
			this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.Width = 42;
			// 
			// staffname
			// 
			this.staffname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.staffname.HeaderText = "Имя сотрудника";
			this.staffname.MinimumWidth = 6;
			this.staffname.Name = "staffname";
			// 
			// staffrate
			// 
			this.staffrate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.staffrate.HeaderText = "Надбавка сотруднику";
			this.staffrate.Name = "staffrate";
			// 
			// idpost
			// 
			this.idpost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.idpost.HeaderText = "Id должности";
			this.idpost.MinimumWidth = 6;
			this.idpost.Name = "idpost";
			// 
			// idproject
			// 
			this.idproject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.idproject.HeaderText = "Id проекта";
			this.idproject.Name = "idproject";
			// 
			// FormStaffs
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(895, 400);
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
			this.Name = "FormStaffs";
			this.Text = "Сотрудники";
			this.Load += new System.EventHandler(this.FormStaffs_Load);
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
		private System.Windows.Forms.TextBox textBoxStaffName;
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
		private System.Windows.Forms.TextBox textBoxStaffNameUpdate;
		private System.Windows.Forms.TextBox textBoxIDPostUpdate;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.TextBox textBoxIdDelete;
		private System.Windows.Forms.Label Id;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxFiltered;
		private System.Windows.Forms.Label labelHoursCount;
		private System.Windows.Forms.TextBox textBoxStaffRate;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxIDProject;
		private System.Windows.Forms.TextBox textBoxIDPost;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxStaffRateUpdate;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBoxIDProjectUpdate;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn staffname;
		private System.Windows.Forms.DataGridViewTextBoxColumn staffrate;
		private System.Windows.Forms.DataGridViewTextBoxColumn idpost;
		private System.Windows.Forms.DataGridViewTextBoxColumn idproject;
	}
}