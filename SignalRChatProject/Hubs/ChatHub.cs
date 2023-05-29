using Microsoft.AspNetCore.SignalR;

namespace SignalRChatProject.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)// this method can be called by a connected client to send a message to all clients.
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
