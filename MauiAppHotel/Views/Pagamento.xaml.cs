namespace MauiAppHotel.Views;

public partial class Pagamento : ContentPage
{
	public Pagamento()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			Navigation.PopAsync();
		} catch (Exception ex)
		{
            DisplayAlert("Ocorreu um erro", ex.Message, "OK");
        }
    }
}