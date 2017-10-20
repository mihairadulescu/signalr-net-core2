using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TESTING
{
    public class TestSignalR : Controller
    {
        private readonly IHubContext<NotificationHub> _notificationHub;

        public TestSignalR(IHubContext<NotificationHub> notificationHub)
        {
            _notificationHub = notificationHub;
        }
        // GET: /<controller>/
        public string Index()
        {
            _notificationHub.Clients.All.InvokeAsync("notify", "hey dude whats up");
            return "Mihai Testing";
        }
    }
}
