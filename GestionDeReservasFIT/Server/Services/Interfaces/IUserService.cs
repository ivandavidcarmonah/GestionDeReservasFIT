using GestionDeReservasFIT.Shared;

namespace GestionDeReservasFIT.Server.Services.Interfaces
{
    public interface IUserService
    {
        public List<User> getUsers();
        public User getUser(int id);
        public void newUser(User user);
        public void deleteUser(int id);
        public void updateUser(User user);

    }
}
