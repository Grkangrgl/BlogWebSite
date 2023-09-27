using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        Context c = new Context();
        public void AddCategory(Category category)
        {
            c.Categories.Add(category);
            c.SaveChanges();
        }

        public void delete(Category t)
        {
            throw new NotImplementedException();
        }

        public void DeleteCategory(Category category)
        {
            c.Categories.Remove(category);
            c.SaveChanges();  
        }

        public Category GetById(int id)
        {
            return c.Categories.Find(id);
        }

        public List<Category> GetListAll()
        {
            throw new NotImplementedException();
        }

        public void insert(Category t)
        {
            throw new NotImplementedException();
        }

        public List<Category> ListAllCategory()
        {
            return c.Categories.ToList();
        }

        public void update(Category t)
        {
            throw new NotImplementedException();
        }

        public void UpdateCategory(Category category)
        {
            c.Categories.Update(category);
            c.SaveChanges();
        }
    }
}
