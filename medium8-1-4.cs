class Wapon
    {
        public float Damage { get; private set; }
        public float Cooldown { get; private set; }

        public bool IsReloading()
        {
            throw new NotImplementedException();
        }

    }
    struct Direction
    {
        public float X;
        public float Y;
    }
    class Movement
    {
        public float Speed { get; private set; }
        public Direction Direction { get; private set; }

        public void Move()
        {
            //Do move
        }
    }
    class Player
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        private Wapon _wapon;
        private Movement _movement;
        
        public void Attack()
        {
            //attack
        }
    }