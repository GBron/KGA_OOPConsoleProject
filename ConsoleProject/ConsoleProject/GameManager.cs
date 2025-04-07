using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleProject.Scenes;
using ConsoleProject.status;

namespace ConsoleProject
{
    public static class GameManager
    {
        // 게임 관리 클래스

        private static bool gameOver = false;

        private static Dictionary<string, Scene> sceneDict;
        private static Scene curScene;

        public static Player player = new Player();
        private static PlayerStatus playerStatus = new PlayerStatus();


        public static void Start()
        {
            // 게임 시작 작업
            sceneDict = new Dictionary<string, Scene>();

            // 씬 등록
            sceneDict.Add("Title", new Titlescene());
            sceneDict.Add("Explan", new ExplanScene());
            sceneDict.Add("Town", new Townscene());
            sceneDict.Add("Shop", new Shopscene());
            sceneDict.Add("Inn", new Innscene());
            sceneDict.Add("BulletinBoard", new Bulletinboardscene());

            // 현재 씬 설정
            curScene = sceneDict["Title"];

            // 플레이어 기본 설정
            player.Level = 1;
            player.MaxExp = 100;
            player.MaxHp = 100;
            player.Hp = player.MaxHp;
            player.Damage = 10;
            player.Defense = 5;
            player.Gold = 1000;
            player.STR = 5;
            player.DEX = 5;
        }


        public static void Run()
        {
            Start();
            while(!gameOver)
            {
                Console.Clear();
                if(curScene != sceneDict["Title"] && curScene != sceneDict["Explan"])
                    playerStatus.ShowStatus();
                curScene.MainScene();
                curScene.Select();
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

        public static void End()
        {
            
        }

        public static void Exit()
        {
            gameOver = true;
        }
    }
}
