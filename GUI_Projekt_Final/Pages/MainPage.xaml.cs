using GUI_Projekt_Final.Models;

namespace GUI_Projekt_Final.Pages;

public partial class MainPage : ContentPage
{
    public List<User> Users { get; set; }

    public MainPage()
    {
        InitializeComponent();

        Users = new List<User>
{
    new User{
        UserID = 1,
        Description = "John Doe",
        ImageUrl = "https://picsum.photos/id/1/100/100",
        FullName = "Johnathan Doe",
        Email = "john@example.com",
        Role = "Administrator"
            },
    new User{
        UserID = 2,
        Description = "Jane Smith",
        ImageUrl = "https://picsum.photos/id/2/100/100",
        FullName = "Jane Alexandra Smith",
        Email = "jane@example.com",
        Role = "Editor"
            },
    new User{
        UserID = 3,
        Description = "Alice Johnson",
        ImageUrl = "https://picsum.photos/id/3/100/100",
        FullName = "Alice Marie Johnson",
        Email = "alice@example.com",
        Role = "Viewer"
             }
         
        
        
    };


        BindingContext = this;
    }

    private async void OnUserSelected(object sender, SelectionChangedEventArgs e)
    {
        var selectedUser = e.CurrentSelection.FirstOrDefault() as User;
        if (selectedUser != null)
        {
            await Navigation.PushAsync(new UserDetailPage(selectedUser));
            ((CollectionView)sender).SelectedItem = null;
        }
    }
}
