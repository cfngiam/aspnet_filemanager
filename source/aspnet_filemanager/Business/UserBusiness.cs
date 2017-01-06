using aspnet_filemanager.Helpers;
using aspnet_filemanager.Models;
using aspnet_filemanager.Repository;
using System;
using System.Collections.Generic;

namespace aspnet_filemanager.Business
{
    public class UserBusiness
    {
        private UserRepository userRepository = new UserRepository();

        public List<User> GetAll()
        {
            return userRepository.GetAll();
        }

        public User GetById(int? id)
        {
            if (id == null)
            {
                throw new Exception("Invalid User.");
            }
            else
            {
                User user = userRepository.GetById(id);

                if (user == null)
                {
                    throw new Exception("User not found.");
                }
                else
                {
                    return user;
                }
            }
        }

        public User GetBySearch(string email)
        {
            if (String.IsNullOrEmpty(email))
            {
                throw new Exception("Invalid email.");
            }
            else
            {
                User user = userRepository.GetBySearch(email);

                if (user == null)
                {
                    throw new Exception("User not found.");
                }
                else
                {
                    return user;
                }
            }
        }

        public void Save(User user)
        {
            userRepository.Save(user);
        }

        public void Remove(int id)
        {
            userRepository.Remove(id);
        }

        public void LogInUser(string email, string password)
        {
            if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password))
            {
                password = Cryptography.CreateHash(password);
                User user = userRepository.CheckUserLoggin(email, password);

                if (user != null)
                {
                    if (user.IsActive)
                    {
                        SessionManager.SetUser(user);
                    }
                    else
                    {
                        throw new Exception("User is not activated.");
                    }
                }
                else
                {
                    throw new Exception("Invalid login or password.");
                }
            }
            else
            {
                throw new Exception("Please specify the Email and Password.");
            }
        }

        public void ResetPassword(string email)
        {
            try
            {
                User user = GetBySearch(email);
                if (user != null)
                {
                    //user.IsActive = false;
                    //user.ResetPasswordCode = user.Email + DateTime.Now.ToString();
                    //user.ResetPasswordHash = Cryptography.CreateHash(user.ResetPasswordCode);
                    //user.DtUpdate = DateTime.Now;
                    //Save(user);

                    //Mail.SendPasswordLinkByEmail(email, user.ResetPasswordCode);
                }
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
        }

        public void LogOffUser()
        {
            SessionManager.ReleaseUser();
        }
    }
}