using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;

namespace TestSample.Core
{
    public class ChatViewModel : MvxViewModel
    {

        public ChatViewModel()
        {
            var chatMessages = new List<ChatMessage>()
            {
                new ChatMessage() { Content = "Hey" },
                new ChatMessage() { Content = "Hey" },
                new ChatMessage() { Content = "MvvmCross is ok?" },
                new ChatMessage() { Content = "MvvmCross is great."},
                new ChatMessage() { Content = "Ok." },
                new ChatMessage() { Content = "Ok." },
                new ChatMessage() { Content = "Bye." }
            };

            User sender = new User()
            {
                AvatarUrl = "http://aib.edu.au/blog/wp-content/uploads/2015/08/bill-gates-jpg.jpg",
                Id = "1",
                Name = "Bill Gates",
                Initials = "BG"
            };

            User receiver = new User()
            {
                AvatarUrl =
                    "https://thechive.files.wordpress.com/2015/04/bill-gates-daughter-sure-grew-up-6-photos-41.jpg?quality=85&strip=info&w=600",
                Id = "2",
                Name = string.Empty,
                Initials = "JK"
            };
            for (int i = 0; i < chatMessages.Count; ++i)
            {
                chatMessages[i].CreatedUtcDate = DateTime.UtcNow.Subtract(TimeSpan.FromMinutes(i));
                chatMessages[i].IsSender = i % 2 == 0;
                if (i % 2 == 0)
                    chatMessages[i].CreatedBy = sender;
                else
                    chatMessages[i].CreatedBy = receiver;
            }
            Messages = new MvxObservableCollection<ChatMessage>(chatMessages);
        }
        

        public MvxObservableCollection<ChatMessage> Messages { get; }
    }
}