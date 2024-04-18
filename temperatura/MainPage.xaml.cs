



















































































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
		resultado.Humidity = ""

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

