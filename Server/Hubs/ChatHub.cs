using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace AngelaMyersChatApp.Server.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }

         public async Task SendingMessage(string user, string message)
        {
            await Clients.Others.SendAsync("SendingMessage", user, message);
        }
    }
}