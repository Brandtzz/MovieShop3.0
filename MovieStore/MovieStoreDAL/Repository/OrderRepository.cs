using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MovieStoreDAL
{
    public class OrderRepository : IRepository<Order>
    {
        private MovieStoreDbContext db = new MovieStoreDbContext();

        public void Add(Order entity)
        {
            using (var db = new MovieStoreDbContext())
            {
                entity.OrderLines.ForEach(x =>
                {
                    if (db.Entry(x.Movie).State == EntityState.Detached)
                    {
                        db.Movies.Attach(x.Movie);
                    }
                });    

                db.Customers.Attach(entity.Customer);
                db.Orders.Add(entity);
                db.SaveChanges();
            }
        }

        public Order Edit(Order entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            db.SaveChanges();
            return entity;

        }

        public Order Get(int id)
        {
            return db.Orders.FirstOrDefault(a => a.Id == id);
        }

        public IEnumerable<Order> GetAll()
        {
            return db.Orders;
        }

        public Order Remove(int id)
        {
            Order order = db.Orders.FirstOrDefault(a => a.Id == id);

            db.Orders.Remove(order);
            db.SaveChanges();
            return order;
        }
    }
}
