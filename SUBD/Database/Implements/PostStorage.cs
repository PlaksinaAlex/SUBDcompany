using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.Tables;

namespace Database.Implements
{
	public class PostStorage
	{
		public List<Post> GetFullList()
		{
			using var context = new CompanyDatabase();
			return context.Posts
				.ToList();
		}
		public List<Post> GetFilteredList(int rate)
		{
			using var context = new CompanyDatabase();
			return context.Posts
			.Where(rec => rec.PostRate == rate)
			.ToList();
		}
	}
}
