namespace SourceCodeEditor
{
    /// <summary>
    /// Class, that contains operations with Main MenuStrip on form
    /// </summary>
    public class Header
    {
        /// <returns>Enumeration of dropdown items of header</returns>
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

        public static IEnumerable<ToolStripMenuItem> GetHeaderItems(object item)
        {
            var Item = (ToolStripMenuItem)item;
            foreach (ToolStripMenuItem dropDownItem in Item.DropDownItems)
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
