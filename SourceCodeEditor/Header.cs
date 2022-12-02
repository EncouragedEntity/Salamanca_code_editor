using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCodeEditor
{
    internal class Header
    {
        public static IEnumerable<ToolStripMenuItem> GetHeaderItems(ToolStripMenuItem item)
        {
            foreach (ToolStripMenuItem dropDownItem in item.DropDownItems)
            {
                if (dropDownItem.HasDropDownItems)
                {
                    foreach (ToolStripMenuItem subItem in GetHeaderItems(dropDownItem))
                        yield return subItem;
                }
                yield return dropDownItem;
            }
        }
    }
}
