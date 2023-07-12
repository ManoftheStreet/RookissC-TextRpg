using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace txetRpg2
{
    public enum GameMode
    {
        None,
        Lobby,
        Town,
        Field
    }
    
    
    class Game
    {
        private GameMode mode = GameMode.Lobby;
        private Player player = null;

        public void Process()
        {
            switch (mode)
            {
                case GameMode.Lobby:
                    ProcessLobby();
                    break;
                case GameMode.Town:
                    ProcessTown();
                    break;
                case GameMode.Field:
                    ProcessField();
                    break;
            }
        }

        private void ProcessLobby()
        {
            Console.WriteLine("직업을 선택하세요.");
            Console.WriteLine("1. 기사");
            Console.WriteLine("2. 궁수");
            Console.WriteLine("3. 법사");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    player = new Knight();
                    Console.WriteLine("기사를 선택했습니다.");
                    mode = GameMode.Town;
                    break;
                case "2":
                    player = new Archer();
                    Console.WriteLine("궁수를 선택했습니다.");
                    mode = GameMode.Town;
                    break;
                case "3":
                    player = new Mage();
                    Console.WriteLine("법사를 선택했습니다.");
                    mode = GameMode.Town;
                    break;
            }
        }
        private void ProcessTown()
        {
            Console.WriteLine("마을에 입장했습니다!");
            Console.WriteLine("1. 필드로 가기");
            Console.WriteLine("2. 로비로 돌아가기");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    mode = GameMode.Field;
                    break;
                case "2":
                    mode = GameMode.Lobby;
                    break;
            }
        }
        private void ProcessField()
        {

        }
    }
}
