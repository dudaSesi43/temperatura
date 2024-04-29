
using System.Reflection.Emit;
using ForecastApp;

namespace temperatura;

public partial class MainPage : ContentPage
{
	Resposta resposta;
	Results resultado;

	public MainPage()
	{
		InitializeComponent();
		TestaLayout();
		PreencheTela();
	}
	void TestaLayout()
	{
		resultado= new Results();
		resposta.resultado.temp = 23;
		resposta.resultado.description = "tempo nublado";
		resposta.resultado.currently = "dia";
		resposta.resultado.city = "Apucarana, PR";
		resposta.resultado.humidity = 20;
		resposta.resultado.rain = 0.0;
		resposta.resultado.sunrise  = "06:39";
		resposta.resultado.sunset = "06:11pm";
		resposta.resultado.wind_speedy = "4.99 km/h";
		resposta.resultado.wind_direction = 40;
		resposta.resultado.moon_phase= "cheia";
		
	}
		void PreencheTela()
		{
			TemperatureLabel.Text = resposta.resultado.temp;
			DescricaoLabel.Text = resposta.resultado.description;
			CurrentlyLabel.Text = resposta.resultado.currently;
			CityLabel.Text = resposta.resultado.city;
			HumidityLabel.Text= resposta.resultado.humidity;
			RainLabel.Text= resposta.resultado.rain;
			SunriseLabel.Text= resposta.resultado.sunrise;
			SunsetLabel. Text= resposta.resultado.sunset;
			WindSpeedyLabel.Text= resposta.resultado.wind_speedy;
			WindDirectionLabel.Text= resposta.resultado.wind_direction;
			MoonPhaseLabel.Text= resposta.resultado.moon_phase;
			TimeLabel.Text = resposta.resultado.time;
			DateLabel.Text = resposta.resultado.date;

		
	}



		




	}

	


