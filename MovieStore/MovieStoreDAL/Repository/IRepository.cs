﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreDAL
{
   public interface IRepository <T>
    {
        IEnumerable<T> GetAll();

        T Get(int id);

        T Add(T entity);

        T Edit(T entity);

        T Remove(int id);

    }
}
