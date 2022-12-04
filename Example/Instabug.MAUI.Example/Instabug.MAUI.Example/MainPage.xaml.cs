namespace Instabug.MAUI.Example;


public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
        var invEvents = new List<Instabug.InvocationEvent>
        {
            Instabug.InvocationEvent.FloatingButton,
            Instabug.InvocationEvent.Shake
        };
        Instabug.Start("YOUR_APP_TOKEN", invEvents);
   }
}


