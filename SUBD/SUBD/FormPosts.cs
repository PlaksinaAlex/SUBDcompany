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
using Unity;

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

		private void LoadData()
		{
			try
			{
				List<Post> list;
				if (string.IsNullOrEmpty(textBoxFiltered.Text))
				{
					if (!int.TryParse(textBoxFiltered.Text, out int temp))
					{
						MessageBox.Show("Введите правильну ставку!", "Ошибка", MessageBoxButtons.OK,
			  MessageBoxIcon.Error);
						return;
					}
					list = postStorage.GetFilteredList(Convert.ToInt32(textBoxFiltered.Text));
				}
				else
				{
					list = postStorage.GetFullList();
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

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textBoxPostNameUpdate.Text))
			{
				MessageBox.Show("Заполните название", "Ошибка", MessageBoxButtons.OK,
					   MessageBoxIcon.Error);
				return;
			}
			if (string.IsNullOrEmpty(textBoxPostRateUpdate.Text))
			{
				MessageBox.Show("Введите ставку по должности!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (string.IsNullOrEmpty(textBoxIdUpdate.Text))
			{
				MessageBox.Show("Введите корректный Id", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			int id = Convert.ToInt32(textBoxIdUpdate.Text);
			textBoxIdUpdate.Text = "";
			string name = textBoxPostNameUpdate.Text;
			textBoxPostNameUpdate.Text = "";
			decimal rate = Convert.ToDecimal(textBoxPostRateUpdate.Text);
			textBoxPostRateUpdate.Text = "";
			try
			{
				postStorage.Update(new Post() { Id = id, PostName = name, PostRate = rate });
			}
			catch
			{
				MessageBox.Show("Отсутствует запись с данным индексом", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			LoadData();
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textBoxPostName.Text))
			{
				MessageBox.Show("Заполните название", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (string.IsNullOrEmpty(textBoxPostRate.Text))
			{
				MessageBox.Show("Введите ставку по должности!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			try
			{
				postStorage.Insert(new Post
				{
					PostName = textBoxPostName.Text,
					PostRate = Convert.ToDecimal(textBoxPostRate.Text),
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

		private void FormPosts_Load(object sender, EventArgs e)
		{
			LoadData();
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textBoxPostRate.Text))
			{
				MessageBox.Show("Введите корректный Id", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			int id = Convert.ToInt32(textBoxIdDelete.Text);
			textBoxIdDelete.Text = "";
			try
			{
				postStorage.Delete(new Post() { Id = id });
			}
			catch
			{
				MessageBox.Show("Отсутствует запись с данным индексом", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			LoadData();
		}
	}
}
