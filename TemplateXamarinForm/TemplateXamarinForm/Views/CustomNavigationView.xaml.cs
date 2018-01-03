using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TemplateXamarinForm.Views
{
	public partial class CustomNavigationView : NavigationPage
    {
        //The purpose of this wrapping is for ease of styling the NavigationPage instance inside the XAML file for the class.
		public CustomNavigationView () : base()
		{
			InitializeComponent();
		}

	    public CustomNavigationView(Page root) : base(root)
	    {
	        InitializeComponent();
	    }
    }
}