using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karpovych03
{
    public class ToolStripLinkButton : ToolStripButton
    {
        public ToolStripLinkButton()
        {
        }

        public ToolStripLinkButton(string text, string url) : base(text)
        {
            URL = url;
        }

        public ToolStripLinkButton(string text, EventHandler onClick, string url) : base(text)
        {
            URL = url;
            Click += onClick;
        }

        public ToolStripLinkButton(string text, Image image, EventHandler onClick, string url) : base(text, image, onClick)
        {
            URL = url;
        }

        public string URL { get; set; }
    }
}
