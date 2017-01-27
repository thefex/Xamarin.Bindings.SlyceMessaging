using System;
using Android.App;
using Android.Widget;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using IT.Slyce.Messaging;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Bindings.SlyceMessaging;
using MvvmCross.Droid.Support.V7.AppCompat;
using TestSample.Core;

namespace Sample
{
    [Activity(Label = "Sample", MainLauncher = true, Theme= "@style/AppTheme")]
    public class MainActivity : MvxAppCompatActivity<ChatViewModel>
    {
        public MainActivity()
        {
                
        }

        public MainActivity(IntPtr ptr, JniHandleOwnership transfer) : base(ptr, transfer)
        {
                
        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            var slyceMessagingFragment = (MvxSlyceMessagingFragment)FragmentManager.FindFragmentById(Resource.Id.fragment_for_slyce_messaging);
            
            
            var bindingSet = this.CreateBindingSet<MainActivity, ChatViewModel>();

            bindingSet.Bind(slyceMessagingFragment)
                .For(x => x.Messages)
                .To(x => x.Messages);

            bindingSet.Apply();
        }
    }
}

