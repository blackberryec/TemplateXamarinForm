using System.Threading.Tasks;
using TemplateXamarinForm.Services;
using TemplateXamarinForm.Services.Dialog;

namespace TemplateXamarinForm.ViewModels.Base
{
    public abstract class ViewModelBase : ExtendedBindableObject
    {
        protected readonly INavigationService NavigationService;

        private bool _isBusy;

        public bool IsBusy
        {
            get
            {
                return _isBusy;
            }

            set
            {
                _isBusy = value;
                RaisePropertyChanged(() => IsBusy);
            }
        }

        public ViewModelBase()
        {
            NavigationService = ViewModelLocator.Resolve<INavigationService>();
        }
        //method can be overridden.
        //This method specifies an object argument that represents the data to be passed to a view model during a navigation operation.
        public virtual Task InitializeAsync(object navigationData)
        {
            return Task.FromResult(false);
        }
    }
}