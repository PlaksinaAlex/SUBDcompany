using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.Tables;

namespace Database.Implements
{
	public class StaffStorage
	{
		public List<Staff> GetFullList()
		{
			using var context = new CompanyDatabase();
			return context.Staffs
				.ToList();
		}
		public List<Staff> GetFilteredList(int rate)
		{
			
			using var context = new CompanyDatabase();
			return context.Staffs
			.Where(rec => rec.StaffRate == rate)
			.ToList();
		}

		public Staff GetElement(int id)
        {
            using var context = new CompanyDatabase();
            var element = context.Staffs
            .FirstOrDefault(rec => rec.Id == id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            return element;
        }

		public void Insert(Staff model)
        {
            using var context = new CompanyDatabase();
            var element = context.Posts.FirstOrDefault(rec => rec.Id == model.Post.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            model.Post= element;
            var element2 = context.ProjectNumbers.FirstOrDefault(rec => rec.Id == model.ProjectNumber.Id);
            if (element2 == null)
            {
                throw new Exception("Элемент не найден");
            }
            model.ProjectNumber = element2;
            context.Staffs.Add(model);
            context.SaveChanges();
        }

        public void Update(Staff model)
        {
            using var context = new CompanyDatabase();
            var element = context.Staffs.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            var element2 = context.Posts.FirstOrDefault(rec => rec.Id == model.Post.Id);
            if (element2 == null)
            {
                throw new Exception("Элемент не найден");
            }
            var element3 = context.ProjectNumbers.FirstOrDefault(rec => rec.Id == model.ProjectNumber.Id);
            if (element3 == null)
            {
                throw new Exception("Элемент не найден");
            }
            model.Post = element2;
            model.ProjectNumber = element3;

            element.Post = model.Post;
            element.ProjectNumber = model.ProjectNumber;
            element.StaffName = model.StaffName;
            element.StaffRate = model.StaffRate;
            element.Purposes = model.Purposes;
            context.SaveChanges();
        }

        public void Delete(Staff model)
        {
            using var context = new CompanyDatabase();
            Staff element = context.Staffs.FirstOrDefault(rec => rec.Id ==model.Id);
            if (element != null)
            {
                context.Staffs.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }
	}
}
