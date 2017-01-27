using System;

namespace TestSample.Core
{
    public class ChatMessage
    {
        public string Content { get; set; }

        public User CreatedBy { get; set; }

        public bool IsSender { get; set; }

        public DateTime CreatedUtcDate { get; set; }
    }
}