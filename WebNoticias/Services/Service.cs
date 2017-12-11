using DataAcces;
using DataAcces.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.DTO;

namespace Services
{
    public class Service
    {
        private Repository<User> UserRepo { get; set; }
        private Repository<News> NewsRepo { get; set; }

        public Service()
        {
            this.UserRepo = new Repository<User>();
            this.NewsRepo = new Repository<News>();
        }

        public UserDTO CreateUser()
        {
            return new UserDTO();
        }

        public NewsDTO CreateNews()
        {
            return new NewsDTO();
        }

        public List<UserDTO> ShowAllUsers()
        {
            var UserList = new List<UserDTO>();
            foreach (var user in this.UserRepo.Set().ToList())
            {
                UserList.Add(new UserDTO
                {
                    Id = user.Id,
                    Name = user.Name,
                    Password = user.Password
                });
            }
            return UserList;
        }

        public void PushUserToDB(UserDTO user)
        {
            this.UserRepo.Persist(this.MapUser(user));
            this.UserRepo.SaveChanges();
        }

        public void PushNewsToDB(NewsDTO news)
        {
            this.NewsRepo.Persist(this.MapNews(news));
            this.NewsRepo.SaveChanges();
        }

        private User MapUser(UserDTO user)
        {
            return new User
            {
                Id = user.Id,
                Name = user.Name,
                Password = user.Password
            };
        }

        private News MapNews(NewsDTO news)
        {
            return new News
            {
                Title = news.Title,
                Description = news.Description,
                UserCreatedId = news.UserCreatedId,
                UserModifiedId = news.UserModifiedId,
                DateCreated = news.DateCreated,
                DateModified = news.DateModified
            };
        }

        public string DeleteUser(string name)
        {
            try
            {
                this.UserRepo.Remove(this.UserRepo.Set().Where(u => u.Name == name).SingleOrDefault());
                this.UserRepo.SaveChanges();
                return "Usuario eliminado con exito";
            }
            catch (Exception)
            {
                return "El usuario no existe.";
            }
            

        }

        public void DeleteNews(int id)
        {
            this.NewsRepo.Remove(this.NewsRepo.GetById(id));
            this.NewsRepo.SaveChanges();
        }

        public string UpdateUser(string name)
        {
            return "a";
        }

        //public string UpdateNews (int id)
        //{

        //}
    }
}
