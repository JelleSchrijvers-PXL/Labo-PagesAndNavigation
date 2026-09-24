using HelloPXL.Pages;

namespace HelloPXL
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(HelloPage), typeof(HelloPage));
        }
    }
}
