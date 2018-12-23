namespace RozetkaTestAutomationFrameworkUsage.Helpers
{
    public class User
    {
        private readonly string _name;
        private readonly string _numberphone;
        private readonly string _email;

        public User()
        {
            _name = "Богдан";
            _numberphone = "0951614612";
            _email = "kartofka@ukr.net";
        }

        public User(string name, string numberphone, string email)
        {
            _name = name;
            _numberphone = numberphone;
            _email = email;
        }

        public string Getname()
        {
            return _name;
        }

        public string Getphone()
        {
            return _numberphone;
        }

        public string Getemail()
        {
            return _email;
        }
    }
}