using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.Scenes
{
    public class BossBattleScene : Scene
    {
        Monsters.BossMonsterImg MonsterImg = new Monsters.BossMonsterImg();

        public override void MainScene()
        {
            MonsterImg.PrintBossImg(GameManager.curBoss.Name);

            GameManager.bossStatus.ShowStatus();
        }
        public override void Select()
        {
            Util.PrintLine("1. 공격");
            Util.PrintLine("2. 방어");
            Util.PrintLine("3. 도주");
        }
        public override void Reaction()
        {
            switch (key)
            {
                case ConsoleKey.D1:
                    GameManager.bossBattle.PlayerAttack();
                    break;
                case ConsoleKey.D2:
                    GameManager.bossBattle.PlayerDefense();
                    break;
                case ConsoleKey.D3:
                    Util.PrintLine("도망칠 수 없습니다..!", ConsoleColor.White, 1500);
                    break;
            }
        }
        public override void Wait()
        {
        }

        public override void Result()
        {
            switch (key)
            {
                case ConsoleKey.D1:
                    if (GameManager.curBoss.Hp <= 0)
                    {
                        GameManager.bossBattle.BattleEnd();
                    }
                    else
                    {
                        GameManager.bossBattle.MonsterAttack();
                        if (GameManager.player.Hp <= 0)
                        {
                            GameManager.bossBattle.PlayerDead();
                        }
                    }
                    break;
                case ConsoleKey.D2:
                    GameManager.bossBattle.MonsterAttack();
                    if (GameManager.player.Hp <= 0)
                    {
                        GameManager.bossBattle.PlayerDead();
                    }
                    break;
                case ConsoleKey.D3:
                    break;
            }
        }
    }
}
