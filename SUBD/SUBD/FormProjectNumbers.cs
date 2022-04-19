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
			if (textBoxPrNumberName.Text == "")
			{
				MessageBox.Show("Заполните название", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (textBoxPrTypeName.Text == "")
			{
				MessageBox.Show("Введите корректный тип проекта", "Ошибка", MessageBoxButtons.OK,
					   MessageBoxIcon.Error);
				return;
			}
			string typename = textBoxPrTypeName.Text;
			textBoxPrTypeName.Text = "";
			string name = textBoxPrNumberName.Text;
			textBoxPrNumberName.Text = "";
			try
			{
				projectNumberStorage.Insert(new ProjectNumber()
				{
					ProjectNumberName = name,
					ProjectType = new ProjectType()
					{
						ProjectTypeName = typename
					}
				});
			}
			catch
			{
				MessageBox.Show("Ошибка при добавлении", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			LoadData();
		}

		private void LoadData()
		{
			try
			{
				List<ProjectNumber> list;
				if (textBoxFiltered.Text != "")
				{
					if (textBoxFiltered.Text != "")
					{
						MessageBox.Show("Введите правильно тип проекта!", "Ошибка", MessageBoxButtons.OK,
			  MessageBoxIcon.Error);
						return;
					}
					list = projectNumberStorage.GetFilteredList(textBoxFiltered.Text);
				}
				else
				{
					list = projectNumberStorage.GetFullList();
				}
				if (list != null)
				{
					dataGridView.DataSource = list;
					dataGridView.Columns[0].Visible = false;
					dataGridView.Columns[1].Visible = false;
					dataGridView.Columns[2].Visible = false;
					dataGridView.Columns[6].Visible = false;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
			   MessageBoxIcon.Error);
			}
		}

		private void buttonRefresh_Click(object sender, EventArgs e)
		{
			LoadData();
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			if (!int.TryParse(textBoxIdUpdate.Text, out int temp))
			{
				MessageBox.Show("Введите корректный Id ", "Ошибка", MessageBoxButtons.OK,
					   MessageBoxIcon.Error);
				return;
			}
			if (string.IsNullOrEmpty(textBoxPrNumberNameUpdate.Text))
			{
				MessageBox.Show("Заполните название", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (string.IsNullOrEmpty(textBoxPrTypeUpdate.Text))
			{
				MessageBox.Show("Введите корректный тип проекта", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			int id = Convert.ToInt32(textBoxIdUpdate.Text);
			string typename = textBoxPrTypeUpdate.Text;
			string name = textBoxPrNumberNameUpdate.Text;
			textBoxIdUpdate.Text = "";
			textBoxPrNumberNameUpdate.Text = "";
			textBoxPrTypeUpdate.Text = "";
			try
			{
				projectNumberStorage.Update(new ProjectNumber() { Id = id, ProjectNumberName = name, ProjectType = new ProjectType() { ProjectTypeName = typename } });
			}
			catch
			{
				MessageBox.Show("Отсутствует запись с данным индексом", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			LoadData();
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			if (!int.TryParse(textBoxIdDelete.Text, out int temp))
			{
				MessageBox.Show("Введите корректный Id", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			int id = Convert.ToInt32(textBoxIdDelete.Text);
			textBoxIdDelete.Text = "";
			try
			{
				projectNumberStorage.Delete(new ProjectNumber() 
				{
					Id = id
				});
			}
			catch
			{
				MessageBox.Show("Отсутствует запись с данным индексом", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			LoadData();
		}

		private void FormProjectNumbers_Load(object sender, EventArgs e)
		{
			LoadData();
		}
	}
}
