namespace FlashQuizz
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnManageClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("Manage");
        }
    }
}
