
namespace SUBD
{
    partial class FormPosts
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
			this.textBoxPostName = new System.Windows.Forms.TextBox();
			this.textBoxPostRate = new System.Windows.Forms.TextBox();
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
			this.textBoxPostNameUpdate = new System.Windows.Forms.TextBox();
			this.textBoxPostRateUpdate = new System.Windows.Forms.TextBox();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.textBoxIdDelete = new System.Windows.Forms.TextBox();
			this.Id = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.postname = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.postrate = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
			// textBoxPostName
			// 
			this.textBoxPostName.Location = new System.Drawing.Point(7, 46);
			this.textBoxPostName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBoxPostName.Name = "textBoxPostName";
			this.textBoxPostName.Size = new System.Drawing.Size(137, 23);
			this.textBoxPostName.TabIndex = 1;
			// 
			// textBoxPostRate
			// 
			this.textBoxPostRate.Location = new System.Drawing.Point(7, 108);
			this.textBoxPostRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBoxPostRate.Name = "textBoxPostRate";
			this.textBoxPostRate.Size = new System.Drawing.Size(137, 23);
			this.textBoxPostRate.TabIndex = 2;
			// 
			// buttonRefresh
			// 
			this.buttonRefresh.Location = new System.Drawing.Point(39, 212);
			this.buttonRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.buttonRefresh.Name = "buttonRefresh";
			this.buttonRefresh.Size = new System.Drawing.Size(125, 38);
			this.buttonRefresh.TabIndex = 4;
			this.buttonRefresh.Text = "Получить список должностей";
			this.buttonRefresh.UseVisualStyleBackColor = true;
			this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.labelPostRate);
			this.groupBox1.Controls.Add(this.labelPostName);
			this.groupBox1.Controls.Add(this.textBoxPostName);
			this.groupBox1.Controls.Add(this.textBoxPostRate);
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
			this.labelPostRate.Location = new System.Drawing.Point(5, 82);
			this.labelPostRate.Name = "labelPostRate";
			this.labelPostRate.Size = new System.Drawing.Size(125, 15);
			this.labelPostRate.TabIndex = 4;
			this.labelPostRate.Text = "Ставка по должности";
			// 
			// labelPostName
			// 
			this.labelPostName.AutoSize = true;
			this.labelPostName.Location = new System.Drawing.Point(7, 18);
			this.labelPostName.Name = "labelPostName";
			this.labelPostName.Size = new System.Drawing.Size(123, 15);
			this.labelPostName.TabIndex = 3;
			this.labelPostName.Text = "Название должности";
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
			this.groupBox2.Controls.Add(this.textBoxPostNameUpdate);
			this.groupBox2.Controls.Add(this.textBoxPostRateUpdate);
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
			this.labelRate.Size = new System.Drawing.Size(125, 15);
			this.labelRate.TabIndex = 4;
			this.labelRate.Text = "Ставка по должности";
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(39, 50);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(123, 15);
			this.labelName.TabIndex = 3;
			this.labelName.Text = "Название должности";
			// 
			// textBoxPostNameUpdate
			// 
			this.textBoxPostNameUpdate.Location = new System.Drawing.Point(15, 81);
			this.textBoxPostNameUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBoxPostNameUpdate.Name = "textBoxPostNameUpdate";
			this.textBoxPostNameUpdate.Size = new System.Drawing.Size(190, 23);
			this.textBoxPostNameUpdate.TabIndex = 1;
			// 
			// textBoxPostRateUpdate
			// 
			this.textBoxPostRateUpdate.Location = new System.Drawing.Point(15, 144);
			this.textBoxPostRateUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBoxPostRateUpdate.Name = "textBoxPostRateUpdate";
			this.textBoxPostRateUpdate.Size = new System.Drawing.Size(190, 23);
			this.textBoxPostRateUpdate.TabIndex = 2;
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
            this.postname,
            this.postrate});
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
			// postname
			// 
			this.postname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.postname.HeaderText = "Название должности";
			this.postname.MinimumWidth = 6;
			this.postname.Name = "postname";
			// 
			// postrate
			// 
			this.postrate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.postrate.HeaderText = "Ставка по должности";
			this.postrate.MinimumWidth = 6;
			this.postrate.Name = "postrate";
			// 
			// textBoxFiltered
			// 
			this.textBoxFiltered.Location = new System.Drawing.Point(53, 301);
			this.textBoxFiltered.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBoxFiltered.Name = "textBoxFiltered";
			this.textBoxFiltered.Size = new System.Drawing.Size(110, 23);
			this.textBoxFiltered.TabIndex = 12;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(4, 267);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(204, 13);
			this.label1.TabIndex = 13;
			this.label1.Text = "Фильтрация по ставке по должности";
			// 
			// FormPosts
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
			this.Name = "FormPosts";
			this.Text = "Должности";
			this.Load += new System.EventHandler(this.FormPosts_Load);
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
        private System.Windows.Forms.TextBox textBoxPostName;
        private System.Windows.Forms.TextBox textBoxPostRate;
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
        private System.Windows.Forms.TextBox textBoxPostNameUpdate;
        private System.Windows.Forms.TextBox textBoxPostRateUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxIdDelete;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox textBoxFiltered;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn postname;
		private System.Windows.Forms.DataGridViewTextBoxColumn postrate;
	}

}