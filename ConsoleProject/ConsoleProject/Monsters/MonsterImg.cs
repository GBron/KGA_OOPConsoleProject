namespace ConsoleProject.Monsters
{
    public class MonsterImg
    {
        public void PrintMonsterImg(string name)
        {
            switch (GameManager.curMonster.Name)
            {
                case "오크":
                    Util.PrintLine("");
                    Util.PrintLine("        .--\"\"--.");
                    Util.PrintLine("       / \\    / \\");
                    Util.PrintLine("      |   (oo)   |");
                    Util.PrintLine("       \\   \\/   /");
                    Util.PrintLine("       / T----T \\ ");
                    Util.PrintLine("       \\________/ ");
                    Util.PrintLine("     ／          ＼ ");
                    Util.PrintLine("    /              \\");
                    break;
                case "코볼트":
                    Util.PrintLine("");
                    Util.PrintLine("");
                    Util.PrintLine("");
                    Util.PrintLine("");
                    Util.PrintLine("          /\\__/\\");
                    Util.PrintLine("         ( \\  / )");
                    Util.PrintLine("          \\_oo_/");
                    Util.PrintLine("        ／      ＼ ");
                    Util.PrintLine("       /          \\");
                    break;
                case "고블린":
                    Util.PrintLine("");
                    Util.PrintLine("");
                    Util.PrintLine("");
                    Util.PrintLine("");
                    Util.PrintLine("        ＿_____＿");
                    Util.PrintLine("       ＼( o o )／");
                    Util.PrintLine("          \\_v_/");
                    Util.PrintLine("        ／     ＼ ");
                    Util.PrintLine("       /         \\");
                    break;
                case "슬라임":
                    Util.PrintLine("");
                    Util.PrintLine("");
                    Util.PrintLine("            ／\\");
                    Util.PrintLine("         ／    ＼");
                    Util.PrintLine("      ／         \\");
                    Util.PrintLine("     /   ○    ○   \\ ");
                    Util.PrintLine("     \\            /");
                    Util.PrintLine("      ＼        ／");
                    Util.PrintLine("        ￣￣￣￣");
                    break;


            }
        }

    }
}
