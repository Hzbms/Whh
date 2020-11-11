using System;


namespace day3
{
    class Program
    {
        //短路逻辑
        static void Main1(string[] args)
        {
            //短路逻辑
            int n1 = 1, n2 = 2;
            bool re1 = n1 > n2 && n1++ > 1;
            Console.WriteLine(n1);//1    一假及假：左边优先判断为假，因一假及假，故不判断右边。如果判断了右边n1=2

            bool re2 = n2 > n1 || n2++ > 1;
            Console.WriteLine(n2);//2    一真及真：左边优先判断为真，因一真及真，故不判断右边。如果判断了右边n2=3

        }
        //for 循环
        static void Main2(string[] args)
        {
            //循环语句，跳转语句，方法

            /*  1(可以不用)  2  5    4 7(可以不用)
            for(初始化    ;     循环条件     ;     增减变量)
            // 1.循环计数器（预定次数循环） 2.刹车
            {   3  6
              循环体
            }
            */
            //作用域：起作用的范围
            //从声明开始 到 } 结束
            //i的作用域在static void Main(string[] args){}

            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine(1);

            }

            int a = 1;
            if (true)
            {
                //int a = 1;
            }
            if (true)
            {
                Console.WriteLine(a);//无法识别if里面的a
            }

            //作业 
            //一张纸的厚度为0.01毫米 1cm=10mm 1m=1000mm 
            //请对折30后的厚度为多少米
            double PaperMm = 0.01;
            for (int i = 0; i < 30; i++)
            {
                PaperMm *= 2;
            }
            Console.WriteLine("对折后纸的厚度为：" + (PaperMm / 1000) + "米");

            //1——100之间可以被3整除的数字累加
            int s = 0;
            for (int i = 1; i <= 100; i++)

            {
                if (i % 3 != 0) { continue; }//循环体内部遇到continue（继续下次循环）会跳到i++（增减变量）
                s += i;

            }
            Console.WriteLine(s);

        }
        //while 循环
        static void Main3(string[] args)
        {
            /*while(条件)
             {
             循环体
             }
             */

            int i = 0;
            while (i <= 5)
            {
                Console.WriteLine("嘻嘻");
                i++;
            }

            //练习：小球从100米高度落下。每次落地只有原本高度的一半（弹起高度小于0.01m时候结束）。弹多少次和弹起落下总距离
            int ballnumber = 0;
            double ballHeight = 100;
            double ballHeight2 = ballHeight;
            while (ballHeight / 2 >= 0.01f)
            {
                ballHeight2 += ballHeight;
                ballHeight /= 2;
                ballnumber++;
                Console.WriteLine("第{0}次,高度为{1}", ballnumber, ballHeight);
            }
            Console.WriteLine(ballHeight2);
            Console.WriteLine(ballnumber);
        }
        //do while
        static void Main4(string[] args)
        {
            /*
            do 
            {
             循环体
            }while(条件);
            先执行循环体再判断条件
             */
            int ballnumber = 0;
            double ballHeight = 100;
            double ballHeight2 = ballHeight;

            do
            {
                ballHeight2 += ballHeight;
                ballHeight /= 2;
                ballnumber++;
                Console.WriteLine("第{0}次,高度为{1}", ballnumber, ballHeight);
            } while (ballHeight / 2 >= 0.01f);
            Console.WriteLine(ballHeight2);
            Console.WriteLine(ballnumber);


            //猜数字
            //程序产生1-100随机数
            //让玩家重复猜测，显示大了，小了，猜对了，一共猜了几次
            Random random = new Random();//创建一个随机数工具   Random(随机数)
            int number = random.Next(101);
            int conjecture = 0;
            int time = 0;
            //int a = 1;
            while (true)
            {
                time++;
                Console.WriteLine("请输入一个数字:");
                conjecture = int.Parse(Console.ReadLine());
                if (number > conjecture)
                {

                    Console.WriteLine("小了");


                }
                else if (number < conjecture)
                {

                    Console.WriteLine("大了");


                }
                else if (number == conjecture)
                {

                    Console.WriteLine("猜对了" + "你猜了{0}次", time);
                    break;

                }
                else
                {
                    Console.WriteLine("输入有误");
                    break;
                }

            }
            for (; number != conjecture; time++)
            {
                Console.WriteLine("请输入一个数字:");
                conjecture = int.Parse(Console.ReadLine());
                if (number > conjecture)
                {

                    Console.WriteLine("小了");


                }
                else if (number < conjecture)
                {

                    Console.WriteLine("大了");


                }
                else if (number == conjecture)
                {

                    Console.WriteLine("猜对了" + "你猜了{0}次", time);


                }
                else
                {
                    Console.WriteLine("输入有误");

                }
            }
            Console.ReadLine();

            //由此说明break只能跳出一个循环，（如果是在内循环中 则结束内循环 如果是在外循环中 则内外都结束了.）
            //break是结束当前循环，
            //continue是结束本次循环，进行下次循环，
            //使用break就已经不再循环了
            //使用continue还要继续进行循环

            //如果想跳出所有循环，直接用return！


        }
        //方法 名称字母大写
        static void Main6(string[] args)
        {//方法定义：
         //[访问修饰符][可选修饰符]返回类型 方法名称(参数类型)  参数类型等于方法中功能需要的数据，需要使用者填入
         //{                                                 （有就一定要给！）
         //方法体
         //return 结果;
         //}
         //调用方法
         //方法名称(参数)

            Fun1();
            //方法:代表功能
            //返回值：功能的结果
            //返回值类型：int double float string
            //viod（空虚）：没有返回值
            int i = 100;
            Console.WriteLine(Fun2());
            Console.WriteLine(i);

            int c = 3;
            string d = "xixi";
            Fun3(c, d); //实际参数 
            string str1 = "我叫哈哈!";
            str1 = str1.Insert(c, "lolo");//插入str字符串的第3位。我前面是0。
            int f = str1.IndexOf("哈");//查找在字符串的位置（索引）
             //string n = 
            //str1 = str1.Remove(1, 5);  //删除 字符串1到5个索引，不写5就是1后面的所有字符都删除
            str1 = str1.Replace('哈','牛');//代替所有字符串中的哈为牛
            bool matching =str1.StartsWith("我叫");//查看字符串开头是否与输入的字符串相同
            bool matching2 = str1.Contains("!");//查看字符串中是否与输入的字符串相同字符
            Console.WriteLine(str1 + f+ matching+ matching2);

            Console.ReadLine();
        }
        private static void Fun1()
        {
            Console.WriteLine("Fun1执行了");
        }
        //如  private static string Fun1()  为错误
        private static int Fun2()//提示中出现"并非所有的代码路径都有返回值"-->方法体中缺少返回值。
        {
            int i = 1111;
            Console.WriteLine(i);
            Console.WriteLine("Fun2执行了");
            return 250;//返回 数据;退出方法

        }
        private static void Fun3(int a, string b)
        {//                       形式参数

            Console.WriteLine(a);
            Console.WriteLine(b);

        }
        //做方法，功能尽量小，如：做2个整数相加的方法。不要写输入输出，就写相加然后返回值就好了。尽量考虑复用性
        //构成复杂系统的是细胞，尽量一个方法就做一个事，
        static void Main(string[] args)
        {

            int a = Add(1,2);
        }
        private static int Add(int a, int b)
        {

            return a + b;

        }

    }
}
