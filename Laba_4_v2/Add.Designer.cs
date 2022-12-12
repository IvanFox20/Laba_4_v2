namespace Laba_4_v2
{
    partial class Add
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Animal_Group_Label = new System.Windows.Forms.Label();
            this.Weight_Label = new System.Windows.Forms.Label();
            this.Nickname_Label = new System.Windows.Forms.Label();
            this.Form_Label = new System.Windows.Forms.Label();
            this.Age_Label = new System.Windows.Forms.Label();
            this.Wingspan_Label = new System.Windows.Forms.Label();
            this.Color_Label = new System.Windows.Forms.Label();
            this.Breed_Label = new System.Windows.Forms.Label();
            this.Cat_RadioButton = new System.Windows.Forms.RadioButton();
            this.Bird_RadioButton = new System.Windows.Forms.RadioButton();
            this.Weight_TextBox = new System.Windows.Forms.TextBox();
            this.Nickname_Form_TextBox = new System.Windows.Forms.TextBox();
            this.Age_Wingspan_Textbox = new System.Windows.Forms.TextBox();
            this.Color_Textbox = new System.Windows.Forms.TextBox();
            this.Breed_Textbox = new System.Windows.Forms.TextBox();
            this.Add_Button = new System.Windows.Forms.Button();
            this.CatGridView = new System.Windows.Forms.DataGridView();
            this.BirdGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CatGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BirdGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Animal_Group_Label
            // 
            this.Animal_Group_Label.AutoSize = true;
            this.Animal_Group_Label.Location = new System.Drawing.Point(84, 39);
            this.Animal_Group_Label.Name = "Animal_Group_Label";
            this.Animal_Group_Label.Size = new System.Drawing.Size(108, 15);
            this.Animal_Group_Label.TabIndex = 0;
            this.Animal_Group_Label.Text = "Группы животных";
            this.Animal_Group_Label.Click += new System.EventHandler(this.Animal_Group_Label_Click);
            // 
            // Weight_Label
            // 
            this.Weight_Label.AutoSize = true;
            this.Weight_Label.Location = new System.Drawing.Point(84, 78);
            this.Weight_Label.Name = "Weight_Label";
            this.Weight_Label.Size = new System.Drawing.Size(26, 15);
            this.Weight_Label.TabIndex = 1;
            this.Weight_Label.Text = "Вес";
            this.Weight_Label.Click += new System.EventHandler(this.Weight_Label_Click);
            // 
            // Nickname_Label
            // 
            this.Nickname_Label.AutoSize = true;
            this.Nickname_Label.Location = new System.Drawing.Point(84, 109);
            this.Nickname_Label.Name = "Nickname_Label";
            this.Nickname_Label.Size = new System.Drawing.Size(47, 15);
            this.Nickname_Label.TabIndex = 2;
            this.Nickname_Label.Text = "Кличка";
            this.Nickname_Label.Click += new System.EventHandler(this.Nickname_Label_Click);
            // 
            // Form_Label
            // 
            this.Form_Label.AutoSize = true;
            this.Form_Label.Location = new System.Drawing.Point(84, 109);
            this.Form_Label.Name = "Form_Label";
            this.Form_Label.Size = new System.Drawing.Size(27, 15);
            this.Form_Label.TabIndex = 3;
            this.Form_Label.Text = "Вид";
            this.Form_Label.Click += new System.EventHandler(this.Form_Label_Click);
            // 
            // Age_Label
            // 
            this.Age_Label.AutoSize = true;
            this.Age_Label.Location = new System.Drawing.Point(83, 141);
            this.Age_Label.Name = "Age_Label";
            this.Age_Label.Size = new System.Drawing.Size(50, 15);
            this.Age_Label.TabIndex = 4;
            this.Age_Label.Text = "Возраст";
            // 
            // Wingspan_Label
            // 
            this.Wingspan_Label.AutoSize = true;
            this.Wingspan_Label.Location = new System.Drawing.Point(84, 141);
            this.Wingspan_Label.Name = "Wingspan_Label";
            this.Wingspan_Label.Size = new System.Drawing.Size(96, 15);
            this.Wingspan_Label.TabIndex = 5;
            this.Wingspan_Label.Text = "Размах крыльев";
            this.Wingspan_Label.Click += new System.EventHandler(this.Wingspan_Label_Click);
            // 
            // Color_Label
            // 
            this.Color_Label.AutoSize = true;
            this.Color_Label.Location = new System.Drawing.Point(84, 178);
            this.Color_Label.Name = "Color_Label";
            this.Color_Label.Size = new System.Drawing.Size(33, 15);
            this.Color_Label.TabIndex = 6;
            this.Color_Label.Text = "Цвет";
            this.Color_Label.Click += new System.EventHandler(this.Color_Label_Click);
            // 
            // Breed_Label
            // 
            this.Breed_Label.AutoSize = true;
            this.Breed_Label.Location = new System.Drawing.Point(84, 212);
            this.Breed_Label.Name = "Breed_Label";
            this.Breed_Label.Size = new System.Drawing.Size(49, 15);
            this.Breed_Label.TabIndex = 7;
            this.Breed_Label.Text = "Порода";
            this.Breed_Label.Click += new System.EventHandler(this.Breed_Label_Click);
            // 
            // Cat_RadioButton
            // 
            this.Cat_RadioButton.AutoSize = true;
            this.Cat_RadioButton.Location = new System.Drawing.Point(225, 39);
            this.Cat_RadioButton.Name = "Cat_RadioButton";
            this.Cat_RadioButton.Size = new System.Drawing.Size(44, 19);
            this.Cat_RadioButton.TabIndex = 8;
            this.Cat_RadioButton.TabStop = true;
            this.Cat_RadioButton.Text = "Кот";
            this.Cat_RadioButton.UseVisualStyleBackColor = true;
            this.Cat_RadioButton.CheckedChanged += new System.EventHandler(this.Cat_RadioButton_CheckedChanged);
            // 
            // Bird_RadioButton
            // 
            this.Bird_RadioButton.AutoSize = true;
            this.Bird_RadioButton.Location = new System.Drawing.Point(266, 39);
            this.Bird_RadioButton.Name = "Bird_RadioButton";
            this.Bird_RadioButton.Size = new System.Drawing.Size(59, 19);
            this.Bird_RadioButton.TabIndex = 9;
            this.Bird_RadioButton.TabStop = true;
            this.Bird_RadioButton.Text = "Птица";
            this.Bird_RadioButton.UseVisualStyleBackColor = true;
            this.Bird_RadioButton.CheckedChanged += new System.EventHandler(this.Bird_RadioButton_CheckedChanged);
            // 
            // Weight_TextBox
            // 
            this.Weight_TextBox.Location = new System.Drawing.Point(225, 70);
            this.Weight_TextBox.Name = "Weight_TextBox";
            this.Weight_TextBox.Size = new System.Drawing.Size(100, 23);
            this.Weight_TextBox.TabIndex = 10;
            this.Weight_TextBox.TextChanged += new System.EventHandler(this.Weight_TextBox_TextChanged);
            // 
            // Nickname_Form_TextBox
            // 
            this.Nickname_Form_TextBox.Location = new System.Drawing.Point(225, 101);
            this.Nickname_Form_TextBox.Name = "Nickname_Form_TextBox";
            this.Nickname_Form_TextBox.Size = new System.Drawing.Size(100, 23);
            this.Nickname_Form_TextBox.TabIndex = 11;
            this.Nickname_Form_TextBox.TextChanged += new System.EventHandler(this.Nickname_Form_TextBox_TextChanged);
            // 
            // Age_Wingspan_Textbox
            // 
            this.Age_Wingspan_Textbox.Location = new System.Drawing.Point(225, 133);
            this.Age_Wingspan_Textbox.Name = "Age_Wingspan_Textbox";
            this.Age_Wingspan_Textbox.Size = new System.Drawing.Size(100, 23);
            this.Age_Wingspan_Textbox.TabIndex = 12;
            this.Age_Wingspan_Textbox.TextChanged += new System.EventHandler(this.Age_Wingspan_Textbox_TextChanged);
            // 
            // Color_Textbox
            // 
            this.Color_Textbox.Location = new System.Drawing.Point(225, 170);
            this.Color_Textbox.Name = "Color_Textbox";
            this.Color_Textbox.Size = new System.Drawing.Size(100, 23);
            this.Color_Textbox.TabIndex = 13;
            this.Color_Textbox.TextChanged += new System.EventHandler(this.Color_Textbox_TextChanged);
            // 
            // Breed_Textbox
            // 
            this.Breed_Textbox.Location = new System.Drawing.Point(225, 204);
            this.Breed_Textbox.Name = "Breed_Textbox";
            this.Breed_Textbox.Size = new System.Drawing.Size(100, 23);
            this.Breed_Textbox.TabIndex = 14;
            this.Breed_Textbox.TextChanged += new System.EventHandler(this.Breed_Textbox_TextChanged);
            // 
            // Add_Button
            // 
            this.Add_Button.BackColor = System.Drawing.Color.Chartreuse;
            this.Add_Button.Location = new System.Drawing.Point(83, 262);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(250, 100);
            this.Add_Button.TabIndex = 15;
            this.Add_Button.Text = "Добавить";
            this.Add_Button.UseVisualStyleBackColor = false;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // CatGridView
            // 
            this.CatGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CatGridView.Location = new System.Drawing.Point(385, 12);
            this.CatGridView.Name = "CatGridView";
            this.CatGridView.RowTemplate.Height = 25;
            this.CatGridView.Size = new System.Drawing.Size(400, 350);
            this.CatGridView.TabIndex = 16;
            this.CatGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CatGridView_CellContentClick);
            // 
            // BirdGridView
            // 
            this.BirdGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BirdGridView.Location = new System.Drawing.Point(385, 12);
            this.BirdGridView.Name = "BirdGridView";
            this.BirdGridView.RowTemplate.Height = 25;
            this.BirdGridView.Size = new System.Drawing.Size(400, 350);
            this.BirdGridView.TabIndex = 17;
            this.BirdGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BirdGridView_CellContentClick);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 386);
            this.Controls.Add(this.BirdGridView);
            this.Controls.Add(this.CatGridView);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.Breed_Textbox);
            this.Controls.Add(this.Color_Textbox);
            this.Controls.Add(this.Age_Wingspan_Textbox);
            this.Controls.Add(this.Nickname_Form_TextBox);
            this.Controls.Add(this.Weight_TextBox);
            this.Controls.Add(this.Bird_RadioButton);
            this.Controls.Add(this.Cat_RadioButton);
            this.Controls.Add(this.Breed_Label);
            this.Controls.Add(this.Color_Label);
            this.Controls.Add(this.Wingspan_Label);
            this.Controls.Add(this.Age_Label);
            this.Controls.Add(this.Form_Label);
            this.Controls.Add(this.Nickname_Label);
            this.Controls.Add(this.Weight_Label);
            this.Controls.Add(this.Animal_Group_Label);
            this.Name = "Add";
            this.Text = "Add";
            this.Load += new System.EventHandler(this.Add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CatGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BirdGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Animal_Group_Label;
        private Label Weight_Label;
        private Label Nickname_Label;
        private Label Form_Label;
        private Label Age_Label;
        private Label Wingspan_Label;
        private Label Color_Label;
        private Label Breed_Label;
        private RadioButton Cat_RadioButton;
        private RadioButton Bird_RadioButton;
        private TextBox Weight_TextBox;
        private TextBox Nickname_Form_TextBox;
        private TextBox Age_Wingspan_Textbox;
        private TextBox Color_Textbox;
        private TextBox Breed_Textbox;
        private Button Add_Button;
        private DataGridView CatGridView;
        private DataGridView BirdGridView;
    }
}