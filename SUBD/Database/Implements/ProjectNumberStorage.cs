using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.Tables;

namespace Database.Implements
{
	public class ProjectNumberStorage
	{
        public List<ProjectNumber> GetFullList()
        {
            using var context = new CompanyDatabase();
            return context.ProjectNumbers
                .ToList();
        }
        public List<ProjectNumber> GetFilteredList(string typename)
        {

            using var context = new CompanyDatabase();
            return context.ProjectNumbers
            .Where(rec => rec.ProjectType.ProjectTypeName == typename)
            .ToList();
        }

        public ProjectNumber GetElement(int id)
        {
            using var context = new CompanyDatabase();
            var element = context.ProjectNumbers
            .FirstOrDefault(rec => rec.Id == id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            return element;
        }

        public void Insert(ProjectNumber model)
        {
            using var context = new CompanyDatabase();
            var element = context.ProjectTypes.FirstOrDefault(rec => rec.Id == model.ProjectType.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            model.ProjectType = element;
            context.ProjectNumbers.Add(model);
            context.SaveChanges();
        }

        public void Update(ProjectNumber model)
        {
            using var context = new CompanyDatabase();
            var element = context.ProjectNumbers.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            var element2 = context.ProjectTypes.FirstOrDefault(rec => rec.Id == model.ProjectType.Id);
            if (element2 == null)
            {
                throw new Exception("Элемент не найден");
            }
            model.ProjectType = element2;
     
            element.ProjectNumberName = model.ProjectNumberName;
            element.ProjectType = model.ProjectType;
            element.Staffs = model.Staffs;
            context.SaveChanges();
        }

        public void Delete(ProjectNumber model)
        {
            using var context = new CompanyDatabase();
            ProjectNumber element = context.ProjectNumbers.FirstOrDefault(rec => rec.Id == model.Id);
            if (element != null)
            {
                context.ProjectNumbers.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }

    }
}
