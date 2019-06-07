using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentGeneratorCP
{
    public abstract class DocumentBuilder
    {
        public Document document;

        public void CreateDocument()
        {
            document = new Document();
        }

        public abstract void SetHeader();
        public abstract void SetTypeOfDocument();
        public abstract void SetPersonalData();
        public abstract void SetMessage();
        public abstract void SetDataAndSignature();

        public Document getDocument()
        {
            return document;
        }
    }
}