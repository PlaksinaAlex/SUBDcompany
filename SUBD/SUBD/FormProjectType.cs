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
	public partial class FormProjectType : Form
	{
		ProjectTypeStorage projectTypeStorage;
		public FormProjectType()
		{
			InitializeComponent();
			projectTypeStorage = new ProjectTypeStorage();
		}

		private void LoadData()
		{
			try
			{
				List<ProjectType> list;
				if (string.IsNullOrEmpty(textBoxFiltered.Text))
				{
					if (!int.TryParse(textBoxFiltered.Text, out int temp))
					{
						MessageBox.Show("Введите правильну надбавку!", "Ошибка", MessageBoxButtons.OK,
			  MessageBoxIcon.Error);
						return;
					}
					list = projectTypeStorage.GetFilteredList(Convert.ToInt32(textBoxFiltered.Text));
				}
				else
				{
					list = projectTypeStorage.GetFullList();
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


		private void buttonRefresh_Click(object sender, EventArgs e)
		{
			LoadData();
		}

		private void FormProjectType_Load(object sender, EventArgs e)
		{
			LoadData();
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textBoxIdDelete.Text))
			{
				MessageBox.Show("Введите корректный Id", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			int id = Convert.ToInt32(textBoxIdDelete.Text);
			textBoxIdDelete.Text = "";
			try
			{
				projectTypeStorage.Delete(new ProjectType() { Id = id });
			}
			catch
			{
				MessageBox.Show("Отсутствует запись с данным индексом", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			LoadData();
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textBoxProjectTypeName.Text))
			{
				MessageBox.Show("Заполните название", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (string.IsNullOrEmpty(textBoxProjectTypeRate.Text))
			{
				MessageBox.Show("Введите ставку по должности!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			try
			{
				projectTypeStorage.Insert(new ProjectType
				{
					ProjectTypeName = textBoxProjectTypeName.Text,
					ProjectTypeRate = Convert.ToDecimal(textBoxProjectTypeRate.Text),
				});
				MessageBox.Show("Сохранение прошло успешно", "Сообщение",
			   MessageBoxButtons.OK, MessageBoxIcon.Information);
				DialogResult = DialogResult.OK;
				Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
			   MessageBoxIcon.Error);
			}
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textBoxProjectTypeNameUpdate.Text))
			{
				MessageBox.Show("Заполните название", "Ошибка", MessageBoxButtons.OK,
					   MessageBoxIcon.Error);
				return;
			}
			if (string.IsNullOrEmpty(textBoxIdUpdate.Text))
			{
				MessageBox.Show("Введите корректный Id", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			int id = Convert.ToInt32(textBoxIdUpdate.Text);
			textBoxIdUpdate.Text = "";
			string name = textBoxProjectTypeNameUpdate.Text;
			textBoxProjectTypeNameUpdate.Text = "";
			decimal rate = Convert.ToDecimal(textBoxProjectTypeRateUpdate.Text);
			textBoxProjectTypeRateUpdate.Text = "";
			try
			{
				projectTypeStorage.Update(new ProjectType() { Id = id, ProjectTypeName = name, ProjectTypeRate = rate });
			}
			catch
			{
				MessageBox.Show("Отсутствует запись с данным индексом", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			LoadData();
		}
	}
}
