using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentGeneratorCP
{
    class DocumentFactory
    {
        public static DocumentBuilder MatchDocumentType(string key)
        {
            switch (key)
            {
                case "Application":
                    return new ApplicationDoc();
                case "Affirmation":
                    return new AffirmationDoc();
                case "An Apologetic Note":
                    return new ApologeticNoteDoc();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
