
namespace SUBD
{
	partial class FormProjectType
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
			this.textBoxProjectTypeName = new System.Windows.Forms.TextBox();
			this.textBoxProjectTypeRate = new System.Windows.Forms.TextBox();
			this.buttonRefresh = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.labelPostRate = new System.Windows.Forms.Label();
			this.labelPostName = new System.Windows.Forms.Label();
			this.buttonUpdate = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.textBoxIdUpdate = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.labelRate = new System.Windows.Forms.Label();
			this.labelName = new System.Windows.Forms.Label();
			this.textBoxProjectTypeNameUpdate = new System.Windows.Forms.TextBox();
			this.textBoxProjectTypeRateUpdate = new System.Windows.Forms.TextBox();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.textBoxIdDelete = new System.Windows.Forms.TextBox();
			this.Id = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.projectTypename = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.projectTypetrate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.textBoxFiltered = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(26, 9);
			this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(130, 38);
			this.buttonAdd.TabIndex = 0;
			this.buttonAdd.Text = "Добавить";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// textBoxProjectTypeName
			// 
			this.textBoxProjectTypeName.Location = new System.Drawing.Point(7, 46);
			this.textBoxProjectTypeName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBoxProjectTypeName.Name = "textBoxProjectTypeName";
			this.textBoxProjectTypeName.Size = new System.Drawing.Size(137, 23);
			this.textBoxProjectTypeName.TabIndex = 1;
			// 
			// textBoxProjectTypeRate
			// 
			this.textBoxProjectTypeRate.Location = new System.Drawing.Point(7, 108);
			this.textBoxProjectTypeRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBoxProjectTypeRate.Name = "textBoxProjectTypeRate";
			this.textBoxProjectTypeRate.Size = new System.Drawing.Size(137, 23);
			this.textBoxProjectTypeRate.TabIndex = 2;
			// 
			// buttonRefresh
			// 
			this.buttonRefresh.Location = new System.Drawing.Point(39, 212);
			this.buttonRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.buttonRefresh.Name = "buttonRefresh";
			this.buttonRefresh.Size = new System.Drawing.Size(125, 38);
			this.buttonRefresh.TabIndex = 4;
			this.buttonRefresh.Text = "Получить список типов проекта";
			this.buttonRefresh.UseVisualStyleBackColor = true;
			this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.labelPostRate);
			this.groupBox1.Controls.Add(this.labelPostName);
			this.groupBox1.Controls.Add(this.textBoxProjectTypeName);
			this.groupBox1.Controls.Add(this.textBoxProjectTypeRate);
			this.groupBox1.Location = new System.Drawing.Point(19, 51);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Size = new System.Drawing.Size(150, 140);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			// 
			// labelPostRate
			// 
			this.labelPostRate.AutoSize = true;
			this.labelPostRate.Location = new System.Drawing.Point(3, 82);
			this.labelPostRate.Name = "labelPostRate";
			this.labelPostRate.Size = new System.Drawing.Size(142, 15);
			this.labelPostRate.TabIndex = 4;
			this.labelPostRate.Text = "Надбавка за тип проекта";
			// 
			// labelPostName
			// 
			this.labelPostName.AutoSize = true;
			this.labelPostName.Location = new System.Drawing.Point(7, 18);
			this.labelPostName.Name = "labelPostName";
			this.labelPostName.Size = new System.Drawing.Size(134, 15);
			this.labelPostName.TabIndex = 3;
			this.labelPostName.Text = "Название типа проекта";
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(600, 11);
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
			this.groupBox2.Controls.Add(this.textBoxIdUpdate);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.labelRate);
			this.groupBox2.Controls.Add(this.labelName);
			this.groupBox2.Controls.Add(this.textBoxProjectTypeNameUpdate);
			this.groupBox2.Controls.Add(this.textBoxProjectTypeRateUpdate);
			this.groupBox2.Location = new System.Drawing.Point(552, 68);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox2.Size = new System.Drawing.Size(224, 176);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			// 
			// textBoxIdUpdate
			// 
			this.textBoxIdUpdate.Location = new System.Drawing.Point(104, 21);
			this.textBoxIdUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBoxIdUpdate.Name = "textBoxIdUpdate";
			this.textBoxIdUpdate.Size = new System.Drawing.Size(58, 23);
			this.textBoxIdUpdate.TabIndex = 6;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(60, 24);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(17, 15);
			this.label6.TabIndex = 5;
			this.label6.Text = "Id";
			// 
			// labelRate
			// 
			this.labelRate.AutoSize = true;
			this.labelRate.Location = new System.Drawing.Point(39, 117);
			this.labelRate.Name = "labelRate";
			this.labelRate.Size = new System.Drawing.Size(142, 15);
			this.labelRate.TabIndex = 4;
			this.labelRate.Text = "Надбавка за тип проекта";
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(39, 50);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(134, 15);
			this.labelName.TabIndex = 3;
			this.labelName.Text = "Название типа проекта";
			// 
			// textBoxProjectTypeNameUpdate
			// 
			this.textBoxProjectTypeNameUpdate.Location = new System.Drawing.Point(15, 81);
			this.textBoxProjectTypeNameUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBoxProjectTypeNameUpdate.Name = "textBoxProjectTypeNameUpdate";
			this.textBoxProjectTypeNameUpdate.Size = new System.Drawing.Size(190, 23);
			this.textBoxProjectTypeNameUpdate.TabIndex = 1;
			// 
			// textBoxProjectTypeRateUpdate
			// 
			this.textBoxProjectTypeRateUpdate.Location = new System.Drawing.Point(15, 144);
			this.textBoxProjectTypeRateUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBoxProjectTypeRateUpdate.Name = "textBoxProjectTypeRateUpdate";
			this.textBoxProjectTypeRateUpdate.Size = new System.Drawing.Size(190, 23);
			this.textBoxProjectTypeRateUpdate.TabIndex = 2;
			// 
			// buttonDelete
			// 
			this.buttonDelete.Location = new System.Drawing.Point(612, 257);
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
			this.groupBox3.Location = new System.Drawing.Point(576, 293);
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
            this.projectTypename,
            this.projectTypetrate});
			this.dataGridView.Location = new System.Drawing.Point(223, 51);
			this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowHeadersWidth = 51;
			this.dataGridView.RowTemplate.Height = 29;
			this.dataGridView.Size = new System.Drawing.Size(312, 273);
			this.dataGridView.TabIndex = 11;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.dataGridViewTextBoxColumn1.HeaderText = "Id";
			this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.Width = 42;
			// 
			// projectTypename
			// 
			this.projectTypename.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.projectTypename.HeaderText = "Название типа проекта";
			this.projectTypename.MinimumWidth = 6;
			this.projectTypename.Name = "projectTypename";
			// 
			// projectTypetrate
			// 
			this.projectTypetrate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.projectTypetrate.HeaderText = "Надбавка за тип проекта";
			this.projectTypetrate.MinimumWidth = 6;
			this.projectTypetrate.Name = "projectTypetrate";
			// 
			// textBoxFiltered
			// 
			this.textBoxFiltered.Location = new System.Drawing.Point(46, 293);
			this.textBoxFiltered.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBoxFiltered.Name = "textBoxFiltered";
			this.textBoxFiltered.Size = new System.Drawing.Size(110, 23);
			this.textBoxFiltered.TabIndex = 12;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(39, 267);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(141, 13);
			this.label1.TabIndex = 13;
			this.label1.Text = "Фильтрация по надбавке";
			// 
			// FormProjectType
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(801, 371);
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
			this.Name = "FormProjectType";
			this.Text = "Типы проектов";
			this.Load += new System.EventHandler(this.FormProjectType_Load);
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
		private System.Windows.Forms.TextBox textBoxProjectTypeName;
		private System.Windows.Forms.TextBox textBoxProjectTypeRate;
		private System.Windows.Forms.Button buttonRefresh;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label labelPostRate;
		private System.Windows.Forms.Label labelPostName;
		private System.Windows.Forms.Button buttonUpdate;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox textBoxIdUpdate;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label labelRate;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.TextBox textBoxProjectTypeNameUpdate;
		private System.Windows.Forms.TextBox textBoxProjectTypeRateUpdate;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.TextBox textBoxIdDelete;
		private System.Windows.Forms.Label Id;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.TextBox textBoxFiltered;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn projectTypename;
		private System.Windows.Forms.DataGridViewTextBoxColumn projectTypetrate;
	}
}