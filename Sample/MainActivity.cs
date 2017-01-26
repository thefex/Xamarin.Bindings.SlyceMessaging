using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using IT.Slyce.Messaging;

namespace Sample
{
    [Activity(Label = "Sample", MainLauncher = true, Theme= "@style/AppTheme")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            var slyceMessagingFragment = (SlyceMessagingFragment)FragmentManager.FindFragmentById(Resource.Id.fragment_for_slyce_messaging);
            slyceMessagingFragment.SetDefaultAvatarUrl("https://scontent-lga3-1.xx.fbcdn.net/v/t1.0-9/10989174_799389040149643_722795835011402620_n.jpg?oh=bff552835c414974cc446043ac3c70ca&oe=580717A5");
            slyceMessagingFragment.SetDefaultDisplayName("Matthew Page");
            slyceMessagingFragment.SetDefaultUserId("uhtnaeohnuoenhaeuonthhntouaetnheuontheuo");
            slyceMessagingFragment.SetPictureButtonVisible(false);
        }
    }
}

