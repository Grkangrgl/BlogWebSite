﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void insert(T t); //t -> entity
        void delete(T t);
        void update(T t);
        List<T> GetListAll();
        T GetById(int id);
    }
}
