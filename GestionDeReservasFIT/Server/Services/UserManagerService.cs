using AutoMapper;
using GestionDeReservasFIT.Server.Services.Interfaces;
using GestionDeReservasFIT.Shared;
using Microsoft.EntityFrameworkCore;

namespace GestionDeReservasFIT.Server.Services
{
    public class UserManagerService : IUserService
    {
        readonly ReservasGestionContext _context = new();
        public UserManagerService(ReservasGestionContext context, IMapper mapper)
        {
            _context = context;
        }

        public User getUser(int Id)
        {
            try
            {
                User? user = _context.Users.Find(Id);
                if (user != null)
                {
                    return user;
                }
                else
                {
                    throw new ArgumentNullException(Id.ToString(), "No encontrado o no existe");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        public List<User> getUsers()
        {
            try
            {
                var list = _context.Users.Where(x => x.Deleted != true).ToList();

                return list;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        public void newUser(User user)
        {
            try
            {
                if (user.Id != 0)
                {
                    user.UpdateDate = DateTime.Now;
                    user.UpdateBy = 1;
                    _context.Entry(user).State = EntityState.Modified;
                }
                else
                {
                    user.CreatedDate = DateTime.Now;
                    user.CreatedBy = 1;
                    user.UpdateDate = DateTime.Now;
                    user.UpdateBy = 1;
                    user.Deleted = false;
                    _context.Users.Add(user);
                }
                _context.SaveChanges();

            }
            catch (Exception e)
            { }
        }


        public void deleteUser(int Id)
        {
            try
            {
                User? user = _context.Users.Find(Id);
                if (user != null)
                {
                    user.Deleted = true;
                    user.DeletedDate = DateTime.Now;
                    user.DeletedBy = 1;
                    _context.Entry(user).State = EntityState.Modified;
                    _context.SaveChanges();
                }
                else
                {
                    throw new ArgumentNullException(Id.ToString(), "No encontrado o no existe");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }


        public void updateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
