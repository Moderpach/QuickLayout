using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Word = Microsoft.Office.Interop.Word;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Word;

namespace QuickLayout
{
    internal class PicturesUtil
    {

        public static void RestorePicturesToOriginalSize()
        {
            Debug.WriteLine("[PicturesUtil#RestorePicturesToOriginalSize]");
            Word.Selection selection = Globals.ThisAddIn.Application.Selection;
            foreach (Word.InlineShape shape in selection.InlineShapes)
            {
                if (shape.Type == Word.WdInlineShapeType.wdInlineShapePicture)
                {
                    Debug.WriteLine("found a picture");
                    Office.MsoTriState preLockAspectRatio = shape.LockAspectRatio;
                    shape.LockAspectRatio = Office.MsoTriState.msoFalse;
                    shape.ScaleWidth = 100.0F;
                    shape.ScaleHeight = 100.0F;
                    shape.LockAspectRatio = preLockAspectRatio;
                    Debug.WriteLine("restore a picture size");
                }

            }
            Debug.WriteLine("[PicturesUtil#RestorePicturesToOriginalSize] restore pictures size complete");
        }

        public static void ResizePicturesToFitPageWidth() 
        {
            Debug.WriteLine("[PicturesUtil#ResizePicturesToFitPageWidth]");

            Word.Selection selection = Globals.ThisAddIn.Application.Selection;
            foreach (Word.InlineShape shape in selection.InlineShapes)
            {
                if (shape.Type == Word.WdInlineShapeType.wdInlineShapePicture)
                {
                    Debug.WriteLine("found a picture");
                    Office.MsoTriState preLockAspectRatio = shape.LockAspectRatio;
                    shape.LockAspectRatio = Office.MsoTriState.msoTrue;

                    // get page width without margin
                    Word.PageSetup pageSetup = shape.Range.PageSetup;
                    float pageWidth = pageSetup.PageWidth - pageSetup.LeftMargin - pageSetup.RightMargin;
                    Debug.WriteLine("current page width: ", pageWidth);

                    shape.Width = pageWidth;

                    shape.LockAspectRatio = preLockAspectRatio;
                    Debug.WriteLine("restore a picture size");
                }

            }
            Debug.WriteLine("restore pictures size complete");
        }
    }

    
}
