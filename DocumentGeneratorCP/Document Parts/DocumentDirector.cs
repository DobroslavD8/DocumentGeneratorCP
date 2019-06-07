using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentGeneratorCP
{
    class DocumentDirector
    {
        public Document GenerateDocument(DocumentBuilder docBuilder)
        {
            docBuilder.CreateDocument();
            docBuilder.SetHeader();
            docBuilder.SetTypeOfDocument();
            docBuilder.SetPersonalData();
            docBuilder.SetMessage();
            docBuilder.SetDataAndSignature();

            return docBuilder.getDocument();
        }
    }
}
