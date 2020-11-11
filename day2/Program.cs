using System;

namespace day2
{
    class Program
    {
        //占位符。。。。
        static void Main1(string[] args)
        {

            string gunName = "AK47";
            string gunCapacity = "30";
            string gunCapacityResidue = "27";
            string remainingBullets = "120";
            string str =
                string.Format("枪的名字：{0},弹夹容量：{1} ,当前弹夹容量：{2},当前剩余子弹：{3}。",
                gunName, gunCapacity, gunCapacityResidue, remainingBullets);//关键
            //Console.WriteLine("枪的名字：" + gunName + " ,弹夹容量："
            //    + gunCapacity + " ,当前弹夹容量：" + gunCapacityResidue
            //    + " ,当前剩余子弹：" + remainingBullets + " 。");
            Console.WriteLine(str);

            //标准数字格式字符串-------------------------------------------------

            Console.WriteLine("{0:c}", 05);//5
            Console.WriteLine("{0:d2}", 05);//05,不足2位用0填充
            Console.WriteLine("{0:d2}", 15);//15
            Console.WriteLine("{0:d3}", 15);//015
            Console.WriteLine("{0:f2}", 1.567);//1.57
            Console.WriteLine("{0:f1}", 1.56);//1.6
            Console.WriteLine("{0:f0}", 1.56);//2
            Console.WriteLine("{0:p}", 0.1);//10.00%
            Console.WriteLine("{0:p0}", 0.1);//10%
            Console.WriteLine("{0:p1}", 0.1);//10.0%

            //转义-------------------------------

            //显示我爱"Unity"!     转义\" \' 改变字符原有含义
            Console.WriteLine("我爱\"Unity\"!");// "=\" 显示 我爱"Unity"!
            Console.WriteLine("\\");// 显示 \
            char c = '\'';// c= '
            char c2 = '\0';// c=空字符 ps:可有空字符串，但是不可以有空字符
            string c3 = "";//c3 = 空字符

            //回车换行 \r\n   \t 空格（水平制表格）tap键
            Console.WriteLine("我要飞，\r\n飞向\t天空之上。");//10.0%

            //.NET程序编译过程
            //源代码（.cs的文本文件）——>CLS编译(生成)——>CIL通用中间语言(exe dll)——>CLR编译——>0 1机器码
            //                        目的：跨语言                      目的：1.优化（各个版本系统）      
            //                                                              2.跨平台
            // 只要是机器，就只可以通过高低电压来区分 0和1，01机器码
            Console.ReadLine();

        }
        //运算符。。。。
        static void Main2(string[] args)
        {
            //1.算数运算符
            int n1 = 5, n2 = 2;
            float r1 = n1 / n2;// 5/2=2.5 ——> 截断删除r1=2.0 因为是int所以右边的值是int类型，然后赋值给r1
            float n3 = 5, n4 = 2;
            float r2 = n3 / n4;//r2=2.5
            int n5 = 29;
            float r3 = n5 % 10;//余数 r3=9

            string str = string.Format("{0:f0}", r1);

            //2.比较运算符 大于>  小于<  大于等于>=  小于等于<=  等于==  不等于!=  是否等于?=
            bool r4 = n1 == n2;

            //3.逻辑运算符 与&& 或|| 非!
            bool r5 = true && true;//真 与：有一假结果就是假 表达了：并且的关系。
            bool r6 = true || true;//真 或：有一真结果就是真 表达了：或者的关系。

            //if(如果玩家到了最左边，&&还想向左) || (如果玩家到了最右边，&&还想向右)
            //{停}
            //else {可以左右移动}
            //钱掉地上捡起来就行，代码错了改回来就行

            bool r7 = !true;


            //4.快捷运算符 += -= *=　/= %= (难点)
            int r8 = 1;
            r8 = r8 + 5;
            r8 += 5;

            //5.一元运算符：++ --      二元：加减乘除，等号右边有2种数字的     
            //根据操作数划分           三元：数据类型 变量名 =条件? 满足条件结果:不满足条件结果

            //
            //（1）无论 先加 还是 后加  对于 [下一条指令] ，都是 自增 以后的值
            int number01 = 1;
            number01++;
            Console.WriteLine(number01);//2   后加：先返回值（把值给与左边）——>自增
                                        //由于 number01++ 同等于 number01=number01+1
                                        //所以 number01 先把 1 给 左边，后自增 ——> 导致number01=2
            int number02 = 1;
            ++number02;
            Console.WriteLine(number02);//2   先加：自增——>再返回值（把值给与左边）

            int number03 = 1;
            Console.WriteLine(number03++);//1  
            // int a = number03++;
            // Console.WriteLine(a);

            int number04 = 1;
            Console.WriteLine(++number03);//2

            //三元：数据类型 变量名 = 条件? 满足条件结果:不满足条件结果
            string str01 = 1 > 2 ? "ok" : "no";//数据类型看结果 "ok"是字符，所以填 string
            double str02 = 1 == 1 ? 1.5 : 1.6f;//结果的数据类型必须相同

            //6.优先级
            int number05 = 1 + 2 * 5;//number05=11 先乘除后加减。
            int number06 = (1 + 2) * 5;//小括号优先级最高
        }
        //数据类型的转换
        static void Main3(string[] args)
        {
            //数据类型的转换
            //string "18" --> int 18

            //1.   string 转换为 其他 数据类型-->数据类型.Parse(变量)
            //注意：待转数据必须 “像” 转换的数据类型
            string strNunber = "18";
            int number01 = int.Parse(strNunber);
            float number02 = float.Parse(strNunber);
            
            //2.   任意类型转string ——> 变量.ToString()
            string strNunber01 = number02.ToString();

            //显式转换、隐式转换通常在数值之间
            //3.隐式转换：自动转换 
            byte b1 = 100;//byte：1字节。int：4字节。
            int b4 = b1; //自动转换    小变大可以，大变小不行。高精度不可以向低精度转换。

            //4.显式转换：强制转换
            int b2 = 300; //500>255 会发生数据丢失，前24位二进制代码丢失
            byte b5 = (byte)b2;//强制转换

            short a1 = 1;
            byte a2 = 3;
            byte a3 = (byte)(a1 + a2);//short byte相加等于int类型

            short a15 = 1;
            int a18 = 2;
            long a19 = 4;
            byte a16 = 3;
            byte b17 = (byte)(a16 + a15 + a18 + a19);//short byte相加等于int类型

            long a4 = 1;
            short a5 = 3;
            byte a6 = (byte)(a4 + a5);//long short相加等于long类型

            float a9 = 1;
            double a10 = 3;
            byte a11 = (byte)(a9 + a10);//float double相加等于double类型

            decimal a12 = 1;
            float a13 = 3;
            //byte a14 = (byte)(a12 + a13);//decimal double无法相加

            decimal a20 = 1;
            int a21 = 3;
            byte a22 = (byte)(a20 + a21);//decimal int相加等于decimal类型

            //总结： 整形+整形：都小于int，将变成int，有其一大于int，结果自动向较大数据类型提升
            //非整数形+非整数形：结果自动向较大数据类型提升，float和double 与decimal无法相加
            //整形+非整数形：变成非整数形 结果自动向较大数据类型提升

            byte b = 250;
            b += 6;//快捷运算符，不用做自动类型提升(快捷运算符，干的事少)！！！！！！！！！
            //b=b+3;报错：没强制转换类型
            Console.WriteLine(b);//规律 b等于250+6 -256=0
            float p = 10f;

            #region 作业
            //作业：让用户在控制台输入连续的4位数，我们计算4位数相加
            //例如：1234 ——> 1+2+3+4=10
            //方案1:从整数中获取每位数,方案2:从字符串中获取每个字符

            #region 方案2:从字符串中获取每个字符
            Console.WriteLine("请输入4位整数:");
            string strNunber09 = Console.ReadLine();
            int c0 = strNunber09[0];//c0=49???? 
            //2.从字符串中获取每个字符
            /*
            char c1 = strNunber09[0], c2 = strNunber09[1], 
            c3 = strNunber09[2], c4 = strNunber09[3];
            */

            //string n1 = c1.ToString(), n2 = c2.ToString(), n3 = c3.ToString(), n4 = c4.ToString();

            //int number04 = ;

            Console.WriteLine(
                int.Parse(strNunber09[0].ToString())
              + int.Parse(strNunber09[1].ToString())
              + int.Parse(strNunber09[2].ToString())
              + int.Parse(strNunber09[3].ToString())
              );
            #endregion

            #region 方案1.从整数中获取每位数

            int c1 = int.Parse(strNunber09);
            //1234
            Console.WriteLine(
             (c1 % 10)
            + (c1 % 100 / 10)
            + (c1 % 1000 / 100)
            + (c1 / 1000)
          );
            Console.WriteLine(
                 (c1 % 10)
                + (c1 / 10 % 10)
                + (c1 / 100 % 10)
                + (c1 / 1000)
              );
            #endregion

            #region 老师的写法
            int result = c1 % 10;//个位  
            result += c1 / 10 % 10;//十位
            result += c1 / 100 % 10;//百位
            result += c1 / 1000;//千位
            Console.WriteLine(result);
            #endregion

            #region 小时转换器
            string strNunber10 = Console.ReadLine();
            int c2 = int.Parse(strNunber10);
            //一分钟60秒 一小时3600 一天24*3600
            int timeDay = c2 / (24 * 3600);//天
            int timeHour = c2 % (24 * 3600) / 3600;//小时
            int timeMinute = c2 % 3600 / 60;//分钟
            int timeSecond = c2 % 60;//秒
                                     //(c2 - (c2/3600)) = c2 % 3600
            #endregion
            #endregion

        }
        //if条件判断 ：逐条判断，遇到符合条件的跳出
        static void Main4(string[] args)
        {
            string a = Console.ReadLine();
            if (a == "男")
            {
                Console.WriteLine("你好，先生");
            }
            else if (a == "女")
            {
                Console.WriteLine("你好，女士");
            }

            else
            {
                Console.WriteLine("性别未知");
            }

            //作业 
            Console.WriteLine("请输入第一个数字：");
            int a1 = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入第二个数字：");
            int a2 = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入运算符：");
            string a3 = Console.ReadLine();
            if (a3 == "+")//满足一个就跳走；(多路分支判断)
            {

                Console.WriteLine(a1 + a2);
            }
            else if (a3 == "-")
            {
                Console.WriteLine(a1 - a2);
            }
            else if (a3 == "*")
            {
                Console.WriteLine(a1 * a2);
            }
            else if (a3 == "/")
            {
                Console.WriteLine(a1 / a2);
            }
            else
            {
                Console.WriteLine("输入运算符未知");
            }
            //大括号里面只有一句话，大括号可以不写 如：  
            if (a3 == "+") Console.WriteLine(a1 + a2);
            else if (a3 == "-") Console.WriteLine(a1 - a2);
            else if (a3 == "*") Console.WriteLine(a1 * a2);
            else if (a3 == "/") Console.WriteLine(a1 / a2);
            else Console.WriteLine("输入运算符未知");


            int score = int.Parse(Console.ReadLine());//if 判断尽量优先判断错误的存在
            if (score > 100 || score < 10) Console.WriteLine("成绩有误");
            else if (100 >= score && score >= 90) Console.WriteLine("优秀");
            else if (89 >= score && score >= 80) Console.WriteLine("良好");
            else if (79 >= score && score >= 60) Console.WriteLine("及格");
            else Console.WriteLine("不及格");


        }
        //switch：直接判断符合条件的分支，不会逐条判断，break然后跳出，路径多 3 路以上的时候可以用
        //switch：只可用于bool、char、string、int、枚举、null空
        //执行效率会比if else 高一点，但是if else本身效率就很高了
        static void Main5(string[] args)
        {
            string op = Console.ReadLine();

            switch (op)
            {                                           //switch(表达式)  
                case "+":                               //{
                    Console.WriteLine("+");             //case 常数值1：
                    break;                              //
                case "-":                               //baeak;
                    Console.WriteLine("-");             //}
                    break;
                case "*":
                    Console.WriteLine("*");
                    break;
                case "/":
                    Console.WriteLine("/");
                    break;
                default:
                    Console.WriteLine("输入的符号不正确");
                    break;
            }
            int oc = int.Parse(Console.ReadLine());
            switch (oc / 10)//在case后面跟的是一个值型的数据，而不是逻辑型的数据，所以在daocase后面不能跟版>90这类型的数据
            {
                case 10:
                    Console.WriteLine("牛，满分");
                    break;
                case 9:
                    Console.WriteLine("太强了");
                    break;
                case 8:
                case 7:
                    Console.WriteLine("还行");
                    break;
                case 6:

                    Console.WriteLine("有点危险啊");
                    break;
                case 5:
                case 4:
                case 3:
                case 2:
                case 1:
                case 0:
                    Console.WriteLine("你挂科了，兄嘚");
                    break;
                default:
                    Console.WriteLine("你成绩有问题");
                    break;

            }
            Console.WriteLine("你的成绩是{0}", oc);

            //作业 月历
            int day = 0;
            int month = int.Parse(Console.ReadLine());
            if (month <= 12 && month >= 1)
            {
                switch (month)
                {

                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        day = 30;
                        break;
                    case 2:
                        day = 28;
                        break;
                    default:
                        day = 31;
                        break;
                }
                Console.WriteLine("{0}月有{1}天", month, day);
            }
            else
            {
                Console.WriteLine("无此月份");
            }

            Console.ReadLine();
        }
        //扣税作业
        static void Main(string[] args)
        {
            int tax;
            Console.WriteLine("请输入税前工资");
            int salary = int.Parse(Console.ReadLine());
            int salaryLater = salary - 4000;
            if (salaryLater > 80000) tax = (int)((salaryLater * 0.45) - 13505);
            else if (salaryLater > 55000) tax = (int)((salaryLater * 0.35) - 5505);
            else if (salaryLater > 35000) tax = (int)((salaryLater * 0.30) - 2755);
            else if (salaryLater > 9000) tax = (int)((salaryLater * 0.25) - 1055);
            else if (salaryLater > 4500) tax = (int)((salaryLater * 0.20) - 555);
            else if (salaryLater > 1500) tax = (int)((salaryLater * 0.15) - 105);
            else if (salaryLater > 0) tax = (int)(salaryLater * 0.03);
            else tax = 0;
            Console.WriteLine("您的税后工资为:"+ (salary - tax) + "您的所缴纳的税为:"+ tax);
            Console.ReadLine();
        }
    }
}
