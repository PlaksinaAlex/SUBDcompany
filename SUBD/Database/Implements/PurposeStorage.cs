using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.Tables;

namespace Database.Implements
{
	public class PurposeStorage
	{
        public List<Purpose> GetFullList()
        {
            using var context = new CompanyDatabase();
            return context.Purposes
                .ToList();
        }
        public List<Purpose> GetFilteredList(int count)
        {
            using var context = new CompanyDatabase();
            return context.Purposes
            .Where(rec => rec.HoursCount == count)
            .ToList();
        }

        public Purpose GetElement(int id)
        {
            using var context = new CompanyDatabase();
            var element = context.Purposes
            .FirstOrDefault(rec => rec.Id == id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            return element;
        }

        public void Insert(Purpose model)
        {
            using var context = new CompanyDatabase();
            var element = context.Staffs.FirstOrDefault(rec => rec.Id == model.Staff.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            model.Staff = element;
            context.Purposes.Add(model);
            context.SaveChanges();
        }

        public void Update(Purpose model)
        {
            using var context = new CompanyDatabase();
            var element = context.Purposes.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            var element2 = context.Staffs.FirstOrDefault(rec => rec.Id == model.Staff.Id);
            if (element2 == null)
            {
                throw new Exception("Элемент не найден");
            }
            model.Staff = element2;
            element.HoursCount= model.HoursCount;
            element.Staff= model.Staff;
            element.workday = model.workday;
            context.SaveChanges();
        }

        public void Delete(Purpose model)
        {
            using var context = new CompanyDatabase();
            Purpose element = context.Purposes.FirstOrDefault(rec => rec.Id == model.Id);
            if (element != null)
            {
                context.Purposes.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }

    }
}
