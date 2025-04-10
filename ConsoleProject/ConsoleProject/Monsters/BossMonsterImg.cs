using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.Monsters
{
    public class BossMonsterImg
    {
        public void PrintBossImg(string name)
        {
            switch (GameManager.curBoss.Name)
            {
                case "고블린 족장":
                    Util.PrintLine("");
                    Util.PrintLine("");
                    Util.PrintLine("");
                    Util.PrintLine("");
                    Util.PrintLine("                    ＿_____＿    ___ ");
                    Util.PrintLine("                   ＼( o o )／  |   |");
                    Util.PrintLine("                      \\_v_/     |   |   ");
                    Util.PrintLine("                    ／     ＼    \\ /   ");
                    Util.PrintLine("                   /         \\   | | ");
                    break;
                case "오크 전사":
                    Util.PrintLine("");
                    Util.PrintLine("                     .--\"\"--.                 ");
                    Util.PrintLine("                    / \\    / \\                ");
                    Util.PrintLine("                   |   (oo)   |      |＼     ");
                    Util.PrintLine("                    \\   \\/   /       |  \\ ");
                    Util.PrintLine("                    / T----T \\       |  |  ");
                    Util.PrintLine("                    \\________/       |  |  ");
                    Util.PrintLine("                  ／          ＼     |  |   ");
                    Util.PrintLine("                 /              \\    |  |  ");
                    break;
                case "오크 족장":
                    Util.PrintLine("");
                    Util.PrintLine("                     .--\"\"--.                ");
                    Util.PrintLine("                    / \\    / \\               ");
                    Util.PrintLine("                   |   (oo)   |      /\\     ");
                    Util.PrintLine("                    \\   \\/   /      /  \\  ");
                    Util.PrintLine("                    / T----T \\      \\  /   ");
                    Util.PrintLine("                ＿＿\\________/＿＿   ||     ");
                    Util.PrintLine("               ＼ ＿\\  \\__/  /＿ ／  ||    ");
                    Util.PrintLine("                 / \\          / \\    ||    ");
                    break;
                case "메탈 슬라임":
                    Util.PrintLine("");
                    Util.PrintLine("");
                    Util.PrintLine("                          ／\\");
                    Util.PrintLine("                       ／    ＼");
                    Util.PrintLine("                    ／         \\");
                    Util.PrintLine("                   /   ╋    ╋   \\ ");
                    Util.PrintLine("                   \\            /");
                    Util.PrintLine("                    ＼        ／");
                    Util.PrintLine("                      ￣￣￣￣");
                    break;
                case "트롤":
                    Util.PrintLine("                       .--\"\"--.      ");
                    Util.PrintLine("                      / \\    / \\     ");
                    Util.PrintLine("                     |   (__)   |      ");
                    Util.PrintLine("                      \\   \\/   /     ");
                    Util.PrintLine("                      /T------T\\      ");
                    Util.PrintLine("                ＿＿／\\________/＼＿＿     ");
                    Util.PrintLine("             ／   ／              ＼   ＼  ");
                    Util.PrintLine("            /    ｜                ｜    \\    ");
                    Util.PrintLine("           ｜     \\                /     ｜    ");
                    break;
                case "드래곤":
                    Util.PrintLine("        _＿                              ＿_          ");
                    Util.PrintLine("     ／    ＼                          ／    ＼       ");
                    Util.PrintLine("   ／／ \\ /＼＼      /\\______/\\      ／／\\ / ＼＼     ");
                    Util.PrintLine(" ／／   ｜   \\ \\    ( \\  ,,  / )    / /   ｜   ＼＼   ");
                    Util.PrintLine(" ／     /     \\ \\    \\   ,,   /    / /     \\     ＼   ");
                    Util.PrintLine("       ｜     ｜｜    \\  ,,  /    ｜｜     ｜         ");
                    Util.PrintLine("       /       \\ \\   ｜\\_oo_/｜   / /       \\         ");
                    Util.PrintLine("      /         \\ \\  ｜ V  V ｜  / /         \\        ");
                    Util.PrintLine("     /           ＼＼/        \\／／           \\       ");
                    break;
                case "마왕":
                    Util.PrintLine("                        /\\   /\\           ");
                    Util.PrintLine("                       _\\ \\_/ /_          ");
                    Util.PrintLine("                      < \\_ V _/ >         ");
                    Util.PrintLine("                       \\|-   -|/          ");
                    Util.PrintLine("                     __(_  ^  _)__        ");
                    Util.PrintLine("                    / '\\|v\"\"\"v|/' \\       ");
                    Util.PrintLine("                    \\   \\_____/   /       ");
                    Util.PrintLine("                  ／ \\    )=(    / ＼     ");
                    Util.PrintLine("                 /    \\__/\\=/\\__/    \\    ");
                    break;

            }
        }
    }
}
