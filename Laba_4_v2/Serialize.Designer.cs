namespace Laba_4_v2
{
    partial class Serialize
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
            this.Cat_RadioButton = new System.Windows.Forms.RadioButton();
            this.Bird_RadioButton = new System.Windows.Forms.RadioButton();
            this.Serialize_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Cat_RadioButton
            // 
            this.Cat_RadioButton.AutoSize = true;
            this.Cat_RadioButton.Location = new System.Drawing.Point(59, 38);
            this.Cat_RadioButton.Name = "Cat_RadioButton";
            this.Cat_RadioButton.Size = new System.Drawing.Size(44, 19);
            this.Cat_RadioButton.TabIndex = 0;
            this.Cat_RadioButton.TabStop = true;
            this.Cat_RadioButton.Text = "Кот";
            this.Cat_RadioButton.UseVisualStyleBackColor = true;
            this.Cat_RadioButton.CheckedChanged += new System.EventHandler(this.Cat_RadioButton_CheckedChanged);
            // 
            // Bird_RadioButton
            // 
            this.Bird_RadioButton.AutoSize = true;
            this.Bird_RadioButton.Location = new System.Drawing.Point(109, 38);
            this.Bird_RadioButton.Name = "Bird_RadioButton";
            this.Bird_RadioButton.Size = new System.Drawing.Size(59, 19);
            this.Bird_RadioButton.TabIndex = 1;
            this.Bird_RadioButton.TabStop = true;
            this.Bird_RadioButton.Text = "Птица";
            this.Bird_RadioButton.UseVisualStyleBackColor = true;
            this.Bird_RadioButton.CheckedChanged += new System.EventHandler(this.Bird_RadioButton_CheckedChanged);
            // 
            // Serialize_Button
            // 
            this.Serialize_Button.BackColor = System.Drawing.Color.Chocolate;
            this.Serialize_Button.Location = new System.Drawing.Point(12, 100);
            this.Serialize_Button.Name = "Serialize_Button";
            this.Serialize_Button.Size = new System.Drawing.Size(200, 70);
            this.Serialize_Button.TabIndex = 2;
            this.Serialize_Button.Text = "Сериализация";
            this.Serialize_Button.UseVisualStyleBackColor = false;
            this.Serialize_Button.Click += new System.EventHandler(this.Serialize_Button_Click);
            // 
            // Serialize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 203);
            this.Controls.Add(this.Serialize_Button);
            this.Controls.Add(this.Bird_RadioButton);
            this.Controls.Add(this.Cat_RadioButton);
            this.Name = "Serialize";
            this.Text = "Serialize";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton Cat_RadioButton;
        private RadioButton Bird_RadioButton;
        private Button Serialize_Button;
    }
}