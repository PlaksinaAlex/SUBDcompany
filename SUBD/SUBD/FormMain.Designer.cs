
namespace SUBD
{
	partial class FormMain
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
			this.buttonPurpose = new System.Windows.Forms.Button();
			this.buttonStaff = new System.Windows.Forms.Button();
			this.buttonProjectType = new System.Windows.Forms.Button();
			this.buttonProjectNumber = new System.Windows.Forms.Button();
			this.buttonPost = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonPurpose
			// 
			this.buttonPurpose.Location = new System.Drawing.Point(23, 20);
			this.buttonPurpose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.buttonPurpose.Name = "buttonPurpose";
			this.buttonPurpose.Size = new System.Drawing.Size(130, 33);
			this.buttonPurpose.TabIndex = 0;
			this.buttonPurpose.Text = "Назначение";
			this.buttonPurpose.UseVisualStyleBackColor = true;
			this.buttonPurpose.Click += new System.EventHandler(this.buttonPurpose_Click);
			// 
			// buttonStaff
			// 
			this.buttonStaff.Location = new System.Drawing.Point(149, 74);
			this.buttonStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.buttonStaff.Name = "buttonStaff";
			this.buttonStaff.Size = new System.Drawing.Size(130, 33);
			this.buttonStaff.TabIndex = 1;
			this.buttonStaff.Text = "Сотрудники";
			this.buttonStaff.UseVisualStyleBackColor = true;
			this.buttonStaff.Click += new System.EventHandler(this.buttonStaff_Click);
			// 
			// buttonProjectType
			// 
			this.buttonProjectType.Location = new System.Drawing.Point(468, 20);
			this.buttonProjectType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.buttonProjectType.Name = "buttonProjectType";
			this.buttonProjectType.Size = new System.Drawing.Size(120, 27);
			this.buttonProjectType.TabIndex = 2;
			this.buttonProjectType.Text = "Типы проектов";
			this.buttonProjectType.UseVisualStyleBackColor = true;
			this.buttonProjectType.Click += new System.EventHandler(this.buttonProjectType_Click);
			// 
			// buttonProjectNumber
			// 
			this.buttonProjectNumber.Location = new System.Drawing.Point(381, 77);
			this.buttonProjectNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.buttonProjectNumber.Name = "buttonProjectNumber";
			this.buttonProjectNumber.Size = new System.Drawing.Size(120, 27);
			this.buttonProjectNumber.TabIndex = 3;
			this.buttonProjectNumber.Text = "Номера проектов";
			this.buttonProjectNumber.UseVisualStyleBackColor = true;
			this.buttonProjectNumber.Click += new System.EventHandler(this.buttonProjectNumber_Click);
			// 
			// buttonPost
			// 
			this.buttonPost.Location = new System.Drawing.Point(248, 20);
			this.buttonPost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.buttonPost.Name = "buttonPost";
			this.buttonPost.Size = new System.Drawing.Size(137, 27);
			this.buttonPost.TabIndex = 4;
			this.buttonPost.Text = "Должности";
			this.buttonPost.UseVisualStyleBackColor = true;
			this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(636, 137);
			this.Controls.Add(this.buttonPost);
			this.Controls.Add(this.buttonProjectNumber);
			this.Controls.Add(this.buttonProjectType);
			this.Controls.Add(this.buttonStaff);
			this.Controls.Add(this.buttonPurpose);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "FormMain";
			this.Text = "Меню";
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPurpose;
        private System.Windows.Forms.Button buttonStaff;
        private System.Windows.Forms.Button buttonProjectType;
        private System.Windows.Forms.Button buttonProjectNumber;
        private System.Windows.Forms.Button buttonPost;
    }
}