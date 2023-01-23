using GestionDeReservasFIT.Server.Services.Interfaces;
using GestionDeReservasFIT.Shared;
using Microsoft.EntityFrameworkCore;

namespace GestionDeReservasFIT.Server.Services
{
    public class RoleManagerService : IRoleService
    {
        readonly ReservasGestionContext _context = new();

        public RoleManagerService(ReservasGestionContext context)
        {
            _context = context;

        }
        public Role getRole(int Id)
        {
            try
            {
                Role? element = _context.Roles.Find(Id);
                if (element != null)
                {
                    return element;
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

        public List<Role> getRoles()
        {
            try
            {
                return _context.Roles.Where(x => x.Deleted != true).ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }


        public void newRole(Role value)
        {
            try
            {
                if (value.Id != 0)
                {
                    value.UpdateDate = DateTime.Now;
                    value.UpdateBy = 1;
                    _context.Entry(value).State = EntityState.Modified;
                }
                else
                {
                    value.CreatedDate = DateTime.Now;
                    value.CreatedBy = 1;
                    value.UpdateDate = DateTime.Now;
                    value.UpdateBy = 1;
                    value.Deleted = false;
                    _context.Roles.Add(value);
                }
                _context.SaveChanges();

            }
            catch (Exception e)
            { }
        }
        public RoleManagerService(RoleManagerService roleManagerService) { }

        public void deleteRole(int id)
        {
            try
            {
                Role? value = _context.Roles.Find(id);
                if (value != null)
                {
                    value.Deleted = true;
                    value.DeletedDate = DateTime.Now;
                    value.DeletedBy = 1;
                    _context.Entry(value).State = EntityState.Modified;
                    _context.SaveChanges();
                }
                else
                {
                    throw new ArgumentNullException(id.ToString(), "No encontrado o no existe");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }




        public void updateRole(Role value)
        {
            throw new NotImplementedException();
        }
    }
}
