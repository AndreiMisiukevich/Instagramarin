using static System.Math;
using Xamarin.Forms;

namespace Instagramarin
{
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            InitializeComponent();
        }

        private void OnRootScrollViewScrolled(object sender, ScrolledEventArgs e)
        {
            var position = ProfileLayout.Height + Max(0, RootScrollView.ScrollY - ProfileLayout.Height);
            AbsoluteLayout.SetLayoutBounds(TabsLayout, new Rectangle(0, position, 1, TabsLayout.Height));
        }
    }
}
