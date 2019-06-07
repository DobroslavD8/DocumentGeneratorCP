using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentGeneratorCP
{
    //Уверение
    class AffirmationDoc : DocumentBuilder
    {
        public override void SetHeader()
        {
            document.Header = "Учебно заведение, адрес: __________________________________________" 
                + Environment.NewLine + "Факултет, департамент, катедра и др.: ________________________" 
                + Environment.NewLine + Environment.NewLine;
        }

        public override void SetTypeOfDocument()
        {
            document.TypeOfDocument = "УВЕРЕНИЕ" + Environment.NewLine + "Номер: _____/_____ 20__г." 
                + Environment.NewLine + Environment.NewLine;
        }

        public override void SetPersonalData()
        {
            document.PersonalData = "Име, презиме, фамилия: ________________________________________  ЕГН: ______________"
                + Environment.NewLine + "Постоянен адрес: __________________________________________"
                + Environment.NewLine + "Записан за зимното/лятното полугодие на учебната 20__/20__г. в специалност _________________"
                + Environment.NewLine + "Курс __, фак. № _____"
                + Environment.NewLine;
        }

        public override void SetMessage()
        {
            document.Message = "Настоящото уверение се дава на ____________________________________________"
            + Environment.NewLine + "Да послужи пред ___________________________________________________________"
            + Environment.NewLine + Environment.NewLine;
        }

        public override void SetDataAndSignature()
        {
            document.DataAndSignature = "Длъжност: ________" + "                      " + "Подпис и печат: ";
        }
    }
}
