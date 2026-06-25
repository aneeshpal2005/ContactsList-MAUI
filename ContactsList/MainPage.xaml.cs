using ContactsList.Models;
using System.Collections.ObjectModel;

namespace ContactsList
{
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<ContactGroup> ContactGroups
        = new ObservableCollection<ContactGroup>();

        public MainPage()
        {
            InitializeComponent();
            LoadContacts();

            ContactsCollectionView.ItemsSource = ContactGroups;
        }

        private void LoadContacts()
        {
            var contacts = new List<ContactInfo>
            {
                new ContactInfo{ Name="Alice Brown", Email="alice@gmail.com", Phone="111-1111", Description="Friend from college.", Photo="avatarmaleone.png"},
                new ContactInfo{ Name="Adam Smith", Email="adam@gmail.com", Phone="111-1112", Description="Software Developer.", Photo="avatarmaletwo.png"},
                new ContactInfo{ Name="Amy Wilson", Email="amy@gmail.com", Phone="111-1113", Description="Gym buddy.", Photo="avatarfemaleone.png"},

                new ContactInfo{ Name="Ben Davis", Email="ben@gmail.com", Phone="222-1111", Description="Works at Microsoft.", Photo="avatarmaleone.png"},
                new ContactInfo{ Name="Bella Johnson", Email="bella@gmail.com", Phone="222-1112", Description="Neighbor.", Photo="avatarfemaletwo.png"},
                new ContactInfo{ Name="Brian White", Email="brian@gmail.com", Phone="222-1113", Description="High school friend.", Photo="avatarmaletwo.png"},

                new ContactInfo{ Name="Chris Lee", Email="chris@gmail.com", Phone="333-1111", Description="Soccer teammate.", Photo="avatarmaleone.png"},
                new ContactInfo{ Name="Cathy Green", Email="cathy@gmail.com", Phone="333-1112", Description="Teacher.", Photo="avatarfemaletwo.png"},
                new ContactInfo{ Name="Carl Young", Email="carl@gmail.com", Phone="333-1113", Description="Project partner.", Photo="avatarmaleone.png"},

                new ContactInfo{ Name="David Hall", Email="david@gmail.com", Phone="444-1111", Description="Works in finance.", Photo="avatarmaleone.png"},
                new ContactInfo{ Name="Diana King", Email="diana@gmail.com", Phone="444-1112", Description="Family friend.", Photo="avatarfemaletwo.png"},
                new ContactInfo{ Name="Daniel Scott", Email="daniel@gmail.com", Phone="444-1113", Description="Lives nearby.", Photo="avatarmaleone.png"},

                new ContactInfo{ Name="Emma Clark", Email="emma@gmail.com", Phone="555-1111", Description="Classmate.", Photo="avatarfemaleone.png"},
                new ContactInfo{ Name="Ethan Adams", Email="ethan@gmail.com", Phone="555-1112", Description="Works at Google.", Photo="avatarmaleone.png"},
                new ContactInfo{ Name="Ella Turner", Email="ella@gmail.com", Phone="555-1113", Description="Cousin.", Photo="avatarfemaletwo.png"}
            };

            var groups = contacts
                .GroupBy(c => c.Name[0])
                .OrderBy(g => g.Key);

            foreach (var group in groups)
            {
                ContactGroups.Add(
                    new ContactGroup(
                        group.Key.ToString(),
                        group.ToList()));
            }
        }

        private async void ContactsCollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.FirstOrDefault() is ContactInfo contact)
            {
                await Navigation.PushAsync(new ContactDetailsPage(contact));

                ContactsCollectionView.SelectedItem = null;
            }
        }

    }
}
