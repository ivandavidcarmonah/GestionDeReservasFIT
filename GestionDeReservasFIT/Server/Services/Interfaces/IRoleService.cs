using GestionDeReservasFIT.Shared;

namespace GestionDeReservasFIT.Server.Services.Interfaces
{
    public interface IRoleService
    {
        public List<Role> getRoles();
        public Role getRole(int id);
        public void newRole(Role value);
        public void deleteRole(int id);
        public void updateRole(Role value);
    }
}
