using Laba_4_inform;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Laba_4_v2
{
    public partial class Add : Form
    {
        public static List<Cat> Cats = new List<Cat>();//список пассажирских поездов
        public static List<Bird> Birds = new List<Bird>();//список грузовых поездов
        public Add(List<Cat> _Cats,List<Bird> _Birds)
        {
            Cats = _Cats;
            Birds = _Birds;
            InitializeComponent();
        }

        private void Update()//Обновляет данные в CatGridView и BirdGridView
        {
            CatGridView.Rows.Clear();
            int n = Cats.Count;
            if (n > 0)
                CatGridView.Rows.Add(n);
            for (int i = 0; i < n; ++i)
            {
                CatGridView.Rows[i].Cells["Weight"].Value = Cats[i].weight;
                CatGridView.Rows[i].Cells["Name"].Value = Cats[i].name;
                CatGridView.Rows[i].Cells["Age"].Value = Cats[i].age;
                CatGridView.Rows[i].Cells["Color"].Value = Cats[i].color;
                CatGridView.Rows[i].Cells["Breed"].Value = Cats[i].breed;
            }
            BirdGridView.Rows.Clear();
            n = Birds.Count;
            if (n > 0)
                BirdGridView.Rows.Add(n);
            for (int i = 0; i < n; ++i)
            {
                BirdGridView.Rows[i].Cells["Weight"].Value = Birds[i].weight;
                BirdGridView.Rows[i].Cells["Form"].Value = Birds[i].form;
                BirdGridView.Rows[i].Cells["Wingspan"].Value = Birds[i].wingspan;
                BirdGridView.Rows[i].Cells["Color"].Value = Birds[i].color;
            }
        }
        private void Add_Load(object sender, EventArgs e)
        {
            CatGridView.Columns.Clear();
            CatGridView.ReadOnly = true;
            CatGridView.AllowUserToAddRows = false;
            CatGridView.AllowUserToDeleteRows = false;
            //CatGridView.AutoResizeColumns();
            CatGridView.Columns.Add("Weight", "Вес");
            CatGridView.Columns.Add("Name", "Кличка");
            CatGridView.Columns.Add("Age", "Возраст");
            CatGridView.Columns.Add("Color", "Цвет");
            CatGridView.Columns.Add("Breed", "Порода");
            //CatGridView.RowCount = 1;

            BirdGridView.Columns.Clear();
            BirdGridView.ReadOnly = true;
            BirdGridView.AllowUserToAddRows = false;
            BirdGridView.AllowUserToDeleteRows = false;
            //BirdGridView.AutoResizeColumns();
            BirdGridView.Columns.Add("Weight", "Вес");
            BirdGridView.Columns.Add("Form", "Вид");
            BirdGridView.Columns.Add("Wingspan", "Размах крыльев");
            BirdGridView.Columns.Add("Color", "Цвет");
            //BirdGridView.RowCount = 1;

            Update();
        }

        private void Weight_Label_Click(object sender, EventArgs e)
        {

        }

        private void Animal_Group_Label_Click(object sender, EventArgs e)
        {

        }

        private void Nickname_Label_Click(object sender, EventArgs e)
        {

        }

        private void Breed_Textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_Label_Click(object sender, EventArgs e)
        {

        }

        private void Wingspan_Label_Click(object sender, EventArgs e)
        {

        }

        private void Age_Wingspan_Textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Weight_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nickname_Form_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Color_Textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bird_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Bird_RadioButton.Checked)
            {
                Cat_RadioButton.Checked = false;
                Weight_Label.Visible = true;
                Nickname_Label.Visible = false;
                Age_Label.Visible = false;
                Color_Label.Visible = true;
                Breed_Label.Visible = false;
                Form_Label.Visible = true;
                Wingspan_Label.Visible = true;
                Breed_Textbox.Visible = false;
                CatGridView.Visible = false;
                BirdGridView.Visible = true;

            }
        }

        private void Cat_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Cat_RadioButton.Checked)
            {
                Bird_RadioButton.Checked = false;
                Weight_Label.Visible = true;
                Nickname_Label.Visible = true;
                Age_Label.Visible = true;
                Color_Label.Visible = true;
                Breed_Label.Visible = true;
                Form_Label.Visible = false;
                Wingspan_Label.Visible = false;
                Breed_Textbox.Visible = true;
                CatGridView.Visible = true;
                BirdGridView.Visible = false;
            }
        }

        private void Breed_Label_Click(object sender, EventArgs e)
        {

        }

        private void Color_Label_Click(object sender, EventArgs e)
        {

        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            if (Cat_RadioButton.Checked)//Если добавляем кота
            {
                string weight = Weight_TextBox.Text;
                string nickname = Nickname_Form_TextBox.Text;
                string age = Age_Wingspan_Textbox.Text;
                string color = Color_Textbox.Text;
                string breed = Breed_Textbox.Text;
                int ageInt;
                int weightInt;
                if (weight == "" || nickname == "" || age == "" || color == "" || breed == "")//Проверка на заполненность всех полей
                {
                    MessageBox.Show("Заполнены не все поля");
                    return;
                }
                try//Проверка на валидность полей
                {
                    ageInt = Convert.ToInt32(age);
                    weightInt = Convert.ToInt32(weight);
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Поля имеют неверный формат");
                    return;
                }
                foreach (var t in MainForm.Cats)//Проверка на уникальность пассажирского поезда по номеру
                {
                    if (t.name == nickname)
                    {
                        MessageBox.Show("Кошка с такой кличкой уже существует");
                        Weight_TextBox.ResetText();
                        Nickname_Form_TextBox.ResetText();
                        Age_Wingspan_Textbox.ResetText();
                        Color_Textbox.ResetText();
                        Breed_Textbox.ResetText();
                        return;
                    }
                }
                MainForm.Cats.Add(new Cat(weightInt, nickname, ageInt, color, breed));//Добавление поезда
                MainForm.Cats.Sort();
            }
            else//Если добавляем птицу
            {
                string weight = Weight_TextBox.Text;
                string form = Nickname_Form_TextBox.Text;
                string wingspan = Age_Wingspan_Textbox.Text;
                string color = Color_Textbox.Text;
                int wingspanInt;
                int weightInt;
                if (weight == "" || form == "" || wingspan == "" || color == "")//Проверка на заполненность всех полей
                {
                    MessageBox.Show("Заполнены не все поля");
                    return;
                }
                try//Проверка на валидность полей
                {
                    wingspanInt = Convert.ToInt32(wingspan);
                    weightInt = Convert.ToInt32(weight);
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Поля имеют неверный формат");
                    return;
                }
                foreach (var t in MainForm.Birds)//Проверка на уникальность грузового поезда по номеру
                {
                    if (t.form == form)
                    {
                        MessageBox.Show("Птица такого вида уже существует");
                        Weight_TextBox.ResetText();
                        Nickname_Form_TextBox.ResetText();
                        Age_Wingspan_Textbox.ResetText();
                        Color_Textbox.ResetText();
                        return;
                    }
                }
                MainForm.Birds.Add(new Bird(weightInt, form, wingspanInt, color));//Добавление поезда
                MainForm.Birds.Sort();
            }
            this.Close();
        }

        private void Add_Load_1(object sender, EventArgs e)
        {
        }

        private void Add_Load_2(object sender, EventArgs e)
        {

        }

        private void CatGridViewAdd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CatGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BirdGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
