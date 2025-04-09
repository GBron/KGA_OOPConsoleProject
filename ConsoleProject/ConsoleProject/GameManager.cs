using ConsoleProject.Battle;
using ConsoleProject.Monsters;
using ConsoleProject.Scenes;
using ConsoleProject.status;

namespace ConsoleProject
{
    public static class GameManager
    {
        // 게임 관리 클래스

        private static bool gameOver = false;

        public static Random rand = new Random();

        public static int towerFloor { get; set; }

        // 씬을 담는 딕셔너리
        private static Dictionary<string, Scene> sceneDict;
        private static Scene curScene;

        // 플레이어 관련
        public static Player player = new Player();
        private static PlayerStatus playerStatus = new PlayerStatus();
        public static Inventory inventory = new Inventory();

        // 몬스터 관련
        private static MonsterFactory monsterFactory = new Monsters.MonsterFactory();
        public static Monster curMonster;

        // 보스 관련
        private static BossFactory bossFactory = new BossFactory();
        public static Monster curBoss;

        // 적 상태와 전투
        public static EnemyStatus enemyStatus { get; set; } = new EnemyStatus();

        public static MonsterBattle monsterBattle = new MonsterBattle();

        public static BossStatus bossStatus = new BossStatus();

        public static BossBattle bossBattle = new BossBattle();


        public static void Start()
        {
            // 게임 시작 작업
            sceneDict = new Dictionary<string, Scene>();

            // 씬 등록
            sceneDict.Add("Title", new TitleScene());
            sceneDict.Add("Explan", new IntroScene());
            sceneDict.Add("Town", new TownScene());
            sceneDict.Add("Shop", new Shopscene());
            sceneDict.Add("Inn", new InnScene());
            sceneDict.Add("BulletinBoard", new BulletinboardScene());
            sceneDict.Add("Field", new FieldScene());
            sceneDict.Add("Dungeon", new DungeonScene());
            sceneDict.Add("Tower", new TowerScene());
            sceneDict.Add("Battle", new BattleScene());
            sceneDict.Add("BossBattle", new BossBattleScene());
            sceneDict.Add("Tower2", new Tower2Scene());
            sceneDict.Add("Dead", new DeadScene());
            sceneDict.Add("Ending", new GameEndScene());

            // 현재 씬 설정
            curScene = sceneDict["Title"];

            // 플레이어 기본 설정
            player.Level = 1;
            player.MaxExp = 100;
            player.MaxHp = 100;
            player.Hp = player.MaxHp;
            player.Damage = 10000;
            player.Defense = 5;
            player.Gold = 10000;
            player.STR = 5;
            player.DEX = 5;
        }


        public static void Run()
        {
            Start();
            while (!gameOver)
            {
                Console.Clear();
                if (curScene != sceneDict["Title"] && curScene != sceneDict["Explan"])
                    playerStatus.ShowStatus();
                curScene.MainScene();
                Console.WriteLine();
                curScene.Select();
                Console.WriteLine();
                curScene.Input();
                curScene.Reaction();
                curScene.Wait();
                curScene.Result();
            }
            End();
        }

        public static void ChangeScene(string sceneName)
        {
            curScene = sceneDict[sceneName];
        }

        public static void ChangeMonster(MonsterList monsterName)
        {
            curMonster = monsterFactory.Create(monsterName);
        }

        public static void ChangeBoss(BossList monsterName)
        {
            curBoss = bossFactory.Create(monsterName);
        }

        public static void End()
        {
            if (GameManager.towerFloor > 7)
            {
                Console.Clear();
                curScene.MainScene();
                curScene.Select();
                curScene.Input();
            }
        }

        public static void Exit()
        {
            gameOver = true;
        }
    }
}
