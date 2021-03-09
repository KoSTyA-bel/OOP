namespace OOP.Model
{
    public class Student
    {
        public const int MAX_AGE = 130;
        public const int MIN_AGE = 0;
        public const int MAX_MARK = 10;
        public const int MIN_MARK = 0;

        private string _name;
        private int _age;
        private double _mark;

        public string Name { get => _name; set => _name = value; }

        public int Age
        {
            get => _age;
            set
            {
                if (value >= MIN_AGE && value <= MAX_AGE)
                {
                    _age = value;
                }
            }
        }
        public double Mark
        {
            get => _mark;
            set
            {
                if (value >= MIN_MARK && value <= MAX_MARK)
                {
                    _mark = value;
                }
            }
        }

        public Student(string name, int age, double mark)
        {
            Name = name;
            Age = age;
            Mark = mark;
        }

        public override string ToString()
        {
            return $"{Name}: age = {_age}, mark = {_mark}";
        }
    }
}
