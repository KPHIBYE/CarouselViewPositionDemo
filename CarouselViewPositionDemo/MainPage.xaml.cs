namespace CarouselViewPositionDemo;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void Button1_Clicked(object sender, EventArgs e)
    {
        MyCarousel.Position = 0;
    }

    private void Button2_Clicked(object sender, EventArgs e)
    {
        MyCarousel.Position = 1;
    }

    private void Button3_Clicked(object sender, EventArgs e)
    {
        MyCarousel.Position = 2;
    }
}

