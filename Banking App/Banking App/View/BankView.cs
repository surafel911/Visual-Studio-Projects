using System;
using System.Windows.Forms;
using Library;

namespace View
{
    public partial class BankView : Form, IBankView
    {
        
        public event EventHandler<ButtonClickedEventArgs> ButtonClicked;
        public event EventHandler FirstNameChanged;
        public event EventHandler LastNameChanged;
        public event EventHandler SocialSecurityChanged;

        public string FirstName
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        public string LastName
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }

        public string SocialSecurity
        {
            get { return textBox3.Text; }
            set { textBox3.Text = value; }
        }

        private string crap = string.Empty;

        public string MiddleInitial
        {
            get { return crap; }
            set { crap = string.Empty; }
        }

        public string PhoneNumber
        {
            get { return crap; }
            set { crap = string.Empty; }
        }

        public string EmailAddress
        {
            get { return crap; }
            set { crap = string.Empty; }
        }

        public BankView()
        {
            InitializeComponent();
        }


        public void PresentName(string name)
        {
            MessageBox.Show(name);
        }

        private void button_Clicked(object sender, EventArgs e)
        {
            if (ButtonClicked != null)
            {
                ButtonClickedEventArgs args = new ButtonClickedEventArgs();
                args.FirstName = FirstName;
                args.LastName = LastName;
                args.SocialSecurity = SocialSecurity;

                ButtonClicked(sender, args);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (FirstNameChanged != null)
            {
                FirstNameChanged(sender, e);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (LastNameChanged != null)
            {
                LastNameChanged(sender, e);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (SocialSecurityChanged != null)
            {
                SocialSecurityChanged(sender, e);
            }
        }
    }
}
