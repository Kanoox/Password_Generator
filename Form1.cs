namespace Gen_Password
{
    public partial class Form1 : Form
    {

        private static string alphabet_min = "abcdefghijklmnopqrstuvwxyz";
        private static string alphabet_maj = alphabet_min.ToUpper();
        private static string alphachiffre09 = "0123456789";
        private static string alphaspecial = "#_@-*$";
        public string Alphabet = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        public bool CheckLenghtPasswd(string PasswdLen)
        {
            // Convertir PasswdLen
            try
            {
                int passLen = int.Parse(PasswdLen);
                if (passLen > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Votre nombre doit être supérieur à 1", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool ConstruireAlphabet()
        {
            Alphabet = string.Empty;

            if (checkboxminu.Checked == true)
            {
                Alphabet += alphabet_min;
            }
            if (checkboxmaj.Checked == true)
            {
                Alphabet += alphabet_maj;
            }
            if (checkbox09.Checked == true)
            {
                Alphabet += alphachiffre09;
            }
            if (checkboxspecial.Checked == true)
            {
                Alphabet += alphaspecial;
            }

            if (Alphabet.Length == 0)
            {
                MessageBox.Show("Il faut cocher au moins une case", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            //Construction réussie
            return true;

        }

        public string GeneratorPasswd(int passwdlength)
        {
            Random random = new Random();
            char[] password = new char[passwdlength];

            for (int i = 0; i < password.Length; i++)
            {
                password[i] = Alphabet[random.Next(Alphabet.Length)];
            }

            return new string(password);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!CheckLenghtPasswd(lengthpasswd.Text))
            {
                MessageBox.Show("Vous avez rentrer un nombre faux ! (Il doit être supérieur à 1)", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (ConstruireAlphabet() != false)
            {
                ConstruireAlphabet();
                list_password.Items.Add(GeneratorPasswd(int.Parse(lengthpasswd.Text)));
            }
        }

        private void empty_button_Click(object sender, EventArgs e)
        {
            list_password.Items.Clear(); // Effacer les éléments de la liste
        }

        private void list_password_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clipboard.SetText(list_password.Text); // Copier le texte dans le presse papier
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(); // Ouverture du Formulaire 
            //form2.Show();

            DialogResult rep = form2.ShowDialog(); // Observer le résultat du dialog final
            int i = 0; // Déclaration de l'index i
            var nbPasswd = form2.NbPasswd; // Récupération de la TextBox du form2

            if (!CheckLenghtPasswd(lengthpasswd.Text))
            {
                MessageBox.Show("Vous avez rentrer un nombre faux ! (Il doit être supérieur à 1)", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (ConstruireAlphabet() != false)
            {
                ConstruireAlphabet();
                while (i < nbPasswd)
                {
                    list_password.Items.Add(GeneratorPasswd(int.Parse(lengthpasswd.Text)));
                    i++;
                }
            }
        }
    }
}
