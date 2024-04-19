
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
			labelTemperature.Text = Resultados.Temp;
			labelDescricao.Text = Resultados.Descripition;
			labelCurrently.Text =  Resultados.Currently;
			labelCity.Text = Resultados.City;
			labelHumidity = Resultados.Humidity;
			labelRain = Resultados.Rain;
			labelSunrise = Resultados.Sunrise;
			labelSunset = Resultados.Sunset;
			labelWind_Speedy = Resultados.Wind_Speedy;
			labelWind_Direction = Resultados.Wind_Direction;
			labelmoon_pha = Resultados.moon_pha;
			labelimg_id = Resultados.img_id;
			labelTime = 
			

			








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
}

