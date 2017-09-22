using System;
using Library;

namespace Model
{
    public class BankModel : IBankModel
    {
        private string _firstName;
        private string _middleInitial;
        private string _lastName;
        private string _socialSecurity;
        private string _phoneNumber;
        private string _emailAddress;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string MiddleInitial
        {
            get { return _middleInitial; }
            set { _middleInitial = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string SocialSecurity
        {
            get { return _socialSecurity; }
            set { _socialSecurity = value; }
        }
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        public string EmailAddress
        {
            get { return _emailAddress; }
            set { _emailAddress = value; }
        }

        public string GetFirstName()
        {
            return _firstName;
        }
    }
}
