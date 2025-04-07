using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.Scenes
{
    public abstract class Scene
    {
        // 상속시킬 씬 추상 클래스

        public ConsoleKey key { get; set; }

        // 씬의 메인 랜더링
        public abstract void MainScene();

        // 선택지 출력
        public abstract void Select();

        // 키 입력
        public void Input()
        {
            key = Console.ReadKey(true).Key;
        }

        // 선택지에 반응하는 장면
        public abstract void Reaction();

        // 씬의 결과
        public abstract void Result();
    }
}
