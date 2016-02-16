﻿using System.Collections.Generic;

namespace Investment.Domain.Interfaces
{
    public interface IBaseRepository<T>
    {
        IEnumerable<T> Get();
        T GetByKey(string Key);
        void AddOrUpdate(T element);
        void Delete(T element);
        void SaveChanges();
    }
}