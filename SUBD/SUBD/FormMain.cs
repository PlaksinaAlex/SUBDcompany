using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SUBD
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
		}

		private void buttonPurpose_Click(object sender, EventArgs e)
		{
			FormPurposes form = new FormPurposes();
			form.ShowDialog();
		}

		private void buttonStaff_Click(object sender, EventArgs e)
		{
			FormStaffs form = new FormStaffs();
			form.ShowDialog();
		}

		private void buttonPost_Click(object sender, EventArgs e)
		{
			FormPosts form = new FormPosts();
			form.ShowDialog();
		}

		private void buttonProjectNumber_Click(object sender, EventArgs e)
		{
			FormProjectNumbers form = new FormProjectNumbers();
			form.ShowDialog();
		}

		private void buttonProjectType_Click(object sender, EventArgs e)
		{
			FormProjectType form = new FormProjectType();
			form.ShowDialog();
		}
	}
}
