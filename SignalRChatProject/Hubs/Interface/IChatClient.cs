namespace SignalRChatProject.Hubs.Interface
{
    public interface IChatClient
    {
        Task ReceiveMessage(string user, string message);
    }
}
