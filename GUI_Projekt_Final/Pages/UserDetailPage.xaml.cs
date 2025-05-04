using GUI_Projekt_Final.Models;

namespace GUI_Projekt_Final.Pages;

public partial class UserDetailPage : ContentPage
{
    public UserDetailPage(User selectedUser)
    {
        InitializeComponent();
        BindingContext = selectedUser;
    }
}
