using IntellisenseProblemSample.ViewModels;
namespace IntellisenseProblemSample;

public partial class Home : ContentPage
{
	public Home(HomeViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}