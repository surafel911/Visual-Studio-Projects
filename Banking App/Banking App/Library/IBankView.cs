using System;

namespace Library
{
    public class ButtonClickedEventArgs : EventArgs
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SocialSecurity { get; set; }

        public ButtonClickedEventArgs() : base()
        { }
    }

    public interface IBankView
    {
        event EventHandler<ButtonClickedEventArgs> ButtonClicked;
        event EventHandler FirstNameChanged;
        event EventHandler LastNameChanged;
        event EventHandler SocialSecurityChanged;

        string FirstName { get; set; }
        string MiddleInitial { get; set; }
        string LastName { get; set; }
        string SocialSecurity { get; set; }
        string PhoneNumber { get; set; }
        string EmailAddress { get; set; }

        void PresentName(string name);
    }
}
