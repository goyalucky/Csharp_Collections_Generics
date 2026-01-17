using System;

namespace ChatCleanupSystem
{
    // Represents a chat message
    public class Message
    {
        public string Text;
        public DateTime Time;
        public bool IsRead;
        public bool IsStarred;

        public Message(string text, DateTime time, bool read, bool starred)
        {
            Text = text;
            Time = time;
            IsRead = read;
            IsStarred = starred;
        }
    }
}
