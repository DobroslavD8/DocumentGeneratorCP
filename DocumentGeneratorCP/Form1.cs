using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentGeneratorCP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            typeComboBox.SelectedIndex = 0;
        }

        private void doctypelbl_Click(object sender, EventArgs e)
        {

        }

        private void generatebtn_Click(object sender, EventArgs e)
        {
            Message CustomMessage = new Message("There's generated example of ");

            string selectedItem = typeComboBox.SelectedItem.ToString();
            DocumentDirector director = new DocumentDirector();
            Document result = director.GenerateDocument(DocumentFactory.MatchDocumentType(selectedItem, CustomMessage));

            string selected = this.typeComboBox.GetItemText(this.typeComboBox.SelectedItem);
            if (selected == "Affirmation")
            {
                IMessage Decorator = new AffirmationDocDecorator(CustomMessage);
                SpecifyLabel.Text = Decorator.Operation();
            }
            else if (selected == "Application")
            {
                IMessage Decorator = new ApplicationDecorator(CustomMessage);
                SpecifyLabel.Text = Decorator.Operation();
            }
            else if (selected == "An Apologetic Note")
            {
                IMessage Decorator = new ApologeticNoteDecorator(CustomMessage);
                SpecifyLabel.Text = Decorator.Operation();
            }



            resultBox.Text = result.Header + result.TypeOfDocument + Environment.NewLine + result.PersonalData + Environment.NewLine + result.Message + Environment.NewLine + result.DataAndSignature;

            resultBox.TextAlign = HorizontalAlignment.Center;
            resultBox.Font = new Font(resultBox.Font.FontFamily, 10);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void resultBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        //private void SpecifyBox_TextChanged(object sender, EventArgs e)
        //{

        //}
    }
}
