namespace encapsulation
{
    public class Person
    {
        private string _firstName;
        private string _lastName;

        public string SetFirstName(string firstName)
        {
            _firstName = firstName;
            return _firstName;
        }
        public string GetFirstName()
        {
            return _firstName;
        }
    }
}