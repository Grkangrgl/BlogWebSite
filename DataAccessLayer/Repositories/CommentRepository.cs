using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    internal class CommentRepository : IGenericDal<Comment>
    {
        public void delete(Comment t)
        {
            throw new NotImplementedException();
        }

        public Comment GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetListAll()
        {
            throw new NotImplementedException();
        }

        public void insert(Comment t)
        {
            throw new NotImplementedException();
        }

        public List<Comment> list()
        {
            throw new NotImplementedException();
        }

        public void update(Comment t)
        {
            throw new NotImplementedException();
        }
    }
}
