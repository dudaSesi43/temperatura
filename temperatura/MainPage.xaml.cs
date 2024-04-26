
using System.Reflection.Emit;
using ForecastApp;

namespace temperatura;

public partial class MainPage : ContentPage
{
	Resultados resultado;

	public MainPage()
	{
		InitializeComponent();
	}
	void TestaLayout()
	{
		resultado= new Resultados();
		resultado.Temp = 23;
		resultado.Description = "tempo nublado";
		resultado.Currently = "dia";
		resultado.City = "Apucarana, PR";
		resultado.Humidity = 20;
		resultado.Rain = 0.0;
		resultado.Sunrise  = "06:39";
		resultado.Sunset = "06:11pm";
		resultado.Wind_Speedy = "4.99 km/h";
		resultado.Wind_Direction = 40;
		resultado.moon_pha= "cheia";
		resultado.img_id= "28";
		resultado.Time= "08:09";
		resultado.date= "19/04/2024";

		Void PreencheTela()
		{
			labelTemperature.Text = resultado.Temp;
			labelDescricao.Text = resultado.Descripition;
			labelCurrently.Text = resultado.Currently;
			labelCityText = resultado.City;
			labelHumidity.Text= resultado.Humidity;
			labelRain.Text= resultado.Rain;
			labelSunrise.Text= resultado.Sunrise;
			labelSunset. Text= resultado=.Sunset;
			labelWind_Speedy.Text= resultado.Wind_Speedy;
			labelWind_Direction.Text= resultado.Wind_Direction;
			labelmoon_pha.Text= resultado.moon_pha;
			labelimg_id.Text= resultado.img_id;
			labelTime.Text = resultado.time;
			labeldate.Text = resultado.date;





		}




	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
	{
		<Image
                Source="diachuvoso.pnd"
                SemanticProperties.Description="Cute dot net bot waving hi to you!"
                HeightRequest="200"
                HorizontalOptions="Center" />
	}
}

