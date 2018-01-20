using System;

namespace Things.Favorites
{
    class Candy
    {
        protected string _name;
        protected string _type;
        protected bool _isDelicious;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }

        public bool IsDelicious
        {
            get
            {
                return _isDelicious;
            }
            set
            {
                if (value)
                {
                    _isDelicious = true;
                }
                if (!value)
                {
                    _isDelicious = false;
                }
            }
        }

        public string Enjoying(bool IsDelicious) {
            {
                if (IsDelicious)
                {
                    return $"{_name} is a very delicious type of candy because it is {_type}. Yum.";
                }
                    return $"{_name} is not a great candy because it is {_type}.";
            }
       }
    }
}



