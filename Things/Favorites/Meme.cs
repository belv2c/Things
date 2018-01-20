using System;


namespace Things.Favorites
{
    class Meme
    {
        protected string _type;
        protected bool _isDead;
        protected string _origin;

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

        public bool IsDead
        {
            get
            {
                return _isDead;
            }
            set
            {
                if (value)
                {
                    _isDead = true;
                }
                if (!value)
                {
                    _isDead = false;
                }
            }
        }

        public string Origin
        {
            get
            {
                return _origin;
            }
            set
            {
                _origin = value;
            }
        }

        public string MemeCulture (bool IsDead)
        {
            if (IsDead)
            {
                return $"{Type} originated on {Origin} and is no longer relevant to the culture of memes.";
            }
                return $"{Type} originated on {Origin} and is still relevant to the culture of memes.";
        }
    }
}

