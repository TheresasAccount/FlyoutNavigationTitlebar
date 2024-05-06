namespace FlyoutNavigationTitlebar;

public partial class DetailPage : ContentPage
{
	public DetailPage()
	{
		InitializeComponent();
	}

    protected override void OnBindingContextChanged()
    {
        base.OnBindingContextChanged();
        if (BindingContext is DetailPageModel pm)
        {
            pm.Page = this;
        }
    }
}