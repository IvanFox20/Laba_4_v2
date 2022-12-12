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
    public partial class Find : Form
    {
        public Find()
        {
            InitializeComponent();
        }

        private void Animal_Group_Label_Click(object sender, EventArgs e)
        {

        }

        private void Breed_Label_Click(object sender, EventArgs e)
        {

        }

        private void Form_Label_Click(object sender, EventArgs e)
        {
        }

        private void id_TextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void Find_Button_Click(object sender, EventArgs e)
        {
            if (Cat_RadioButton.Checked)//Если выбран пассажирский поезд
            {
                string id = id_TextBox.Text;
                foreach (var t in MainForm.Cats)//Поиск информации о поезде по его номеру
                {
                    if (t.breed == id)
                    {
                        MessageBox.Show("Найден кот " + id + '\n' + " Информация о нем: " + " Вес: " + t.weight + " Кличка: " + t.name + " Возраст: " + t.age + " Цвет " + t.color + " Порода " + t.breed);
                        return;
                    }
                }
                MessageBox.Show("Кот " + id + " не найден" + '\n');
            }
            else
            {
                string id = id_TextBox.Text;
                foreach (var t in MainForm.Birds)
                {
                    if (t.form == id)
                    {
                        MessageBox.Show("Найдена птица " + id + '\n' + " Информация о ней: " + " Вес: " + t.weight + " Вид: " + t.form + " Размах крыльев: " + t.wingspan + " Цвет: " + t.color);
                        return;
                    }
                }
                MessageBox.Show("Птица " + id + " не найдена "+ '\n');
            }
        }

        private void Cat_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Cat_RadioButton.Checked)
            {
                Breed_Label.Visible = true;
                Form_Label.Visible = false;
            }
        }

        private void Bird_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Bird_RadioButton.Checked)
            {
                Breed_Label.Visible = false;
                Form_Label.Visible = true;
            }
        }
    }
}
