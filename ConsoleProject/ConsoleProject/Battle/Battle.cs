namespace ConsoleProject.Battle
{
    public abstract class Battle
    {
        protected int playerTempDefense = 0;
        protected bool isCritical = false;

        public abstract void PlayerAttack();


        public abstract void PlayerDefense();
        

        protected abstract void PlayerTotalDamage();


        public abstract void MonsterAttack();


        public abstract void MonsterSkill();


        protected abstract void MonsterTotalDamage();


        public abstract void BattleEnd();


        public void PlayerDead()
        {
            Util.PrintLine("당신은 눈 앞이 깜깜해집니다...", ConsoleColor.White, 1000);
            GameManager.ChangeScene("Dead");
        }

    }
}
