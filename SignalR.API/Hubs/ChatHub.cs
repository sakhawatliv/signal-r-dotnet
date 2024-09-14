using Microsoft.AspNetCore.SignalR;

namespace SignalR.API.Hubs
{
    public  sealed class ChatHub: Hub
    {
        public override async Task OnConnectedAsync()
        {   
            await Clients.All.SendAsync("ReceiveMessage", $"{Context.ConnectionId}");
        }
    }
}
