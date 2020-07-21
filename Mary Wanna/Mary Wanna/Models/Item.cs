using System;
using Xamarin.Forms;

namespace Mary_Wanna.Models
{
    public class Item
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
    }

    public class Item_full
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}