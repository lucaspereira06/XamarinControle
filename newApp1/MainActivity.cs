using Android.App;
using Android.Widget;
using Android.OS;

namespace newApp1
{
	[Activity(Label = "newApp1", MainLauncher = true)]
	public class MainActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			ActionBar.Hide();

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);
		}
	}
}

