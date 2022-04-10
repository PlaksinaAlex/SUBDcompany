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
	public partial class FormPurposes : Form
	{
		PurposeStorage purposeStorage;
		public FormPurposes()
		{
			InitializeComponent();
			purposeStorage = new PurposeStorage();
		}
		private void LoadData()
		{
			try
			{
				List<Purpose> list;
				if (string.IsNullOrEmpty(textBoxFiltered.Text))
				{
					if (!int.TryParse(textBoxFiltered.Text, out int temp))
					{
						MessageBox.Show("Введите правильно айди сотрудника!", "Ошибка", MessageBoxButtons.OK,
			  MessageBoxIcon.Error);
						return;
					}
					list = purposeStorage.GetFilteredList(Convert.ToInt32(textBoxFiltered.Text)); 
				}
				else
				{
					list = purposeStorage.GetFullList();
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
		private void buttonAdd_Click(object sender, EventArgs e)
		{
		
			if (!int.TryParse(textBoxHoursCount.Text, out int temp))
			{
				MessageBox.Show("Введите число часов!", "Ошибка", MessageBoxButtons.OK,
					   MessageBoxIcon.Error);
				return;
			}
			if (!int.TryParse(textBoxIDStaff.Text, out temp))
			{
				MessageBox.Show("Введите правильно айди сотрудника!", "Ошибка", MessageBoxButtons.OK,
					   MessageBoxIcon.Error);
				return;
			}
			int count = Convert.ToInt32(textBoxHoursCount.Text);
			textBoxHoursCount.Text = "";
			int num = Convert.ToInt32(textBoxIDStaff.Text);
			textBoxHoursCount.Text = "";
			DateTime date = dateTimePickerWorkDay.Value;
			try
			{
				purposeStorage.Insert(new Purpose() { HoursCount = count, workday = date, Staff = new Staff() { Id = num } });
			}
			catch
			{
				MessageBox.Show("Ошибка при добавлении", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			LoadData();

		}

		private void FormPurposes_Load(object sender, EventArgs e)
		{
			LoadData();
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
			if (!int.TryParse(textBoxHoursCount.Text, out temp))
			{
				MessageBox.Show("Введите число часов!", "Ошибка", MessageBoxButtons.OK,
					   MessageBoxIcon.Error);
				return;
			}
			if (!int.TryParse(textBoxIDStaff.Text, out temp))
			{
				MessageBox.Show("Введите правильно айди сотрудника!", "Ошибка", MessageBoxButtons.OK,
					   MessageBoxIcon.Error);
				return;
			}
			int id = Convert.ToInt32(textBoxIdUpdate.Text);
			textBoxIdUpdate.Text = "";
			int count = Convert.ToInt32(textBoxHoursCount.Text);
			textBoxHoursCount.Text = "";
			int num = Convert.ToInt32(textBoxIDStaff.Text);
			textBoxHoursCount.Text = "";
			DateTime date = dateTimePickerWorkDay.Value;
			try
			{
				purposeStorage.Insert(new Purpose() { Id = id, HoursCount = count, workday = date, Staff = new Staff() { Id = num } });
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
				purposeStorage.Delete(new Purpose() { Id = id });
			}
			catch
			{
				MessageBox.Show("Отсутствует запись с данным индексом", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			LoadData();
		}
	}
}
