using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentGeneratorCP
{
    class ApologeticNoteDoc : DocumentBuilder
    {
        public override void SetDataAndSignature()
        {
            document.DataAndSignature = "С уважение: ________" + "                " + "Дата: _________" + "    " + "Град: ________";
        }

        public override void SetHeader()
        {
            document.Header = "До класния ръководител на: ___ клас." + Environment.NewLine + Environment.NewLine;
        }

        public override void SetMessage()
        {
            document.Message = "Господин/Госпожо," + Environment.NewLine + "Моля да бъдат извинени отсъствията на сина/дъщеря ми ______________________________________" 
                + Environment.NewLine + Environment.NewLine + "Ученик/чка от ___ клас за __________ (дата и ден от седмицата) поради семейни причини." + Environment.NewLine + Environment.NewLine; 
        }

        public override void SetPersonalData()
        {
            document.PersonalData = "От: ________________________________________________ (три имена на родител)"
                + Environment.NewLine + Environment.NewLine +"Адрес: __________________________________________________________"
                + Environment.NewLine + "Мобилен телефон: __________" + Environment.NewLine;
        }

        public override void SetTypeOfDocument()
        {
            document.TypeOfDocument = "МОЛБА" + Environment.NewLine;
        }
    }
}