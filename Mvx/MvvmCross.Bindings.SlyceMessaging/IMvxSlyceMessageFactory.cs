using Message = IT.Slyce.Messaging.Message.Message;

namespace MvvmCross.Bindings.SlyceMessaging
{
    /// <summary>
    /// Implementation should be side-effect free! (implementation shall not have any state)
    /// </summary>
    public interface IMvxSlyceMessageFactory
    {
        Message BuildMessage(object fromItemSourceObject);
    }
}