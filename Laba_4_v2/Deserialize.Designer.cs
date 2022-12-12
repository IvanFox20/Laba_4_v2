namespace Laba_4_v2
{
    partial class Deserialize
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
            this.CatsDeserialize_FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.Deserialize_Button = new System.Windows.Forms.Button();
            this.Birds_Deserialize_FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // Cat_RadioButton
            // 
            this.Cat_RadioButton.AutoSize = true;
            this.Cat_RadioButton.Location = new System.Drawing.Point(46, 51);
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
            this.Bird_RadioButton.Location = new System.Drawing.Point(139, 51);
            this.Bird_RadioButton.Name = "Bird_RadioButton";
            this.Bird_RadioButton.Size = new System.Drawing.Size(59, 19);
            this.Bird_RadioButton.TabIndex = 1;
            this.Bird_RadioButton.TabStop = true;
            this.Bird_RadioButton.Text = "Птица";
            this.Bird_RadioButton.UseVisualStyleBackColor = true;
            this.Bird_RadioButton.CheckedChanged += new System.EventHandler(this.Bird_RadioButton_CheckedChanged);
            // 
            // CatsDeserialize_FileDialog
            // 
            this.CatsDeserialize_FileDialog.FileName = "open";
            this.CatsDeserialize_FileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.CatsDeserialize_FileDialog_FileOk);
            // 
            // Deserialize_Button
            // 
            this.Deserialize_Button.BackColor = System.Drawing.Color.Yellow;
            this.Deserialize_Button.Location = new System.Drawing.Point(46, 106);
            this.Deserialize_Button.Name = "Deserialize_Button";
            this.Deserialize_Button.Size = new System.Drawing.Size(152, 69);
            this.Deserialize_Button.TabIndex = 2;
            this.Deserialize_Button.Text = "Десериализация";
            this.Deserialize_Button.UseVisualStyleBackColor = false;
            this.Deserialize_Button.Click += new System.EventHandler(this.Deserialize_Button_Click);
            // 
            // Birds_Deserialize_FileDialog
            // 
            this.Birds_Deserialize_FileDialog.FileName = "openFileDialog1";
            this.Birds_Deserialize_FileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.Birds_Deserialize_FileDialog_FileOk);
            // 
            // Deserialize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 229);
            this.Controls.Add(this.Deserialize_Button);
            this.Controls.Add(this.Bird_RadioButton);
            this.Controls.Add(this.Cat_RadioButton);
            this.Name = "Deserialize";
            this.Text = "Deserialize";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton Cat_RadioButton;
        private RadioButton Bird_RadioButton;
        private OpenFileDialog CatsDeserialize_FileDialog;
        private Button Deserialize_Button;
        private OpenFileDialog Birds_Deserialize_FileDialog;
    }
}