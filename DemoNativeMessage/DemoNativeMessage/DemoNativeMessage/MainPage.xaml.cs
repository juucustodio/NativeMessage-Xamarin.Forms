using System;
using Xamarin.Forms;

namespace DemoNativeMessage
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

	    private void Button_OnClicked(object sender, EventArgs e)
	    {
	        DependencyService.Get<IMessage>().LongAlert("Hello");
	    }
    }
}
