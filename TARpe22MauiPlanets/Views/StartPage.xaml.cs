namespace TARpe22MauiPlanets.Views;

public partial class StartPage : ContentPage
{
	public StartPage()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();

		if (this.AnimationIsRunning("TransitionAnimation"))
		{
			return;
		}

		var parentAnimation = new Animation();

		//Planets Animation
		parentAnimation.Add(0.2, 0.4, new Animation(v => imgtoit.Opacity = v, 0, 1, Easing.CubicIn));

		//Intro box
		parentAnimation.Add(0.7, 1, new Animation(v => imgIntro.Opacity = v, 0, 1, Easing.CubicIn));

		parentAnimation.Commit(this, "TransitionAnimation", 16, 3000, null, null);

		
    }

	async void ExploreNow_Clicked(System.Object sender, System.EventArgs e)
			=> Application.Current.MainPage = new NavigationPage(new PlanetsPage());
}