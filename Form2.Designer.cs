namespace Gen_Password
{
    partial class Form2
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
            number_list_password = new TextBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // number_list_password
            // 
            number_list_password.Location = new Point(83, 89);
            number_list_password.Name = "number_list_password";
            number_list_password.Size = new Size(215, 23);
            number_list_password.TabIndex = 0;
            number_list_password.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold);
            label1.Location = new Point(12, 40);
            label1.Name = "label1";
            label1.Size = new Size(375, 25);
            label1.TabIndex = 1;
            label1.Text = "Combien de mots de passez voulez-vous générer ?";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(146, 121);
            button1.Name = "button1";
            button1.Size = new Size(80, 32);
            button1.TabIndex = 2;
            button1.Text = "Valider";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 165);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(number_list_password);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button button1;
        private TextBox number_list_password;
    }
}