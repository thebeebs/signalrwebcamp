using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace WebApplication24
{
    public class ChatHub : Hub
    {
        static List<Tuple<string, string>> messages;

        public ChatHub()
        {

            if (messages == null)
            {
                messages = new List<Tuple<string, string>>();
            }
        }
        public void Logon()
        {
            Clients.Caller.loadHistory(messages);
        }

        public void Send(string name, string message)
        {
            // Call the broadcastMessage method to update clients.
            messages.Add(new Tuple<string, string>(name, message));
            Clients.All.broadcastMessage(name, message);
        }
    }
}