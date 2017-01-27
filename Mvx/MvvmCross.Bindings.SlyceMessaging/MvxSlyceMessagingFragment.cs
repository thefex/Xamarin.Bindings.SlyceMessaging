using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection;
using Android.OS;
using Android.Runtime;
using Android.Views;
using IT.Slyce.Messaging;
using IT.Slyce.Messaging.Listeners;
using MvvmCross.Binding;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.Platform;
using MvvmCross.Platform.WeakSubscription;
using Message = IT.Slyce.Messaging.Message.Message;

namespace MvvmCross.Bindings.SlyceMessaging
{
    [Register("mvvmcross.bindings.slycemessaging.MvxSlyceMessagingFragment")]
    public class MvxSlyceMessagingFragment : SlyceMessagingFragment
        , IUserSendsMessageListener
        , IUserClicksAvatarPictureListener
    {
        private static IMvxSlyceMessageFactory cachedSlyceMessageFactory;

        private IEnumerable<object> _messages = Enumerable.Empty<object>();
        private IDisposable _subscription;

        public MvxSlyceMessagingFragment()
        {
        }

        public MvxSlyceMessagingFragment(IntPtr ptr, JniHandleOwnership transfer) : base(ptr, transfer)
        {
        }

        public virtual IEnumerable<object> Messages
        {
            get { return _messages; }
            set { SetMessageSource(value); }
        }

        /// <summary>
        /// Default value of this property is the class implementing IMvxSlyceMessageFactory
        /// with attribute MvxDefaultSlyceMessageFactoryAttribute inside the executing assembly.
        /// If there is no such class - null value is passed and you have to set it by code.
        /// Default value is not set if you provide your own IMvxSlyceMessageFactory in code.
        /// </summary>
        public IMvxSlyceMessageFactory MessageFactory { get; set; }

        /// <summary>
        ///     Text message is passed as parameter.
        /// </summary>
        public MvxCommand<string> TextMessageSentCommand { get; set; }

        /// <summary>
        ///     Media uri is passed as parameter.
        /// </summary>
        public MvxCommand<Uri> MediaMessageSentCommand { get; set; }

        /// <summary>
        ///     UserID is passed as parameter.
        /// </summary>
        public MvxCommand<string> UserAvatarTapped { get; set; }

        public void UserClicksAvatarPhoto(string userId)
        {
            if (UserAvatarTapped != null && UserAvatarTapped.CanExecute(userId))
                UserAvatarTapped.Execute(userId);
        }

        public void OnUserSendsMediaMessage(Android.Net.Uri mediaUri)
        {
            if (MediaMessageSentCommand == null)
                return;

            if (MediaMessageSentCommand.CanExecute(mediaUri))
                MediaMessageSentCommand.Execute(mediaUri);
        }

        public void OnUserSendsTextMessage(string textMessage)
        {
            if (TextMessageSentCommand == null)
                return;

            if (TextMessageSentCommand.CanExecute(textMessage))
                TextMessageSentCommand.Execute(textMessage);
        }

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);

            TrySetDefaultMessageFactoryIfNeeded();
            SetOnSendMessageListener(this);
            SetUserClicksAvatarPictureListener(this);
        }

        private void TrySetDefaultMessageFactoryIfNeeded()
        {
            if (MessageFactory != null)
                return;

            if (cachedSlyceMessageFactory != null)
            {
                MessageFactory = cachedSlyceMessageFactory;
                return;
            }

            var typeInfos = AppDomain
                .CurrentDomain
                .GetAssemblies()
                .SelectMany(x => x.DefinedTypes)
                .Where(x => !x.IsAbstract && x.IsClass & typeof(IMvxSlyceMessageFactory).IsAssignableFrom(x));
            

            var defaultMessageFactoryType =
                typeInfos
                    .FirstOrDefault(x => x.GetCustomAttribute<MvxDefaultSlyceMessageFactoryAttribute>() != null);

            if (defaultMessageFactoryType == null)
                return;

            MessageFactory = Activator.CreateInstance(defaultMessageFactoryType) as IMvxSlyceMessageFactory;
            cachedSlyceMessageFactory = MessageFactory;
        }

        protected virtual void SetMessageSource(IEnumerable<object> newMessageSource)
        {
            if (ReferenceEquals(_messages, newMessageSource))
                return;
            if (MessageFactory == null)
                throw new InvalidOperationException($"Cannot set message source until you set {nameof(MessageFactory)}");

            _subscription?.Dispose();
            _subscription = null;

            _messages = newMessageSource;

            if (_messages != null && !(_messages is IList))
                MvxBindingTrace.Trace(MvxTraceLevel.Warning,
                    "Binding to IEnumerable rather than IList - this can be inefficient, especially for large lists");

            var newObservable = Messages as INotifyCollectionChanged;
            if (newObservable != null)
                _subscription = newObservable.WeakSubscribe(OnItemsSourceCollectionChanged);

            if (Messages != null)
                ReplaceMessages(Messages.Select(x => MessageFactory.BuildMessage(x)).ToList());
        }

        private void OnItemsSourceCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    AddNewMessages(e.NewItems.Cast<object>().Select(MessageFactory.BuildMessage).ToList());
                    break;
                case NotifyCollectionChangedAction.Reset:
                    ReplaceMessages(Enumerable.Empty<Message>().ToList());
                    break;
                // no replace, move, remove methods available in orginal library...
                case NotifyCollectionChangedAction.Remove:
                    ReplaceMessages(Messages.Select(x => MessageFactory.BuildMessage(x)).ToList());
                    break;
                case NotifyCollectionChangedAction.Move:
                    ReplaceMessages(Messages.Select(x => MessageFactory.BuildMessage(x)).ToList());
                    break;
                case NotifyCollectionChangedAction.Replace:
                    ReplaceMessages(Messages.Select(x => MessageFactory.BuildMessage(x)).ToList());
                    break;
            }
        }
    }
}