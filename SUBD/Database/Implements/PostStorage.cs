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

		 public Post GetElement(int id)
         {
            using var context = new CompanyDatabase();
            var element = context.Posts
            .FirstOrDefault(rec => rec.Id == id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            return element;
         }

		public void Insert(Post model)
        {
            using var context = new CompanyDatabase();
            context.Posts.Add(model);
            context.SaveChanges();
        }

		public void Update(Post model)
        {
            using var context = new CompanyDatabase();
            var element = context.Posts.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            element.PostName = model.PostName;  
            element.PostRate = model.PostRate;
            element.Staffs = model.Staffs;
            context.SaveChanges();
        }

        public void Delete(Post model)
        {
            using var context = new CompanyDatabase();
            Post element = context.Posts.FirstOrDefault(rec => rec.Id == model.Id);
            if (element != null)
            {
                context.Posts.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }

	}
}
