using System;
using System.ComponentModel;

namespace Instagramarin
{
    public class ProfileViewModel: BaseViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Posts { get; set; }
        public int Followers { get; set; }
        public int Following { get; set; }
        public string AvatarUrl { get; set; }

        public HeaderItem[] HeaderItems => new[] {
            new HeaderItem
            {
                Title = "Posts",
                Value = Posts
            },
            new HeaderItem
            {
                Title = "Followers",
                Value = Followers
            },
            new HeaderItem
            {
                Title = "Following",
                Value = Following
            }
        };

        public Story[] Stories { get; set; }
    }

    public sealed class HeaderItem
    {
        public string Title { get; set; }
        public int Value { get; set; }
    }

    public sealed class Story
    {
        public string ImageUrl { get; set; }
        public string Text { get; set; }
    }
}
