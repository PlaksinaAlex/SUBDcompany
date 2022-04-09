using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.Tables;

namespace Database.Implements
{
	public class ProjectTypeStorage
	{
        public List<ProjectType> GetFullList()
        {
            using var context = new CompanyDatabase();
            return context.ProjectTypes
                .ToList();
        }

        public List<ProjectType> GetFilteredList(int rate)
        {
            using var context = new CompanyDatabase();
            return context.ProjectTypes
            .Where(rec => rec.ProjectTypeRate == rate)
            .ToList();
        }

        public ProjectType GetElement(int id)
        {
            using var context = new CompanyDatabase();
            var element = context.ProjectTypes
            .FirstOrDefault(rec => rec.Id == id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            return element;
        }

        public void Insert(ProjectType model)
        {
            using var context = new CompanyDatabase();
            context.ProjectTypes.Add(model);
            context.SaveChanges();
        }

        public void Update(ProjectType model)
        {
            using var context = new CompanyDatabase();
            var element = context.ProjectTypes.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            element.ProjectNumbers = model.ProjectNumbers;
            element.ProjectTypeName = model.ProjectTypeName;
            element.ProjectTypeRate = model.ProjectTypeRate;
            context.SaveChanges();
        }

        public void Delete(ProjectType model)
        {
            using var context = new CompanyDatabase();
            ProjectType element = context.ProjectTypes.FirstOrDefault(rec => rec.Id == model.Id);
            if (element != null)
            {
                context.ProjectTypes.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }

    }
}
