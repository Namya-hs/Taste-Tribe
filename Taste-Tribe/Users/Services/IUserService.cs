namespace Users.Services
{
    public interface IUserService
    {
        Task<string> SendMessage(string topic, string message);
    }
}
