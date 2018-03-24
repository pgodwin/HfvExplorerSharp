using Eto.Forms;
using System;
using System.Collections.Generic;
using System.Text;

namespace HfvExplorerSharp.Controls
{
    /// <summary>
    /// Responsible for listing files in the specified directory.
    /// </summary>
    public class IconView : GridView
    {
        public IconView()
        {
            Columns.Add(new GridColumn()
            {
                HeaderText = "", // Icon
                DataCell = new ImageViewCell()
                {

                }
            });

            Columns.Add(new GridColumn()
            {
                HeaderText = "Filename",
                DataCell = new TextBoxCell()
                {

                }
            });


        }
    }
}
