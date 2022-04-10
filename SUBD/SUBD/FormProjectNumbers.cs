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
	public partial class FormProjectNumbers : Form
	{
		ProjectNumberStorage projectNumberStorage;
		public FormProjectNumbers()
		{
			InitializeComponent();
			projectNumberStorage = new ProjectNumberStorage();
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{

		}

		private void LoadData()
		{
			try
			{
				List<ProjectNumber> list;
				if (string.IsNullOrEmpty(textBoxFiltered.Text))
				{
					if (!int.TryParse(textBoxFiltered.Text, out int temp))
					{
						MessageBox.Show("Введите правильну надбавку!", "Ошибка", MessageBoxButtons.OK,
			  MessageBoxIcon.Error);
						return;
					}
					list = projectNumberStorage.GetFilteredList(Convert.ToInt32(textBoxFiltered.Text));
				}
				else
				{
					list = projectNumberStorage.GetFullList();
				}
				if (list != null)
				{
					dataGridView.DataSource = list;
					dataGridView.Columns[0].Visible = false;
					dataGridView.Columns[1].AutoSizeMode =
					DataGridViewAutoSizeColumnMode.Fill;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
			   MessageBoxIcon.Error);
			}
		}
	}
}
