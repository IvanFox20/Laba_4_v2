using Laba_4_v2;
using System.Globalization;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Laba_4_inform
{
    public partial class MainForm : Form
    {

        public static List<Cat> Cats = new List<Cat>();
        public static List<Bird> Birds = new List<Bird>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void Update()
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
        private void Form1_Load(object sender, EventArgs e)
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

            // начальный набор данных    
            Cats.Add(new Cat(5, "Жора", 3, "зеленый","сиамская"));
            Cats.Add(new Cat(14, "Олег", 5, "синий","вислоухий"));
            Cats.Add(new Cat(50, "Лысый", 8, "красный","сфинкс"));
            Birds.Add(new Bird(4, "голубь", 20, "серый"));
            Birds.Add(new Bird(3, "воробей", 70, "коричневый"));
            Cats.Sort();
            Birds.Sort();
            Update();
        }

        private void Cat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Bird_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            Add f = new Add(Cats, Birds);
            f.Owner = this;
            f.ShowDialog();
            Update();
        }

        private void Find_Click(object sender, EventArgs e)
        {
            Find f = new Find();
            f.Owner = this;
            f.ShowDialog();
            Update();
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            //Создание нового окна
            Delete f = new Delete();
            f.Owner = this;
            f.ShowDialog();
            //Обновление данных в CatGridView и BirdGridView
            Update();
        }

        private void Serialize_Button_Click_1(object sender, EventArgs e)
        {
            Serialize f = new Serialize();
            f.Owner = this;
            f.ShowDialog();
            Update();
        }

        private void Deserialize_Button_Click(object sender, EventArgs e)
        {
            Deserialize f = new Deserialize();
            f.Owner = this;
            f.ShowDialog();
            Update();
        }
    }

    public class Animal : IComparable
    {
        public string? id;
        public string? color;
        public int weight;

        public Animal ()
        {
            
        }
        public Animal(string id,string color,int weight)
        {
            this.id = id;
            this.color = color;
            this.weight = weight;
        }

        public int CompareTo(object o)
        {
            Animal p = o as Animal;
            if (p != null)
                return this.id.CompareTo(p.id);
            else
                throw new Exception("Невозможно сравнить два объекта");
        }

    }

    public class Cat : Animal
    {
        public int age;
        public string? breed;
        public string? name;

        public Cat() { }
        public Cat(int weight,string id,int age,string color,string breed) : base(id,color,weight)
        {
            
            name = id;
            this.age = age;
            this.breed = breed;
        }

    }

    public class Bird : Animal
    {
        public string? form;
        public int wingspan;

        public Bird() { }
        public Bird(int weight,string id,int wingspan,string color) : base(id,color,weight)
        {
            form = id;
            this.wingspan = wingspan;
        }
    }
}