using Microsoft.Maui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyoutNavigationTitlebar
{
    public class ListPageModel
    {
        public List<int> ToDisplay { get; set; } = [1, 2, 3];
        public FontImageSource FontImageSource { get; set; } = new FontImageSource() { Glyph = "A"};
    }
}
