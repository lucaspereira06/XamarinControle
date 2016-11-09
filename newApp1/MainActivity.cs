using Android.App;
using Android.Widget;
using Android.OS;

namespace Controle.App
{
	[Activity(Label = "Controle", MainLauncher = true)]
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

