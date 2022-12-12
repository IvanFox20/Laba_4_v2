using Laba_4_inform;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Laba_4_v2
{
    public partial class Serialize : Form
    {
        public Serialize()
        {
            InitializeComponent();
        }
        private void Serialize_Button_Click(object sender, EventArgs e)
        {
            if (Cat_RadioButton.Checked)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Cat>));
                using TextWriter writer = new StreamWriter("cats.xml");
                serializer.Serialize(writer, MainForm.Cats);
                writer.Close();
                this.Close();
            }
            if (Bird_RadioButton.Checked)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Bird>));
                using TextWriter writer = new StreamWriter("birds.xml");
                serializer.Serialize(writer, MainForm.Birds);
                writer.Close();
                this.Close();
            }

        }
        private void Cat_RadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Bird_RadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
