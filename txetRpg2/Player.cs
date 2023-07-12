using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace txetRpg2
{
    public enum PlayerType //1. 열거하고
    {
        None = 0,
        Knight = 1,
        Archer = 2,
        Mage = 3
    }
    internal class Player : Creature//2.정보 기입하고
    {
        protected PlayerType type = PlayerType.None;

        protected Player(PlayerType type) : base(CreatureType.Player)
        {
            this.type = type;
        }
        public PlayerType GetPlayerType()
        {
            return type;
        }
    }

    class Knight : Player//3.클래스 만들고
    {
        public Knight() : base(PlayerType.Knight)//4.생성자 만들어줌
        {
            SetInfo(100, 10);
        }
    }
    class Archer : Player
    {
        public Archer() : base(PlayerType.Archer)
        {
            SetInfo(75, 12);
        }
    }
    class Mage : Player
    {
        public Mage() : base(PlayerType.Mage)
        {
            SetInfo(50, 15);
        }
    }
}
