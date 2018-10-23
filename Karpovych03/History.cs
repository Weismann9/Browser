using System;

namespace Karpovych03
{
    [Serializable]
    public class History
    {
        public string Title { get; set; }
        public string URL { get; set; }
        public string Date { get; set; }

        public History()
        {
        }

        public History(string title, string uRL, string date)
        {
            Title = title;
            URL = uRL;
            Date = date;
        }
    }
}
