namespace FlashQuizz
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // Register route for pages
            Routing.RegisterRoute("Manage", typeof(Manage));
        }
    }
}
