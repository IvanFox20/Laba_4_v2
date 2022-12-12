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
    public partial class Deserialize : Form
    {
        public Deserialize()
        {
            InitializeComponent();
        }

        private void Cat_RadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Bird_RadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Deserialize_Button_Click(object sender, EventArgs e)
        {
            if (Cat_RadioButton.Checked)
            {
                CatsDeserialize_FileDialog.InitialDirectory = "d:\\";
                CatsDeserialize_FileDialog.Filter = "xml files (*.xml)|*.xml";
                CatsDeserialize_FileDialog.RestoreDirectory = true;

                if (CatsDeserialize_FileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file

                    XmlSerializer serializer = new XmlSerializer(typeof(List<Cat>));
                    //Read the contents of the file into a stream
                    var fileStream = CatsDeserialize_FileDialog.OpenFile();
                    List<Cat>? cats = null;
                    try
                    {
                        cats = (List<Cat>?)serializer.Deserialize(fileStream);
                    }
                    catch
                    {
                        MessageBox.Show("Некоректный файл для чтения котов");
                        this.Close();
                        return;
                    }
                    if (cats != null)
                    {
                        MainForm.Cats = cats;
                        this.Close();
                        return;
                    }
                }
            }
            if (Bird_RadioButton.Checked)
            {
                Birds_Deserialize_FileDialog.InitialDirectory = "d:\\";
                Birds_Deserialize_FileDialog.Filter = "xml files (*.xml)|*.xml";
                Birds_Deserialize_FileDialog.RestoreDirectory = true;

                if (Birds_Deserialize_FileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file

                    XmlSerializer serializer = new XmlSerializer(typeof(List<Bird>));
                    //Read the contents of the file into a stream
                    var fileStream = Birds_Deserialize_FileDialog.OpenFile();
                    List<Bird>? birds = null;
                    try
                    {
                        birds = (List<Bird>?)serializer.Deserialize(fileStream);
                    }
                    catch
                    {
                        MessageBox.Show("Некоректный файл для чтения птиц");
                        this.Close();
                        return;
                    }
                    if (birds != null)
                    {
                        MainForm.Birds = birds;
                        this.Close();
                        return;
                    }
                }
            }
        }

        private void CatsDeserialize_FileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Birds_Deserialize_FileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
