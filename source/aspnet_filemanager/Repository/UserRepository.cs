using aspnet_filemanager.Context;
using aspnet_filemanager.Helpers;
using aspnet_filemanager.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace aspnet_filemanager.Repository
{
    public class UserRepository
    {
        private aspnetFMContext db = new aspnetFMContext();

        public List<User> GetAll()
        {
            return db.User.ToList();
        }

        public User GetById(int? id)
        {
            return db.User.Find(id);
        }

        public void Save(User user)
        {
            if (user.Id == 0)
            {
                user.Password = Cryptography.CreateHash(user.Password);
                user.DtUpdate = DateTime.Now;
                db.User.Add(user);
                db.SaveChanges();
            }
            else
            {
                user.DtUpdate = DateTime.Now;
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void Remove(int id)
        {
            User user = db.User.Find(id);
            db.User.Remove(user);
            db.SaveChanges();
        }

        internal User GetBySearch(string email)
        {
            return db.User.FirstOrDefault(x => x.Email == email);
        }

        public User CheckUserLoggin(string email, string password)
        {
            return db.User.FirstOrDefault(x => x.Email == email && x.Password == password);
        }
    }
}