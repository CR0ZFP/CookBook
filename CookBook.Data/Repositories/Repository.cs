using CookBook.Entities.Helpers;

namespace CookBook.Data.Repositories
{
    public class Repository<T> where T : class, IIdEntity
    {
        CookBookContext ctx;

        public Repository(CookBookContext ctx)
        {
            this.ctx = ctx;
        }

        public IQueryable<T> GetAll()
        {
            return ctx.Set<T>();
        }

        public void Create(T entity)
        {
            ctx.Set<T>().Add(entity);
            ctx.SaveChanges();

        }

        public T FindById(string id)
        {
            return ctx.Set<T>().First(t => t.Id == id);
        }
        public void Delete(T entity)
        {
            ctx.Set<T>().Remove(entity);
            ctx.SaveChanges();
        }

        public void DeleteById(string id)
        {
            var entity = FindById(id);
            ctx.Set<T>().Remove(entity);
            ctx.SaveChanges();
        }

        public void Update(T entity)
        {
            var oldEntity = FindById(entity.Id);

            foreach (var prop in typeof(T).GetProperties())
            {
                prop.SetValue(oldEntity, prop.GetValue(entity));
            }
            ctx.Set<T>().Update(oldEntity);
            ctx.SaveChanges();
        }
    }
}
