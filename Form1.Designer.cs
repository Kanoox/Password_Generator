namespace Gen_Password
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            checkboxspecial = new CheckBox();
            checkbox09 = new CheckBox();
            checkboxmaj = new CheckBox();
            checkboxminu = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            empty_button = new Button();
            label1 = new Label();
            list_password = new ListBox();
            lengthpasswd = new TextBox();
            label2 = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkboxspecial);
            groupBox1.Controls.Add(checkbox09);
            groupBox1.Controls.Add(checkboxmaj);
            groupBox1.Controls.Add(checkboxminu);
            groupBox1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(22, 219);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(324, 202);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Choix des caractères";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // checkboxspecial
            // 
            checkboxspecial.AutoSize = true;
            checkboxspecial.Font = new Font("Segoe UI", 11.25F);
            checkboxspecial.Location = new Point(22, 127);
            checkboxspecial.Name = "checkboxspecial";
            checkboxspecial.Size = new Size(158, 24);
            checkboxspecial.TabIndex = 3;
            checkboxspecial.Text = "Caractères spéciaux";
            checkboxspecial.UseVisualStyleBackColor = true;
            checkboxspecial.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // checkbox09
            // 
            checkbox09.AutoSize = true;
            checkbox09.Font = new Font("Segoe UI", 11.25F);
            checkbox09.Location = new Point(22, 102);
            checkbox09.Name = "checkbox09";
            checkbox09.Size = new Size(124, 24);
            checkbox09.TabIndex = 2;
            checkbox09.Text = "Chiffres (0 à 9)";
            checkbox09.UseVisualStyleBackColor = true;
            checkbox09.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkboxmaj
            // 
            checkboxmaj.AutoSize = true;
            checkboxmaj.Font = new Font("Segoe UI", 11.25F);
            checkboxmaj.Location = new Point(22, 77);
            checkboxmaj.Name = "checkboxmaj";
            checkboxmaj.Size = new Size(148, 24);
            checkboxmaj.TabIndex = 1;
            checkboxmaj.Text = "Lettres Majuscules";
            checkboxmaj.UseVisualStyleBackColor = true;
            checkboxmaj.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkboxminu
            // 
            checkboxminu.AutoSize = true;
            checkboxminu.Font = new Font("Segoe UI", 11.25F);
            checkboxminu.Location = new Point(22, 52);
            checkboxminu.Name = "checkboxminu";
            checkboxminu.Size = new Size(148, 24);
            checkboxminu.TabIndex = 0;
            checkboxminu.Text = "Lettres minuscules";
            checkboxminu.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(405, 151);
            button1.Name = "button1";
            button1.Size = new Size(196, 62);
            button1.TabIndex = 1;
            button1.Text = "Générer un mot de passe";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(405, 219);
            button2.Name = "button2";
            button2.Size = new Size(196, 62);
            button2.TabIndex = 1;
            button2.Text = "Générer une liste de mots de passe";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // empty_button
            // 
            empty_button.Location = new Point(405, 349);
            empty_button.Name = "empty_button";
            empty_button.Size = new Size(196, 62);
            empty_button.TabIndex = 2;
            empty_button.Text = "Vider la liste";
            empty_button.UseVisualStyleBackColor = true;
            empty_button.Click += empty_button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(305, 9);
            label1.Name = "label1";
            label1.Size = new Size(364, 42);
            label1.TabIndex = 3;
            label1.Text = "Générateur de mot de passe";
            label1.Click += label1_Click;
            // 
            // list_password
            // 
            list_password.FormattingEnabled = true;
            list_password.ItemHeight = 15;
            list_password.Location = new Point(645, 109);
            list_password.Name = "list_password";
            list_password.Size = new Size(385, 379);
            list_password.TabIndex = 4;
            list_password.SelectedIndexChanged += list_password_SelectedIndexChanged;
            // 
            // lengthpasswd
            // 
            lengthpasswd.Location = new Point(22, 142);
            lengthpasswd.Name = "lengthpasswd";
            lengthpasswd.Size = new Size(324, 23);
            lengthpasswd.TabIndex = 5;
            lengthpasswd.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 109);
            label2.Name = "label2";
            label2.Size = new Size(148, 21);
            label2.TabIndex = 6;
            label2.Text = "Longueur souhaitée";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(645, 85);
            label3.Name = "label3";
            label3.Size = new Size(143, 21);
            label3.TabIndex = 7;
            label3.Text = "Vots mots de passe";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 498);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lengthpasswd);
            Controls.Add(list_password);
            Controls.Add(label1);
            Controls.Add(empty_button);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Générateur de Mot de passe";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private Button button2;
        private Button empty_button;
        private Label label1;
        private ListBox list_password;
        private CheckBox checkboxmaj;
        private CheckBox checkboxminu;
        private CheckBox checkbox09;
        private CheckBox checkboxspecial;
        private TextBox lengthpasswd;
        private Label label2;
        private Label label3;
    }
}
