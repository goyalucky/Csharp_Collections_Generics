using System;
using System.Collections.Generic;

namespace ChatCleanupSystem
{
    // Handles message cleanup logic
    public class ChatService
    {
        private const int DAYS_LIMIT = 30;

        // Delete old and irrelevant messages safely
        public static void Cleanup(Dictionary<string, LinkedList<Message>> chats)
        {
            foreach (var chat in chats.Values)
            {
                var node = chat.First;

                while (node != null)
                {
                    var next = node.Next; // safe traversal

                    Message msg = node.Value;

                    // Skip null messages
                    if (msg == null)
                    {
                        chat.Remove(node);
                    }
                    // Delete if older than 30 days OR read and not starred
                    else if ((DateTime.Now - msg.Time).Days > DAYS_LIMIT ||
                             (msg.IsRead && !msg.IsStarred))
                    {
                        chat.Remove(node);
                    }
                    node = next;
                }
            }
        }

        // Fetch last N messages efficiently
        public static List<Message> GetLastMessages(
            Dictionary<string, LinkedList<Message>> chats,string userId,int n)
        {
            List<Message> result = new List<Message>();
            if (!chats.ContainsKey(userId) || n <= 0)
                return result;

            var node = chats[userId].Last;

            // Traverse backwards for efficiency
            while (node != null && result.Count < n)
            {
                if (node.Value != null)
                    result.Add(node.Value);
                node = node.Previous;
            }
        // maintain the reverse order
            result.Reverse(); 
            return result;
        }
    }
}
