using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Laba_4_inform;

namespace Laba_4_v2
{
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void Delete_Load(object sender, EventArgs e)
        {

        }

        private void Nickname_Label_Click(object sender, EventArgs e)
        {

        }

        private void Animal_Group_Label_Click(object sender, EventArgs e)
        {

        }

        private void Form_Label_Click(object sender, EventArgs e)
        {

        }

        private void Cat_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Cat_RadioButton.Checked)
            {
                Nickname_Label.Visible = true;
                Form_Label.Visible = false;
            }
        }

        private void Bird_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Bird_RadioButton.Checked)
            {
                Nickname_Label.Visible = false;
                Form_Label.Visible = true;
            }
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            if (Cat_RadioButton.Checked)
            {
                string id = id_TextBox.Text;
                foreach (var t in MainForm.Cats)
                {
                    if (t.name == id)
                    {
                        MainForm.Cats.Remove(t);
                        this.Close();
                        return;
                    }
                }
            }
            else
            {
                string id = id_TextBox.Text;
                foreach (var t in MainForm.Birds)
                {
                    if (t.form == id)
                    {
                        MainForm.Birds.Remove(t);
                        this.Close();
                        return;
                    }
                }
            }
            MessageBox.Show("Не найдено указанное животное");
        }

        private void id_TextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
