using System;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace ChapterTwo
{
	public partial class ChapterTwoPage : ContentPage
	{


		Label labelSmall = new Label
		{
			Text = "Charlie\n" +
			"Duavis\n" +
			"Pogoy",
			FontSize = 20,
			HorizontalOptions = LayoutOptions.CenterAndExpand
		};

		Label labelLarge = new Label
		{
			Text = "Label",
			FontSize = 40,
			HorizontalOptions = LayoutOptions.Center
		};


		Button button = new Button
		{
			Text = "Click",
			FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Fill


		};


		Entry entry = new Entry
		{
			Text = "",
			Placeholder = "Username",
			VerticalOptions = LayoutOptions.Center,
			Keyboard = Keyboard.Text
		};


		//BoxView boxView = new BoxView
		//{
		//	Color = Color.Silver,
		//	WidthRequest = 150,
		//	HeightRequest = 150,
		//	HorizontalOptions = LayoutOptions.StartAndExpand,
		//	VerticalOptions = LayoutOptions.Fill
		//};

		//Image image = new Image
		//{
		//	Source = "monkey.png",
		//	Aspect = Aspect.AspectFit,
		//	HorizontalOptions = LayoutOptions.CenterAndExpand,
		//	VerticalOptions = LayoutOptions.Fill
		//};

		//-----------Button----
		public void idunno(object sender, EventArgs e)
		{
			if (button.BackgroundColor == Color.Pink)
			{

				button.BackgroundColor = Color.Blue;
				button.Text = "Pink";

				labelSmall.TextColor = Color.Green;
				labelLarge.FontSize = 20;

			}
			else
			{
				button.BackgroundColor = Color.Pink;
				button.Text = "Blue";
				labelSmall.TextColor = Color.Purple;
				labelLarge.FontSize = 40;
			}

			try
			{
				String s = entry.Text;
				int l = s.Length;


				if (l == 0)
				{
					this.BackgroundColor = Color.Red;
					DisplayAlert("Ambot", "This is Empty P**k", "Fin");
				}
				else
				{
					this.BackgroundColor = Color.Default;
					DisplayAlert("Alert", s, "OK");
				}
			}
			catch (System.NullReferenceException)
			{ }


		}

		//------End Button ------


		public ChapterTwoPage()
		{
			InitializeComponent();


			button.Clicked += idunno;


			//var tapGestureRecognizer = new TapGestureRecognizer();
			//tapGestureRecognizer.Tapped += async (sender, e) =>
		 //  {
			//   image.Opacity = .5;
			//   await Task.Delay(200);
			//   image.Opacity = 1;
		 //  };
			//image.GestureRecognizers.Add(tapGestureRecognizer);

			StackLayout stackLayout = new StackLayout
			{
				Children =
				{
					labelLarge,
					labelSmall,
					button,
					entry
				},
				HeightRequest = 1500
			};

			ScrollView scrollView = new ScrollView
			{
				//BackgroundColor = Color.White,
		
				VerticalOptions = LayoutOptions.FillAndExpand,
				Content = stackLayout
			};

			//this.BackgroundColor = Color.Black; //White

			// Accomodate iPhone status bar.
			this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

			this.Content = scrollView;
		}

}
}

