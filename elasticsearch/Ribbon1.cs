using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Word = Microsoft.Office.Interop.Word;
using System.IO;
using System.Diagnostics;

namespace elasticsearch
{
    public partial class Ribbon1
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void Export_Click(object sender, RibbonControlEventArgs e)
        {
            //get the current selection
            string selectText = string.Empty;
            Word.Selection wordSelection = Globals.ThisAddIn.Application.Selection;
            if (wordSelection != null && wordSelection.Range != null)
            {
                selectText = wordSelection.Text;
            }

            if (selectText != null)
            {
                //here we have selected text, we send to elasticsearch
                System.Diagnostics.Debug.Write(selectText);

                var mydoc = new Document
                {
                    //Id = null,
                    Corp = selectText,
                    Title = "kimchy"
                    
                };

                var response = ThisAddIn.client.Index(mydoc, idx => idx.Index("document"));

                // create a doc for es
                //Document mydoc = new Document("test", selectText);
                //var response = ThisAddIn.client.Index(mydoc, idx => idx.Index("mytweetindex"));

            }
        }
    }
}
