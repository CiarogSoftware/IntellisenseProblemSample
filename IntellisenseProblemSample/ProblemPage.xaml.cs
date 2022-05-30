using IntellisenseProblemSample.ViewModels;
namespace IntellisenseProblemSample;

public partial class ProblemPage : ContentPage
{
	public ProblemPage(ProblemPageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}