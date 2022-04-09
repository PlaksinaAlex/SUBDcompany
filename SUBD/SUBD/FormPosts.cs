using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Database.Tables;
using Database.Implements;

namespace SUBD
{
	public partial class FormPosts : Form
	{
		PostStorage postStorage;
		public FormPosts()
		{
			InitializeComponent();
			postStorage = new PostStorage();
		}



		private void ButtonAdd_Click(object sender, EventArgs e)
		{
			var form = Program.Container.Resolve<FormComponent>();
			if (form.ShowDialog() == DialogResult.OK)
			{
				LoadData();
			}
		}

	}
}
