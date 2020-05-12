namespace OOP_lab_4_17_1
{
    public class Student
    {
        private string _name;
        private string _lastName;
        private string _group;
        private int _year;
        private string _adress;
        private string _passport;
        private int _age;
        private string _telehone;
        private int _rating;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
        public string Group
        {
            get
            {
                return _group;
            }
            set
            {
                _group = value;
            }
        }
        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                _year = value;
            }
        }
        public string Adress
        {
            get
            {
                return _adress;
            }
            set
            {
                _adress = value;
            }
        }
        public string Passport
        {
            get
            {
                return _passport;
            }
            set
            {
                _passport = value;
            }
        }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }
        public string Telehone
        {
            get
            {
                return _telehone;
            }
            set
            {
                _telehone = value;
            }
        }
        public int Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                _rating = value;
            }
        }

        public Student()
        {
            Name = "Не вказано!";
            LastName = "Не вказано!";
            Group = "Не вказано!";
            Year = 0;
            Adress = "Не вказано!";
            Passport = "Не вказано!";
            Age = 0;
            Telehone = "Не вказано!";
            Rating = 0;
        }

        public static string StudentRating(int R)
        {
            if (R < 75)
            {
                return "Варто бiльше уваги придiляти навчанню";
            }
            if ((R >= 75 && R < 90))
            {
                return "Можна вчитися краще";

            }
            if (R >= 90)
            {
                return "Вiтаємо вiдмiнника";
            }

            return "Неук!";
        }
    }
}
