
namespace SUBD
{
    partial class FormProjectNumbers
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
			this.textBoxPrNumberName = new System.Windows.Forms.TextBox();
			this.textBoxPrTypeName = new System.Windows.Forms.TextBox();
			this.buttonRefresh = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.labelPT = new System.Windows.Forms.Label();
			this.labelPNName = new System.Windows.Forms.Label();
			this.buttonUpdate = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.textBoxIdUpdate = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxPrNumberNameUpdate = new System.Windows.Forms.TextBox();
			this.textBoxPrTypeUpdate = new System.Windows.Forms.TextBox();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.textBoxIdDelete = new System.Windows.Forms.TextBox();
			this.Id = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idPrType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxFiltered = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(19, 9);
			this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(130, 38);
			this.buttonAdd.TabIndex = 0;
			this.buttonAdd.Text = "Добавить";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// textBoxPrNumberName
			// 
			this.textBoxPrNumberName.Location = new System.Drawing.Point(13, 33);
			this.textBoxPrNumberName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBoxPrNumberName.Name = "textBoxPrNumberName";
			this.textBoxPrNumberName.Size = new System.Drawing.Size(130, 23);
			this.textBoxPrNumberName.TabIndex = 1;
			// 
			// textBoxPrTypeName
			// 
			this.textBoxPrTypeName.Location = new System.Drawing.Point(13, 100);
			this.textBoxPrTypeName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBoxPrTypeName.Name = "textBoxPrTypeName";
			this.textBoxPrTypeName.Size = new System.Drawing.Size(121, 23);
			this.textBoxPrTypeName.TabIndex = 2;
			// 
			// buttonRefresh
			// 
			this.buttonRefresh.Location = new System.Drawing.Point(19, 228);
			this.buttonRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.buttonRefresh.Name = "buttonRefresh";
			this.buttonRefresh.Size = new System.Drawing.Size(125, 38);
			this.buttonRefresh.TabIndex = 4;
			this.buttonRefresh.Text = "Получить список проектов";
			this.buttonRefresh.UseVisualStyleBackColor = true;
			this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.labelPT);
			this.groupBox1.Controls.Add(this.labelPNName);
			this.groupBox1.Controls.Add(this.textBoxPrNumberName);
			this.groupBox1.Controls.Add(this.textBoxPrTypeName);
			this.groupBox1.Location = new System.Drawing.Point(6, 51);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Size = new System.Drawing.Size(164, 140);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			// 
			// labelPT
			// 
			this.labelPT.AutoSize = true;
			this.labelPT.Location = new System.Drawing.Point(40, 83);
			this.labelPT.Name = "labelPT";
			this.labelPT.Size = new System.Drawing.Size(74, 15);
			this.labelPT.TabIndex = 4;
			this.labelPT.Text = "Тип проекта";
			// 
			// labelPNName
			// 
			this.labelPNName.AutoSize = true;
			this.labelPNName.Location = new System.Drawing.Point(28, 16);
			this.labelPNName.Name = "labelPNName";
			this.labelPNName.Size = new System.Drawing.Size(106, 15);
			this.labelPNName.TabIndex = 3;
			this.labelPNName.Text = "Название проекта";
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(537, 9);
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
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.textBoxPrNumberNameUpdate);
			this.groupBox2.Controls.Add(this.textBoxPrTypeUpdate);
			this.groupBox2.Location = new System.Drawing.Point(507, 51);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox2.Size = new System.Drawing.Size(189, 160);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			// 
			// textBoxIdUpdate
			// 
			this.textBoxIdUpdate.Location = new System.Drawing.Point(41, 21);
			this.textBoxIdUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBoxIdUpdate.Name = "textBoxIdUpdate";
			this.textBoxIdUpdate.Size = new System.Drawing.Size(37, 23);
			this.textBoxIdUpdate.TabIndex = 6;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 24);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(17, 15);
			this.label6.TabIndex = 5;
			this.label6.Text = "Id";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(57, 108);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(74, 15);
			this.label4.TabIndex = 4;
			this.label4.Text = "Тип проекта";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(41, 49);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(106, 15);
			this.label5.TabIndex = 3;
			this.label5.Text = "Название проекта";
			// 
			// textBoxPrNumberNameUpdate
			// 
			this.textBoxPrNumberNameUpdate.Location = new System.Drawing.Point(30, 75);
			this.textBoxPrNumberNameUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBoxPrNumberNameUpdate.Name = "textBoxPrNumberNameUpdate";
			this.textBoxPrNumberNameUpdate.Size = new System.Drawing.Size(119, 23);
			this.textBoxPrNumberNameUpdate.TabIndex = 1;
			// 
			// textBoxPrTypeUpdate
			// 
			this.textBoxPrTypeUpdate.Location = new System.Drawing.Point(30, 133);
			this.textBoxPrTypeUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBoxPrTypeUpdate.Name = "textBoxPrTypeUpdate";
			this.textBoxPrTypeUpdate.Size = new System.Drawing.Size(119, 23);
			this.textBoxPrTypeUpdate.TabIndex = 2;
			// 
			// buttonDelete
			// 
			this.buttonDelete.Location = new System.Drawing.Point(548, 215);
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
			this.groupBox3.Location = new System.Drawing.Point(512, 260);
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
            this.ProjectName,
            this.idPrType});
			this.dataGridView.Location = new System.Drawing.Point(175, 51);
			this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowHeadersWidth = 51;
			this.dataGridView.RowTemplate.Height = 29;
			this.dataGridView.Size = new System.Drawing.Size(312, 273);
			this.dataGridView.TabIndex = 11;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn1.HeaderText = "Id";
			this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// ProjectName
			// 
			this.ProjectName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ProjectName.HeaderText = "Название проекта";
			this.ProjectName.MinimumWidth = 6;
			this.ProjectName.Name = "ProjectName";
			// 
			// idPrType
			// 
			this.idPrType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.idPrType.HeaderText = "Id типа проекта";
			this.idPrType.MinimumWidth = 6;
			this.idPrType.Name = "idPrType";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(4, 277);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(161, 13);
			this.label1.TabIndex = 19;
			this.label1.Text = "Фильтрация по типу проекту";
			// 
			// textBoxFiltered
			// 
			this.textBoxFiltered.Location = new System.Drawing.Point(34, 301);
			this.textBoxFiltered.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBoxFiltered.Name = "textBoxFiltered";
			this.textBoxFiltered.Size = new System.Drawing.Size(110, 23);
			this.textBoxFiltered.TabIndex = 18;
			// 
			// FormProjectNumbers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(709, 338);
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
			this.Name = "FormProjectNumbers";
			this.Text = "Проекты";
			this.Load += new System.EventHandler(this.FormProjectNumbers_Load);
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
        private System.Windows.Forms.TextBox textBoxPrNumberName;
        private System.Windows.Forms.TextBox textBoxPrTypeName;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelPT;
        private System.Windows.Forms.Label labelPNName;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxIdUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPrNumberNameUpdate;
        private System.Windows.Forms.TextBox textBoxPrTypeUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxIdDelete;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFiltered;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProjectName;
		private System.Windows.Forms.DataGridViewTextBoxColumn idPrType;
	}
}