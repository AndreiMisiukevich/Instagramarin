using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Instagramarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var profileViewModel = new ProfileViewModel
            {
                Id = "andrik_just4Fun",
                Name = "Andrik Jus4Fun",
                Posts = 41,
                Followers = 59,
                Following = 46,
                AvatarUrl = "https://scontent-frt3-2.cdninstagram.com/v/t51.2885-19/s320x320/66178435_331366354441120_5188798089636347904_n.jpg?_nc_ht=scontent-frt3-2.cdninstagram.com&_nc_ohc=rRRqe394uYYAX9gYJBp&oh=21bbdeaa7aa8e94f1f119ea91a50a1fd&oe=5EC0090B",
                Stories = new[]
                {
                    new Story
                    {
                        Text = "New"
                    },
                    new Story
                    {
                        ImageUrl = "https://www.thecrazybuyers.com/wp-content/uploads/2019/10/Best-iPhone-Selfie-Stick.jpg",
                        Text = "LoL"
                    },
                    new Story
                    {
                        ImageUrl = "https://picsum.photos/500/500?image=234",
                        Text = "MSQ"
                    },
                    new Story
                    {
                        ImageUrl = "https://picsum.photos/500/500?image=235",
                        Text = "Me"
                    },
                    new Story
                    {
                        ImageUrl = "https://picsum.photos/500/500?image=36",
                        Text = ":)"
                    },
                    new Story
                    {
                        ImageUrl = "https://picsum.photos/500/500?image=652",
                        Text = "$$"
                    },
                    new Story
                    {
                        ImageUrl = "https://picsum.photos/500/500?image=12",
                        Text = "GR"
                    }
                }
            };

            MainPage = new NavigationPage(new ProfilePage { BindingContext = profileViewModel }) { BarBackgroundColor = Color.FromHex("#fafafa") };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
