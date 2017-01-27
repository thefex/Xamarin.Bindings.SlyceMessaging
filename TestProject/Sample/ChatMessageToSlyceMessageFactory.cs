using System;
using IT.Slyce.Messaging.Message;
using MvvmCross.Bindings.SlyceMessaging;
using TestSample.Core;

namespace Sample
{
    [MvxDefaultSlyceMessageFactory]
    public class ChatMessageToSlyceMessageFactory : IMvxSlyceMessageFactory
    {
        public Message BuildMessage(object fromItemSourceObject)
        {
            var chatMessage = fromItemSourceObject as ChatMessage;
            return new TextMessage()
            {
                AvatarUrl = chatMessage.CreatedBy.AvatarUrl,
                Date = new Java.Util.Date(chatMessage.CreatedUtcDate.Year, chatMessage.CreatedUtcDate.Month, chatMessage.CreatedUtcDate.Day, chatMessage.CreatedUtcDate.Hour, chatMessage.CreatedUtcDate.Minute, chatMessage.CreatedUtcDate.Second).Time,
                DisplayName = chatMessage.CreatedBy.Name,
                Initials = chatMessage.CreatedBy.Initials,
                Source = chatMessage.IsSender ? MessageSource.LocalUser : MessageSource.ExternalUser,
                Text = chatMessage.Content,
                UserId = chatMessage.CreatedBy.Id
            };
        }
    }
}