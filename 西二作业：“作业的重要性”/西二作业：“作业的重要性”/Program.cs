using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 西二作业__作业的重要性_
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice, Flag = 0, bagmedicine = 0;
            int time = 1, ci = 0;                                                                                       //记录局数，以发动怪兽技能
            Monsters a1 = new Monsters("凶残的小怪", 30, 0);                                                                //创建4只新的小怪
            Monsters B = new Monsters("加强版普通小怪", 50, 0);                                                            
            Monsters c = new Monsters("怪兽法师", 20, 10);
            Monsters a2 = new Monsters("凶残的小怪", 30, 0);
            Monsters Boss = new Monsters("高配版勇者", 120, 90);                                                             //创建一个Boss
            Console.WriteLine("欢迎来到游戏，请在下方输入您的身份信息：");
            Player I = new Player();
            Console.WriteLine("请输入你的游戏名：");
            I.playername = Console.ReadLine();                                  //输入玩家名
            I.level = 1;                                                        //玩家的初始等级，HP，MP，信息
            I.MP = 10;
            I.HP = 15;
            Console.WriteLine("游戏正在载入中");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("可怜的{0}，你是福州大学的一名计算机大一新生，",I.playername);
            Console.WriteLine("参加了西二在线的考核，");
            Console.WriteLine("可惜的是在即将DDL的时候，");
            Console.WriteLine("你还没备份的作业被一个蒙面黑衣人偷走了！！！！！");
            Console.WriteLine("气愤的你跟随着这个可恨的小偷来到了一个地宫门口（别问为什么学校有地宫，问就是量子）");
            Console.WriteLine("在地宫的门口写着这样一句话“陌生的勇者啊，你丢的是这个写完的作业呢？还是这个快写完的作业？或者是这个还没写完的作业？”");
            Console.WriteLine("1写完的   2差一点   3几乎一点没写");
            choice = Convert.ToInt32(Console.ReadLine());                         //选择
            if (choice == 1|| choice == 2)
            {
                if(choice == 1)
                {
                    Console.WriteLine("勤奋的勇者啊，奖励你两棵草药，并提升一级，请进。");//以后要加一个背包功能
                    bagmedicine+=2;
                }
                else
                {
                    Console.WriteLine("稍微勤奋的勇者啊，你很励志，上帝奖励你一棵草药，并提升一级，且你获得了进入地宫的机会。");
                    bagmedicine++;
                }
                Console.WriteLine("level up,增加新技能：群攻：伤害-6,消耗mp-6");
                I.level++;
                I.MP = 20;
                I.HP = 30;
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("第一关：");
                Console.WriteLine("在你面前的是一只小怪，只有打败他你才能获得进入下一关的权利，加油鸭勇者！(按任意键继续)");Console.ReadKey();
                                                          //创建一只新的普通小怪
                Console.WriteLine("你的战斗信息：");                                   //战斗前双方的战斗信息
                Console.WriteLine("name:"+I.playername);
                Console.WriteLine("level:"+I.level);
                Console.WriteLine("HP:"+I.HP);
                Console.WriteLine("MP:"+I.MP);
                Console.WriteLine("技能:  1普通攻击:hp-7,mp-1   2群攻：hp-2*n,mp-6");
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("对手的战斗信息：");
                Console.WriteLine("name:" + a1.monstorName);
                Console.WriteLine("HP:" + a1.HP);
                Console.WriteLine("MP:" + a1.MP);
                Console.WriteLine("技能:  普通攻击:hp-5");
                Console.WriteLine("-------------------------------------------(按任意键继续)"); Console.ReadKey();
                while (I.HP > 0 && a1.HP > 0)                                            //用while函数实现战斗回合制
                {
                    Console.WriteLine("请选择你的攻击方式：1普攻 2群攻");
                    choice = Convert.ToInt32(Console.ReadLine());                       //战斗方式选择
                    if (choice == 1&&I.MP>=1)
                    {
                        a1.HP -= 7;
                        I.MP -= 1;
                    }
                    else if(choice==2&&I.MP>=6)
                    {
                        a1.HP -= 2;
                        I.MP -= 5;
                    }
                    else if(choice!=1&&choice!=2||I.MP==0)
                    {
                        Console.WriteLine("（你选择错误，）or（你没蓝了，由于本游戏作者没有设置回蓝），所以你死了");//一个类似没啥用的功能
                        Flag = 1;
                        break;
                    }
                    I.HP -= 5;
                    Console.WriteLine("实时战斗情况：");
                    Console.WriteLine("name:" + I.playername+"  HP:"+I.HP+" MP:"+I.MP);
                    Console.WriteLine("name:" + a1.monstorName + "   HP:" + a1.HP);
                    Console.WriteLine("------------------------------------------");
                }
                if (I.HP == 0||Flag==1)
                {
                    Console.WriteLine("Game Over!");
                }
                 
                else if (a1.HP == 0)
                {
                    Console.WriteLine("Congratulations!通过了第一关的考验，奖励你提升2级（接下来的一关太过险峻，我只能帮你到这了）。但这只是一只小小的炮灰，勇者啊，后面还有更严峻的考验等着你，你确定要进入下一关吗？");
                    Console.WriteLine("1 Yes    2 Yes");
                    Console.WriteLine("你已经无路可退了呢，微笑.jpg");
                    choice = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("level up,增加新技能：溅射攻击---主要目标hp-9；左右对象hp-5；消耗mp-15；回复生命：hp+30,消耗mp-16");
                    I.level+=2;
                    I.MP = 80;
                    I.HP = 70;
                    Console.WriteLine("-----------------------------------------(按任意键继续)");Console.ReadKey();
                    Console.WriteLine("欢迎来到第二关");
                    Console.WriteLine("在这一关,你将面对三只怪物，他们有着不同的技能，请合理规划你的释放技能顺序，否则你可能会死哦");
                    
                    Console.WriteLine("游戏正在载入中。。。。。。。。（按任意键继续）");Console.ReadKey();
                    Console.WriteLine("你的战斗信息：");                                   //战斗前双方的战斗信息
                    Console.WriteLine("name:" + I.playername);
                    Console.WriteLine("level:" + I.level);
                    Console.WriteLine("HP:" + I.HP);
                    Console.WriteLine("MP:" + I.MP);
                    Console.WriteLine("技能:  1普通攻击:hp-7,mp-1   2群攻：hp-2*n,mp-6   3溅射攻击---主要目标hp-9；左右对象hp-5；mp-15    4回复生命：hp+30,消耗mp-12");
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine("对手的战斗信息（从左到右介绍顺序）：");
                    Console.WriteLine("name:" + a2.monstorName);
                    Console.WriteLine("HP:" + a2.HP);
                    Console.WriteLine("MP:" + a2.MP);
                    Console.WriteLine("技能:  普通攻击:hp-5");
                    Console.WriteLine("------------------");
                    Console.WriteLine("name:" + B.monstorName);
                    Console.WriteLine("HP:" + B.HP);
                    Console.WriteLine("MP:" + B.MP);
                    Console.WriteLine("技能:  普通攻击:hp-5   暂时性血友病：hp-15 +流血持续三局hp-1");
                    Console.WriteLine("------------------");
                    Console.WriteLine("name:" + c.monstorName);
                    Console.WriteLine("HP:" + c.HP);
                    Console.WriteLine("MP:" + c.MP);
                    Console.WriteLine("技能:  使对手推迟攻击一轮(随机发动)，mp-5");
                    Console.WriteLine("-----------------------------------------------------按任意键开始战斗");Console.ReadKey();
                                                                                                                               
                    Flag = 0;
                    while (I.HP > 0 && (a2.HP > 0 || B.HP > 0 || c.HP > 0))                                                                 //当玩家死亡或者怪兽三只都死亡，结束战斗
                    {
                        Console.WriteLine("请选择你的攻击方式：1普攻 2群攻 3溅射(只能对离主要攻击对象左右两只怪兽起到附加攻击) 4治疗(当背包里有草药时起作用)");
                        choice = Convert.ToInt32(Console.ReadLine());
                        if (choice == 1 && I.MP >= 1)
                        {
                            Console.WriteLine("请选择你的攻击对象(1.普通怪兽     2.进化型怪兽      3.怪兽法师)");
                            choice = Convert.ToInt32(Console.ReadLine());
                            if (choice == 1)
                                a2.HP -= 7;
                            else if (choice == 2)
                                B.HP -= 7;
                            else if (choice == 3)
                                c.HP -= 7;
                            I.MP -= 1;
                        }
                        else if (choice == 2 && I.MP >= 6)
                        {
                            a2.HP -= 2;
                            B.HP -= 2;
                            c.HP -= 2;
                            I.MP -= 5;
                        }
                        else if (choice == 3&&I.MP>=15)
                        {
                            Console.WriteLine("请选择你的攻击对象(1.普通怪兽     2.进化型怪兽      3.怪兽法师)");
                            choice = Convert.ToInt32(Console.ReadLine());
                            if (choice == 1)
                            {
                                a2.HP -= 9;
                                B.HP -= 5;
                            }
                            else if (choice == 2)
                            {
                                B.HP -= 9;
                                a2.HP -= 5;
                                c.HP -= 5;
                            }
                            else if (choice == 3)
                            {
                                c.HP -= 9;
                                B.HP -= 5;
                            }
                            I.MP -= 15;
                        }
                        else if (choice == 4&&I.MP>=12)
                        {
                            if (bagmedicine > 0)
                            {
                                I.MP -= 12;
                                I.HP += 30;
                                bagmedicine--;
                            }
                            else
                                Console.WriteLine("你的背包里没有草药哦");
                        }
                        I.HP -= 5;
                        if (time % 4 != 0&&B.HP!=0)
                            I.HP -= 5;
                        else if(time % 4 == 0 && B.HP != 0)
                        {
                            I.HP -= 15;
                            Flag = 1;

                        }
                        if (Flag == 1 && ci < 3)
                        {
                            ci++;
                            I.HP -= 1;
                        }
                        if (ci == 3)
                        {
                            ci = 0;
                            Flag = 0;
                        }
                        Console.WriteLine("'实时'战斗数据：");
                        Console.WriteLine("your situation:");
                        Console.WriteLine("HP:{0}       MP:{1}", I.HP, I.MP);
                        Console.WriteLine("---------------------------------------------");
                        Console.WriteLine("the enemy's situation:");
                        Console.WriteLine("小怪a：");
                        Console.WriteLine("HP:{0}", a2.HP);
                        Console.WriteLine("-------------");
                        Console.WriteLine("怪兽B：");
                        Console.WriteLine("HP:" + B.HP);
                        Console.WriteLine("-------------");
                        Console.WriteLine("怪兽c：");
                        Console.WriteLine("HP:{0}       MP{1}", c.HP, c.MP);
                        Console.WriteLine("--------------------------------------------------------------");
                        time++;
                    }
                    if (I.HP > 0)
                    {
                        Console.WriteLine("Congratulations!通过了第二关的考验，奖励你提升1级，并获得一颗草药");
                        Console.WriteLine("level up");
                        I.level++;
                        I.HP = 100;
                        I.MP = 120;
                        bagmedicine++;
                        Console.WriteLine("接下来就是最后的考验了，为了你的作业，要努力啊(按任意键继续)");Console.ReadKey();
                        Console.WriteLine("--------------------------------------------------------");
                        Console.WriteLine("欢迎来到最后一关");
                        
                        Console.WriteLine("进入第三关，你终于见到了这个蒙面黑衣人的脸---------竟然和你长得一模一样！！");
                        Console.WriteLine("黑衣人：哈哈哈哈哈哈哈哈，想知道为什么我长得跟你一模一样吗，除非你打败我，否则我不会告诉你的!");
                        Console.WriteLine("你：？？！");
                        Console.WriteLine("战斗就这样随便地开始了-------------------------（按任意键载入战斗信息）");Console.ReadKey();
                        Console.WriteLine("你的战斗信息：");                                   //战斗前双方的战斗信息
                        Console.WriteLine("name:" + I.playername);
                        Console.WriteLine("level:" + I.level);
                        Console.WriteLine("HP:" + I.HP);
                        Console.WriteLine("MP:" + I.MP);
                        Console.WriteLine("技能:  1普通攻击:hp-7,mp-1   2群攻：hp-2*n,mp-6   3溅射攻击---主要目标hp-9；左右对象hp-5；mp-15    4回复生命：hp+30,消耗mp-12      5大招hp-30,mp-20");
                        Console.WriteLine("---------------------------");
                        Console.WriteLine("对手的战斗信息");
                        Console.WriteLine("name:" + Boss.monstorName);
                        Console.WriteLine("HP:" + Boss.HP);
                        Console.WriteLine("MP:" + Boss.MP);
                        Console.WriteLine("技能:  1普通攻击:hp-15,mp-10   2大招hp-25,mp-20");
                        Console.WriteLine("-----------------------------------------------------按任意键开始战斗"); Console.ReadKey();
                        time = 1;
                        while (I.HP != 0 && Boss.HP != 0)
                        {
                            Console.WriteLine("请选择你的攻击方式：1普攻 2群攻 3溅射(只能对离主要攻击对象左右两只怪兽起到附加攻击) 4治疗(当背包里有草药时起作用)   5大招");
                            choice = Convert.ToInt32(Console.ReadLine());
                            if (choice == 1&&I.MP>=1)
                            {
                                Boss.HP -= 7;
                                I.MP -= 1;
                            }
                            else if (choice == 2&&I.MP>=6)
                            {
                                Boss.HP -= 2;
                                I.MP -= 6;
                            }
                            else if (choice == 3&&I.MP>=15)
                            {
                                Boss.HP -= 9;
                                I.MP -= 15;
                            }
                            else if (choice == 4&&I.MP>=12)
                            {
                                if (bagmedicine > 0)
                                {
                                    I.MP -= 12;
                                    I.HP += 30;
                                    bagmedicine--;
                                }
                                else
                                    Console.WriteLine("你的背包里没有草药哦");
                            }
                            else if (choice == 5)
                            {
                                Boss.HP -= 30;
                                I.MP -= 30;
                            }
                            if (time % 2 == 1&&Boss.MP>=10)
                            {
                                I.HP -= 15;
                                Boss.MP -= 10;
                            }
                            else if(time%2==0&&Boss.MP>=20)
                            {
                                I.HP -= 30;
                                Boss.MP -= 20;
                            }
                            Console.WriteLine("'实时'战斗数据：");
                            Console.WriteLine("your situation:");
                            Console.WriteLine("HP:{0}       MP:{1}", I.HP, I.MP);
                            Console.WriteLine("---------------------------------------------");
                            Console.WriteLine("the enemy's situation:");
                            Console.WriteLine("Boss：");
                            Console.WriteLine("HP:{0}       MP:{1}", Boss.HP, Boss.MP);
                            Console.WriteLine("--------------------------------------------------------------");
                            time++;
                        }
                        if (Boss.HP == 0)
                        {
                            Console.WriteLine("黑衣人：噗--------，怎么可能，你，你竟然打败了我，不可能啊-----------");
                            Console.WriteLine("你现在想知道黑衣人的身份吗：1想     2不想");
                            choice = Convert.ToInt32(Console.ReadLine());
                            if (choice == 1)
                            {
                                Console.WriteLine("你：你刚才说只要我打赢了你，你就告诉我你是谁，行了，别吐番茄酱了，快点讲完还我作业，我还要回去补作业！！！！");
                                Console.WriteLine("黑衣人：哦，其实我是另一条时间线上的你");
                                Console.WriteLine("你：!!?震惊.jpg");
                                Console.WriteLine("黑衣人：在另一条时间线上，我并没有按时完成西二的作业，被踢出了考核，我太伤心了，在我的“虔诚”祈祷下，上帝听到了我的呼唤，于是就在上帝（问就是量子）的帮助下，获得了一次穿越时空的机会，穿越到DDL之前，找到你，并让你也体会一把没交作业，被踢出考核的难过。");
                                Console.WriteLine("你：哇哦，好成熟的想法哦。好了，讲完故事就把我的作业还给我吧");
                                Console.WriteLine("黑衣人乖乖交出了作业，你转身你离开了地宫，但却没有发现，在你的背后，黑衣人的身边突然出现了一道虚影，感受到虚影存在的黑衣人向着你离开的方向无声地笑了");
                                Console.WriteLine("恭喜你成功拿到了作业，通过了考验！");
                            }
                            else
                            {
                                Console.WriteLine("恭喜你成功从装死的黑衣人身上拿到了作业，通过了考验！");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Game over!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Game Over!");
                    }
                }

            }
            else if(choice == 3)
            {
                Console.WriteLine("厚脸皮的勇者啊，勇气可嘉，作业还有一大半没写完，还有时间出来追你完成度少得可怜的作业，回宿舍重写吧。");
                Console.WriteLine("Game Over!");
            }
            Console.ReadKey();
        }
    }
}
