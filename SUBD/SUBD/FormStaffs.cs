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
	public partial class FormStaffs : Form
	{
		StaffStorage staffStorage;
		public FormStaffs()
		{
			InitializeComponent();
			staffStorage = new StaffStorage();
		}
		private void LoadData()
		{
			try
			{
				List<Staff> list;
				if (textBoxFiltered.Text != "")
				{
					if (!int.TryParse(textBoxFiltered.Text, out int temp))
					{
						MessageBox.Show("Введите правильную надбавку!", "Ошибка", MessageBoxButtons.OK,
			  MessageBoxIcon.Error);
						return;
					}
					list = staffStorage.GetFilteredList(Convert.ToInt32(textBoxFiltered.Text));
				}
				else
				{
					list = staffStorage.GetFullList();
				}
				if (list != null)
				{
					dataGridView.DataSource = list;
					dataGridView.Columns[0].Visible = false;
					dataGridView.Columns[1].Visible = false;
					dataGridView.Columns[2].Visible = false;
					dataGridView.Columns[3].Visible = false;
					dataGridView.Columns[4].Visible = false;
					dataGridView.Columns[10].Visible = false;
					dataGridView.Columns[11].Visible = false;
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
			if (textBoxStaffName.Text == "")
			{
				MessageBox.Show("Заполните название", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (!int.TryParse(textBoxIDPost.Text, out int temp))
			{
				MessageBox.Show("Введите айди должности!", "Ошибка", MessageBoxButtons.OK,
					   MessageBoxIcon.Error);
				return;
			}
			if (!int.TryParse(textBoxIDProject.Text, out temp))
			{
				MessageBox.Show("Введите правильно айди проекта!", "Ошибка", MessageBoxButtons.OK,
					   MessageBoxIcon.Error);
				return;
			}
			string name = textBoxStaffName.Text;
			textBoxStaffName.Text = "";
			int rate = Convert.ToInt32(textBoxStaffRate.Text);
			textBoxStaffRate.Text = "";
			int post = Convert.ToInt32(textBoxIDPost.Text);
			textBoxIDPost.Text = "";
			int num = Convert.ToInt32(textBoxIDProject.Text);
			textBoxIDProject.Text = "";
			try
			{
				staffStorage.Insert(new Staff() { StaffName = name, StaffRate = rate, Post = new Post() { Id = post }, ProjectNumber = new ProjectNumber() { Id = num } });
			}
			catch
			{
				MessageBox.Show("Ошибка при добавлении", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			LoadData();
		}

		private void buttonRefresh_Click(object sender, EventArgs e)
		{
			LoadData();
		}

		private void FormStaffs_Load(object sender, EventArgs e)
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
			if (textBoxStaffName.Text == "")
			{
				MessageBox.Show("Заполните название", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (!int.TryParse(textBoxIDPost.Text, out temp))
			{
				MessageBox.Show("Введите айди должности!", "Ошибка", MessageBoxButtons.OK,
					   MessageBoxIcon.Error);
				return;
			}
			if (!int.TryParse(textBoxIDProject.Text, out temp))
			{
				MessageBox.Show("Введите правильно айди проекта!", "Ошибка", MessageBoxButtons.OK,
					   MessageBoxIcon.Error);
				return;
			}
			int id = Convert.ToInt32(textBoxIdUpdate.Text);
			textBoxIdUpdate.Text = "";
			string name = textBoxStaffName.Text;
			textBoxStaffName.Text = "";
			int rate = Convert.ToInt32(textBoxStaffRate.Text);
			textBoxStaffRate.Text = "";
			int post = Convert.ToInt32(textBoxIDPost.Text);
			textBoxIDPost.Text = "";
			int num = Convert.ToInt32(textBoxIDProject.Text);
			textBoxIDProject.Text = "";
			try
			{
				staffStorage.Insert(new Staff() { Id = id, StaffName = name, StaffRate = rate, Post = new Post() { Id = post }, ProjectNumber = new ProjectNumber() { Id = num } });
			}
			catch
			{
				MessageBox.Show("Ошибка при добавлении", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
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
				staffStorage.Delete(new Staff() { Id = id });
			}
			catch
			{
				MessageBox.Show("Отсутствует запись с данным индексом", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			LoadData();
		}
	}
}
