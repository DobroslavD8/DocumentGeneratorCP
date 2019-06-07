using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentGeneratorCP
{
    //Молба
    class ApplicationDoc : DocumentBuilder
    {
        public override void SetHeader()
        {

        }

        public override void SetTypeOfDocument()
        {
            document.TypeOfDocument = "МОЛБА ЗА ОТПУСК" + Environment.NewLine + Environment.NewLine;
        }

        public override void SetPersonalData()
        {
            document.PersonalData = "От __________________________ " + Environment.NewLine + "С ЕГН/ЛНЧ _____________ на длъжност ___________" + Environment.NewLine + "от отдел /цех ____." + Environment.NewLine;
        }

        public override void SetMessage()
        {
            document.Message = Environment.NewLine + Environment.NewLine + Environment.NewLine + "Уважаеми/а г-н/г-жо _______," + Environment.NewLine + "Моля да ми разрешите да ползвам (неплатен) платен годишен отпуск за ___ година, в продължение на __ работни дни, считано от __.__.20__ год." + Environment.NewLine + Environment.NewLine + Environment.NewLine;
        }

        public override void SetDataAndSignature()
        {
            document.DataAndSignature = Environment.NewLine + Environment.NewLine + "Дата: ________" + "                            " + "С уважение: ________" ;
        }
    }
}
