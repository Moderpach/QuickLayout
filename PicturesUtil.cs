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

        public static void RestorePicturesSize()
        {
            Word.Document document = Globals.ThisAddIn.Application.ActiveDocument;
            foreach (Word.InlineShape shape in document.InlineShapes)
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
            Debug.WriteLine("restore pictures size complete!");
        }
    }

    
}
