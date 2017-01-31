using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Android.Runtime;
using IT.Slyce.Messaging.Listeners;
using IT.Slyce.Messaging.Message;

namespace Xamarin.Bindings.SlyceMessaging.Additions
{
    public static class LoadMoreMessagesListenerExtensions
    {
        public static ILoadMoreMessagesListener BuildLoadMoreMessagesListener<TItem>(Func<TItem, Message> dataConverter, Func<Task<IEnumerable<TItem>>> loadMoreMessageProvider)
        {
            return new LoadMoreMessageListener<TItem>(dataConverter, loadMoreMessageProvider);
        }

        class LoadMoreMessageListener<TItem> : Java.Lang.Object, ILoadMoreMessagesListener
        {
            private readonly Func<TItem, Message> _dataConverter;
            private readonly Func<Task<IEnumerable<TItem>>> _loadMoreMessageProvider;

            protected LoadMoreMessageListener(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
            {
            }

            public LoadMoreMessageListener(Func<TItem, Message> dataConverter, Func<Task<IEnumerable<TItem>>> loadMoreMessageProvider)
            {
                _dataConverter = dataConverter;
                _loadMoreMessageProvider = loadMoreMessageProvider;
            }

            public IList<Message> LoadMoreMessages()
            {
                // internaly it's scheduled on background java thread so it's safe to wait for that
                IEnumerable<TItem> loadedItems = Enumerable.Empty<TItem>();
                Task.Run(async () =>
                {
                    loadedItems = await _loadMoreMessageProvider().ConfigureAwait(false);
                }).Wait();

                return loadedItems.Select(_dataConverter).ToList();
            }
        }
    }
}