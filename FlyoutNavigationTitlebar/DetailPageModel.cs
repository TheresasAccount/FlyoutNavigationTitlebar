using System.Windows.Input;

namespace FlyoutNavigationTitlebar
{
    public class DetailPageModel
    {
        public Page Page { get; set; }
        public ICommand PushCommand { get; set; }

        public DetailPageModel()
        {
            PushCommand = new Command(async () => await PushPage());
        }

        public async Task PushPage()
        {
            await Page?.Navigation.PushAsync(new PushedPage());
        }
    }
}
