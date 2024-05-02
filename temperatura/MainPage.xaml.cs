namespace temperatura;

public partial class MainPage : ContentPage
{
	Resposta resposta;
	Results resultado;

	public MainPage()
	{
		InitializeComponent();
		PreencheTela();
		TestaLayout();
	}
	void TestaLayout()
	{
		resultado= new Results();
		resposta.results.temp = 23;
		resposta.results.description = "tempo nublado";
		resposta.results.currently = "dia";
		resposta.results.city = "Apucarana, PR";
		resposta.results.humidity = 20;
		resposta.results.rain = 0.0;
		resposta.results.sunrise  = "06:39";
		resposta.results.sunset = "06:11pm";
		resposta.results.wind_speedy = "4.99 km/h";
		resposta.results.wind_direction = 40;
		resposta.results.moon_phase= "cheia";
	}
	
		
	
		void PreencheTela()
		{
			TemperatureLabel.Text = resposta.results.temp.ToString();
			DescricaoLabel.Text = resposta.results.description.ToString();
			CurrentlyLabel.Text = resposta.results.currently.ToString();
			CityLabel.Text = resposta.results.city.ToString();
			HumidityLabel.Text= resposta.results.humidity.ToString();
			RainLabel.Text= resposta.results.rain.ToString();
			SunriseLabel.Text= resposta.results.sunrise.ToString();
			SunsetLabel. Text= resposta.results.sunset.ToString();
			WindSpeedyLabel.Text= resposta.results.wind_speedy.ToString();
			WindDirectionLabel.Text= resposta.results.wind_direction.ToString();
			MoonPhaseLabel.Text= resposta.results.moon_phase.ToString();
			TimeLabel.Text = resposta.results.date.ToString();
			DateLabel.Text = resposta.results.date.ToString();

		
	}



		




	}

	


