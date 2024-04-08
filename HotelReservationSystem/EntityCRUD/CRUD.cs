using System;
using System.Collections.Generic;

namespace HotelReservationSystem.EntityCRUD
{
    public interface ICRUD<T>
    {
        void Create(T item);

        T GetById(int id);

        IEnumerable<T> GetAll();

        void Update(int id, T updatedItem);

        void Delete(int id);
    }
}

