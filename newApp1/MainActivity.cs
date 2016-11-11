using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Android.Support.V7.AppCompat;
using Android.Support.Graphics.Drawable;

namespace Controle.App
{
	[Activity(Label = "Controle", MainLauncher = true, Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
	public class MainActivity : AppCompatActivity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			var toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
			SetSupportActionBar(toolbar);

		}

		public override bool OnCreateOptionsMenu(Android.Views.IMenu menu)
		{
			var inflater = MenuInflater;
			inflater.Inflate(Resource.Menu.toolbar, menu);
			return true;
		}

		public override bool OnOptionsItemSelected(Android.Views.IMenuItem item)
		{
			int id = item.ItemId;

			switch (id)
			{
				case Resource.Id.teste: Toast.MakeText(this, "Teste clicado", ToastLength.Short).Show(); break;
			}

			return base.OnOptionsItemSelected(item);
		}
	}
}

