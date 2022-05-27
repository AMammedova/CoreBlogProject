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
    public class UserRepository : IUserDal
    {
        private readonly Context _context;
        public UserRepository()
        {
            _context = new Context();
        }
        public void Add(User user)
        {
            _context.Add(user);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            User user = _context.Users.Where(c => c.UserId == id).FirstOrDefault();
            _context.SaveChanges();
        }

        public User GetById(int id)
        {
            return _context.Users.Find(id);

        }

        public List<User> GetList()
        {
            return _context.Users.ToList();
        }

        public void Update(User user)
        {
            _context.Update(user);
            _context.SaveChanges();
        }
    }
}
