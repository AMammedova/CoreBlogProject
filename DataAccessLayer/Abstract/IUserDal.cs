using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
   public interface IUserDal
    {
        public void Add(User user);
        public void Delete(int id);
        public void Update(User user);

        public List<User> GetList();

        public User GetById(int id);

    }
}
