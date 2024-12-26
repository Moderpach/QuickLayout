using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using Word = Microsoft.Office.Interop.Word;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Word;

namespace QuickLayout
{
    public partial class QuickLayoutRibbon
    {
        private void QuickLayoutRibbonInstance_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void RestorePicturesSizeButton_Click(object sender, RibbonControlEventArgs e)
        {
            Debug.WriteLine("The button is clicked!");
            PicturesUtil.RestorePicturesSize();
        }
    }
}
