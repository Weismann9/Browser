namespace Karpovych03
{
    public class Settings
    {
        public Settings()
        {
        }

        public Settings(string searchEngine, bool showBookmarksBar)
        {
            SearchEngine = searchEngine;
            ShowBookmarksBar = showBookmarksBar;
        }

        public string SearchEngine { get; set; }
        public bool ShowBookmarksBar { get; set; }
    }
}
