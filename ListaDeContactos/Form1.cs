namespace ListaDeContactos
{
    public partial class Form1 : Form
    {
        private List<Contact> contacts = new List<Contact>();

        public static string setName = "";
        public static string setAddress = "";
        public static string setNumber = "";
        

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddContact formAddContact = new FormAddContact();

            if (formAddContact.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void listContacts()
        {
            listBoxContacts.Items.Clear();
            foreach (var contact in contacts)
            {
                listBoxContacts.Items.Add(contact.DisplayContact());
            }
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            int contactIndex = listBoxContacts.SelectedIndex;
            if (contactIndex >= 0)
            {
                contacts.RemoveAt(contactIndex);
                listContacts();
            }
        }

        private void buttonAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                listBoxContacts.Text = File.ReadAllText(fileName);
            }
        }

        private void listBoxContacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            int contactIndex = listBoxContacts.SelectedIndex;
            if (contactIndex >= 0)
            {
                setName = contacts[contactIndex].Name;
                setAddress = contacts[contactIndex].Address;
                setNumber = contacts[contactIndex].Phone;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(
                "Deseja mesmo sair?",
                "Alert!",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog.FileName;

                File.WriteAllText(filename, listBoxContacts.Text);
            }
        }

        private void InserirNovoContacto_Click(object sender, EventArgs e)
        {
            
            FormAddContact formAddContact = new FormAddContact();
            formAddContact.ShowDialog();
            Contact c = new Contact(setName, setAddress, setNumber);
            contacts.Add(c);
            setName = "";
            setAddress = "";
            setNumber = "";
            listContacts();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            this.Hide();
            int contactIndex = listBoxContacts.SelectedIndex;
            if (contactIndex >= 0)
            {
                FormEditContact formEditContact = new FormEditContact(contacts[contactIndex].Name, contacts[contactIndex].Address, contacts[contactIndex].Phone);
                formEditContact.ShowDialog();
                contacts[contactIndex].Name = setName;
                contacts[contactIndex].Address = setAddress;
                contacts[contactIndex].Phone = setNumber;
                setName = "";
                setAddress = "";
                setNumber = "";
                listContacts();
            }
            this.Show();
        }
    }
}