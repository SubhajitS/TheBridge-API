using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;

namespace PWAAPI.Hubs
{
    public class MainHub : Hub
    {
        public async Task SendMessage(string user, object message)
        {           
            Console.WriteLine(user, message.ToString()); 
            await Clients.Others.SendAsync("ReceiveMessage", user, message);
        }
    }
}