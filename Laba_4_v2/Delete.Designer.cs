namespace Laba_4_v2
{
    partial class Delete
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
            this.Nickname_Label = new System.Windows.Forms.Label();
            this.Form_Label = new System.Windows.Forms.Label();
            this.Cat_RadioButton = new System.Windows.Forms.RadioButton();
            this.Bird_RadioButton = new System.Windows.Forms.RadioButton();
            this.id_TextBox = new System.Windows.Forms.TextBox();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Animal_Group_Label
            // 
            this.Animal_Group_Label.AutoSize = true;
            this.Animal_Group_Label.Location = new System.Drawing.Point(79, 56);
            this.Animal_Group_Label.Name = "Animal_Group_Label";
            this.Animal_Group_Label.Size = new System.Drawing.Size(105, 15);
            this.Animal_Group_Label.TabIndex = 0;
            this.Animal_Group_Label.Text = "Группа животных";
            this.Animal_Group_Label.Click += new System.EventHandler(this.Animal_Group_Label_Click);
            // 
            // Nickname_Label
            // 
            this.Nickname_Label.AutoSize = true;
            this.Nickname_Label.Location = new System.Drawing.Point(79, 114);
            this.Nickname_Label.Name = "Nickname_Label";
            this.Nickname_Label.Size = new System.Drawing.Size(47, 15);
            this.Nickname_Label.TabIndex = 1;
            this.Nickname_Label.Text = "Кличка";
            this.Nickname_Label.Click += new System.EventHandler(this.Nickname_Label_Click);
            // 
            // Form_Label
            // 
            this.Form_Label.AutoSize = true;
            this.Form_Label.Location = new System.Drawing.Point(79, 114);
            this.Form_Label.Name = "Form_Label";
            this.Form_Label.Size = new System.Drawing.Size(27, 15);
            this.Form_Label.TabIndex = 2;
            this.Form_Label.Text = "Вид";
            this.Form_Label.Click += new System.EventHandler(this.Form_Label_Click);
            // 
            // Cat_RadioButton
            // 
            this.Cat_RadioButton.AutoSize = true;
            this.Cat_RadioButton.Location = new System.Drawing.Point(180, 56);
            this.Cat_RadioButton.Name = "Cat_RadioButton";
            this.Cat_RadioButton.Size = new System.Drawing.Size(44, 19);
            this.Cat_RadioButton.TabIndex = 3;
            this.Cat_RadioButton.TabStop = true;
            this.Cat_RadioButton.Text = "Кот";
            this.Cat_RadioButton.UseVisualStyleBackColor = true;
            this.Cat_RadioButton.CheckedChanged += new System.EventHandler(this.Cat_RadioButton_CheckedChanged);
            // 
            // Bird_RadioButton
            // 
            this.Bird_RadioButton.AutoSize = true;
            this.Bird_RadioButton.Location = new System.Drawing.Point(221, 56);
            this.Bird_RadioButton.Name = "Bird_RadioButton";
            this.Bird_RadioButton.Size = new System.Drawing.Size(59, 19);
            this.Bird_RadioButton.TabIndex = 4;
            this.Bird_RadioButton.TabStop = true;
            this.Bird_RadioButton.Text = "Птица";
            this.Bird_RadioButton.UseVisualStyleBackColor = true;
            this.Bird_RadioButton.CheckedChanged += new System.EventHandler(this.Bird_RadioButton_CheckedChanged);
            // 
            // id_TextBox
            // 
            this.id_TextBox.Location = new System.Drawing.Point(180, 106);
            this.id_TextBox.Name = "id_TextBox";
            this.id_TextBox.Size = new System.Drawing.Size(100, 23);
            this.id_TextBox.TabIndex = 5;
            this.id_TextBox.TextChanged += new System.EventHandler(this.id_TextBox_TextChanged);
            // 
            // Delete_Button
            // 
            this.Delete_Button.BackColor = System.Drawing.Color.Firebrick;
            this.Delete_Button.Location = new System.Drawing.Point(80, 180);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(200, 70);
            this.Delete_Button.TabIndex = 6;
            this.Delete_Button.Text = "Удалить";
            this.Delete_Button.UseVisualStyleBackColor = false;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.Delete_Button);
            this.Controls.Add(this.id_TextBox);
            this.Controls.Add(this.Bird_RadioButton);
            this.Controls.Add(this.Cat_RadioButton);
            this.Controls.Add(this.Form_Label);
            this.Controls.Add(this.Nickname_Label);
            this.Controls.Add(this.Animal_Group_Label);
            this.Name = "Delete";
            this.Text = "Delete";
            this.Load += new System.EventHandler(this.Delete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Animal_Group_Label;
        private Label Nickname_Label;
        private Label Form_Label;
        private RadioButton Cat_RadioButton;
        private RadioButton Bird_RadioButton;
        private TextBox id_TextBox;
        private Button Delete_Button;
    }
}