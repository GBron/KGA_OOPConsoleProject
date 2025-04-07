using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleProject.Scenes;

namespace ConsoleProject
{
    public static class GameManager
    {
        // 게임 관리 클래스

        private static bool gameOver = false;

        private static Dictionary<string, Scene> sceneDict;
        private static Scene curScene;

        public static Player player = new Player();


        public static void Start()
        {
            // 게임 시작 작업
            sceneDict = new Dictionary<string, Scene>();

            // 씬 등록
            sceneDict.Add("Title", new Titlescene());
            sceneDict.Add("Explan", new ExplanScene());

            // 현재 씬 설정
            curScene = sceneDict["Title"];
        }


        public static void Run()
        {
            Start();
            while(!gameOver)
            {
                Console.Clear();
                curScene.MainScene();
                curScene.Select();
                curScene.Input();
                curScene.Reaction();
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
