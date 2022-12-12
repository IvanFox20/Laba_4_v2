namespace Laba_4_inform
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CatGridView = new System.Windows.Forms.DataGridView();
            this.BirdGridView = new System.Windows.Forms.DataGridView();
            this.Find = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Serialize_Button = new System.Windows.Forms.Button();
            this.Deserialize_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CatGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BirdGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CatGridView
            // 
            this.CatGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CatGridView.Location = new System.Drawing.Point(12, 12);
            this.CatGridView.Name = "CatGridView";
            this.CatGridView.RowTemplate.Height = 25;
            this.CatGridView.Size = new System.Drawing.Size(385, 351);
            this.CatGridView.TabIndex = 0;
            this.CatGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Cat_CellContentClick);
            // 
            // BirdGridView
            // 
            this.BirdGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BirdGridView.Location = new System.Drawing.Point(403, 12);
            this.BirdGridView.Name = "BirdGridView";
            this.BirdGridView.RowTemplate.Height = 25;
            this.BirdGridView.Size = new System.Drawing.Size(385, 351);
            this.BirdGridView.TabIndex = 1;
            this.BirdGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Bird_CellContentClick);
            // 
            // Find
            // 
            this.Find.BackColor = System.Drawing.SystemColors.Highlight;
            this.Find.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Find.Location = new System.Drawing.Point(328, 369);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(150, 69);
            this.Find.TabIndex = 2;
            this.Find.Text = "Поиск";
            this.Find.UseVisualStyleBackColor = false;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Firebrick;
            this.Delete.Location = new System.Drawing.Point(172, 369);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(150, 69);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.Chartreuse;
            this.Add.Location = new System.Drawing.Point(12, 369);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(150, 69);
            this.Add.TabIndex = 4;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Serialize_Button
            // 
            this.Serialize_Button.BackColor = System.Drawing.Color.Chocolate;
            this.Serialize_Button.Location = new System.Drawing.Point(484, 369);
            this.Serialize_Button.Name = "Serialize_Button";
            this.Serialize_Button.Size = new System.Drawing.Size(150, 69);
            this.Serialize_Button.TabIndex = 5;
            this.Serialize_Button.Text = "Сериализация";
            this.Serialize_Button.UseVisualStyleBackColor = false;
            this.Serialize_Button.Click += new System.EventHandler(this.Serialize_Button_Click_1);
            // 
            // Deserialize_Button
            // 
            this.Deserialize_Button.BackColor = System.Drawing.Color.Yellow;
            this.Deserialize_Button.Location = new System.Drawing.Point(638, 369);
            this.Deserialize_Button.Name = "Deserialize_Button";
            this.Deserialize_Button.Size = new System.Drawing.Size(150, 69);
            this.Deserialize_Button.TabIndex = 6;
            this.Deserialize_Button.Text = "Десериализация";
            this.Deserialize_Button.UseVisualStyleBackColor = false;
            this.Deserialize_Button.Click += new System.EventHandler(this.Deserialize_Button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Deserialize_Button);
            this.Controls.Add(this.Serialize_Button);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.BirdGridView);
            this.Controls.Add(this.CatGridView);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CatGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BirdGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView CatGridView;
        private DataGridView BirdGridView;
        private Button Find;
        private Button Delete;
        private Button Add;
        private Button Serialize_Button;
        private Button Deserialize_Button;
    }
}