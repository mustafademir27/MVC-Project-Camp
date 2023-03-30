using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        //DbSet<Writer> _object;
        //Context c = new Context();
        //public void Delete(Category p)
        //{
        //    _object.Remove(p);
        //    c.SaveChanges();
        //}

        //public void Insert(Category p)
        //{
        //    _object.Add(p);
        //    c.SaveChanges();
        //}

        //public List<Writer> List()
        //{
        //    return _object.ToList();
        //}

        //public List<Writer> List(Expression<Func<Category, bool>> filter)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Update(Category p)
        //{
        //    c.SaveChanges();
        //}
        public void Delete(Category p)
        {
            throw new NotImplementedException();
        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Insert(Category p)
        {
            throw new NotImplementedException();
        }

        public List<Category> List()
        {
            throw new NotImplementedException();
        }

        public List<Category> List(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Category p)
        {
            throw new NotImplementedException();
        }
    }
}

/*
 ToList
Add
Remove
Find
yukarıdaki */