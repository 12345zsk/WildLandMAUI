namespace WildLandMAUI
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }
        
        private async void NavigateToHome(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomePage());
        }
        
        private async void NavigateToReservation(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ReservationPage());
        }
        
        private async void NavigateToPosts(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PostsPage());
        }
        
        private async void NavigateToForum(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ForumPage());
        }
    }
}