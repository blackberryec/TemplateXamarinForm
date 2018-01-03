using System.Threading.Tasks;
using TemplateXamarinForm.Services;
using TemplateXamarinForm.ViewModels.Base;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace TemplateXamarinForm
{
    public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

		    InitApp();

		    if (Device.RuntimePlatform == Device.UWP)
		    {
		        InitNavigation();
		    }
        }

	    private void InitApp()
	    {
	        ViewModelLocator.RegisterDependencies();
	    }

	    private Task InitNavigation()
	    {
	        var navigationService = ViewModelLocator.Resolve<INavigationService>();
	        return navigationService.InitializeAsync();
	    }



        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
