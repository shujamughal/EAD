using Microsoft.AspNetCore.SignalR;

namespace SignalRBasics.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage( string m)
        {
            await Clients.All.SendAsync("ReceiveMessage", m);
            //await Clients.Caller.SendAsync("ReceiveMessage", m);
            //await Clients.Others.SendAsync("ReceiveMessage", m);
        }
    }
    
    
}
