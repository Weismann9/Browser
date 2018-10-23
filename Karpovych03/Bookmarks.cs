using System;

namespace Karpovych03
{
    [Serializable]
    public class Bookmark
    {
        public string Title { get; set; }
        public string URL { get; set; }

        public Bookmark()
        {
        }

        public Bookmark(string uRL, string title)
        {
            URL = uRL;
            Title = title;
        }

    }
}
