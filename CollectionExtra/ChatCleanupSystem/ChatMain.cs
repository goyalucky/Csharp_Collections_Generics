/* Chat Message Cleanup System
Problem Statement - Implement message cleanup logic.
Use: ● Dictionary<string, LinkedList<Message>>
Tasks
1. Delete messages:
○ Older than 30 days
○ Read and not starred
2. Fetch last N valid messages efficiently.

Edge Cases
● Deleting while traversing LinkedList
● Message exactly 30 days old
● All messages deleted
● Maintaining message order
● Null message references */

using System;
using System.Collections.Generic;

namespace ChatCleanupSystem
{
    public class ChatMain
    {
        public static void Start()
        {
            Dictionary<string, LinkedList<Message>> chats = new Dictionary<string, LinkedList<Message>>();
            chats["user1"] = new LinkedList<Message>();
            chats["user1"].AddLast(new Message("Hello",
                DateTime.Now.AddDays(-40), true, false));
            chats["user1"].AddLast(new Message("Important",
                DateTime.Now.AddDays(-10), true, true));
            chats["user1"].AddLast(new Message("Recent",
                DateTime.Now.AddDays(-2), false, false));

            // Cleanup
            ChatService.Cleanup(chats);

            // Fetch last 2 messages
            var msgs = ChatService.GetLastMessages(chats, "user1", 2);

            // Last 2 messages 
            foreach (var m in msgs)
                Console.WriteLine(m.Text);
        }
    }
}