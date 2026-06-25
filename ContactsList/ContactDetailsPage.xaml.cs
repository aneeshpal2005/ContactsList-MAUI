using ContactsList.Models;

namespace ContactsList;

public partial class ContactDetailsPage : ContentPage
{
	public ContactDetailsPage(ContactInfo contact)
	{
		InitializeComponent();
		BindingContext = contact;
	}

	private async void BackButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

}