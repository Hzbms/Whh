using System;

namespace day4
{
    class Program
    {
        static void Main1(string[] args)
        {
            int i = 0;
            while (i < 5)
            {

                Console.WriteLine("1");
                i++;
                if (i == 4)
                {
                    continue;
                }
            }

            //continue:跳过本次,继续下次
            //break:打断退出本次循环
            //return:1.返回数据 2.退出方法

            /*
            返回值：方法体的结果
            方法的数据类型为void的时候，可以写return，但是不可以写数据
            数据可以放着，没有调用者就一直放着。
            方法名称首字母大写
            参数:方法体被调用需要的参数
             */
            string ss = "ss";
            ss.Replace(ss, "aa");
            Console.WriteLine(ss);

            int x = 1, x2 = 1;
            for (int s = 1; s <= 5; s++)
            {

                x *= s;

                Console.WriteLine(x);
            }

            Console.WriteLine(GetFactrial2(5));
            Console.WriteLine(GetFactrial8(8));
            Console.ReadLine();
        }
        //方法重载
        //定义：方法名称相同，参数列表不同,
        //作用：在不同条件下，解决同一个问题，让调用者仅仅记忆一个方法。
        /// <summary>
        /// 分钟，计算秒数
        /// </summary>
        /// <param name="minute">分钟</param>
        /// <returns>秒数</returns>
        private static int GetTotalSecond(int minute)
        {

            return minute * 60;
        }
        /// <summary>
        /// 分钟，小时,计算秒数
        /// </summary>
        /// <param name="minute">分钟，小时</param>
        /// <returns>秒数</returns>
        private static int GetTotalSecond(int minute, int hour)
        {

            return GetTotalSecond(minute + hour * 60);
        }
        /// <summary>
        /// 分钟，小时，天，计算秒数
        /// </summary>
        /// <param name="minute">分钟，小时，天</param>
        /// <returns>秒数</returns>
        private static int GetTotalSecond(int minute, int hour, int day)
        {

            return GetTotalSecond(minute, hour + day * 24);
        }
        //**********************************************************
        //递归()  数组

        private static int GetFactrial(int num, int i)//(1,1)
        {
            //方法内部有调用自己的过程
            //核心思想:将问题转移给范围缩小的子问题
            //缺点：可以不用就不用，性能较差
            //优势：将特别复杂的问题简化
            //适用性（什么时候用）：在解决问题的过程中，遇到了相同的问题，但是先冷下心来，看看有没有别的方法，可以不用就不用，真的不行再用
            //文件夹找文件夹，一直到没有文件为止，递归就很方便
            //面试经常用，千万要熟系
            //注意：堆栈溢出
            num *= i;
            if (i == 5) return num;
            return GetFactrial(num, i + 1);
        }
        //计算阶乘（请使用递归算法实现）5! ===>5*4*3*2*1
        private static int GetFactrial2(int num)//(1,1)
        {
            if (num == 1) return 100;//输出12000
            return num * GetFactrial2(num - 1);
        }

        //num * GetFactrial2(num - 1)
        //num * (num-1) * GetFactrial2(num - 2)
        //num * (num-1) *(num-2)* GetFactrial2(num - 3)
        //num * (num-1) *(num-2)* GetFactrial2(num - 3)的返回值
        //5*4*3*100

        //5*4*3*2
        private static int GetFactrial3(int num)
        {
            if (num == 2) return 3;
            return GetFactrial3(num) + GetFactrial3(num - 1);
        }
        //练习：编写一个函数，计算当参数为8的时候结果
        //1-2+3-4+5-6.....
        //-8+7-6+5-4+3-2+1 =-4
        private static int GetFactrial8(int num)
        {
            if (num == 0) return 0;
            //if (num % 2 == 1) return num - GetFactrial8(num - 1);
            //else return GetFactrial8(num - 1) - num;
            if (num % 2 == 0) return -num + GetFactrial8(num - 1);
            else return num + GetFactrial8(num - 1);
        }//-8+7-6+5-4+3-2+1 =-4

        //********************************************************************
        //数组：一组数据类型相同的变量组合。0开始,最后一个就是总数减1。
        //一种空间连续的数据结构。
        //位置不放值的时候就是数据类型的默认值，如：int就是0, bool就是false。所以每次放值就是把默认值改为放的数据
        //数据多了就异常了，比如内存开了5个位置，你写6个数据，就异常了，改回来就好


        static void Main2(string[] args)
        {
            int[] a;
            a = new int[6];
            a[0] = 1;
            a[1] = 2;
            a[5] = 6;
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);

            }
            Console.ReadLine();


            // int[] studentMark = CreateScoreArray();

            //所有数据类型都可以是数组
            //数组的其他写法
            //初始化+赋值
            float[] b01 = new float[6] { 1, 2, 3, 4, 5, 6 };
            var b02 = new float[6] { 1, 2, 3, 4, 5, 6 };
            //简便但是语法固定：声明+初始化+赋值
            float[] b03 = { 1, 2, 3, 4, 5, 6 };
            //直接赋值给参数
            float max = GetMax(new float[] { 1, 2, 3, 455, 3 });
        }
        /// <summary>
        /// 判断字符串里面是否为纯数字
        /// </summary>
        /// <param name="number">字符串</param>
        /// <returns>bool</returns>
        private static bool StringIsNumeric(string number)
        {
            try
            {
                int.Parse(number);
                return true;
            }
            catch
            {
                return false;
            }

        }
        /// <summary>
        /// 作业：录入学生成绩
        /// </summary>
        /// <returns>int[]</returns>
        static int[] CreateScoreArray()
        {
            //for (int i = 0; i < studentMark.Length; i++)
            //{
            //    int mark;
            //    Console.WriteLine("请输入第{0}个学生成绩", i + 1);
            //    string strMark = Console.ReadLine();

            //    for (; StringIsNumeric(strMark) == false;)
            //    {
            //        Console.WriteLine("请输入第{0}个学生成绩", i + 1);
            //        strMark = Console.ReadLine();
            //    }
            //    mark = int.Parse(strMark);
            //    for (; mark < 0 || mark > 100;)
            //    {
            //        Console.WriteLine("请输入第{0}个学生成绩", i + 1);
            //        strMark = Console.ReadLine();
            //        for (;StringIsNumeric(strMark) == false;)
            //        {
            //            Console.WriteLine("请输入第{0}个学生成绩", i + 1);
            //            strMark = Console.ReadLine();
            //        }
            //        mark = int.Parse(strMark);
            //    }

            //    studentMark[i] = mark;


            int count = 0;
            for (int i = 1; i < 2;)
            {
                Console.WriteLine("请输入学生总数：");
                string strCount = Console.ReadLine();
                if (StringIsNumeric(strCount) == true)
                {
                    count = int.Parse(strCount);
                    if (count > 0)
                    {
                        i++;
                    }
                }

            }

            int[] studentMark = new int[count];
            for (int i = 0; i < studentMark.Length;)
            {
                int mark;
                Console.WriteLine("请输入第{0}个学生成绩", i + 1);
                string strMark = Console.ReadLine();

                if (StringIsNumeric(strMark) == false)
                {
                    continue;
                }
                mark = int.Parse(strMark);
                if (mark < 0 || mark > 100)
                {
                    continue;
                }
                studentMark[i++] = mark;
            }
            return studentMark;
        }
        /// <summary>
        /// 得到数组最大值
        /// </summary>
        /// <param name="array">数组</param>
        /// <returns>float[]</returns>
        private static float GetMax(float[] array)
        {
            float max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i]) max = array[i];

            }
            return max;
        }

        /// <summary>
        /// 是否为闰年
        /// </summary>
        /// <param name="year">年</param>
        /// <returns>bool</returns>
        private static bool lsLeapYear(int year)
        {
            return year % 400 == 0 || (year % 4 == 0 && year % 100 != 0);
        }
        static void Main3(string[] args)
        {
            int totalDays = GetDay(2020, 12, 31);

            int[] array = new int[] { 1, 2, 3, 4, 45, 5, 6, 7, 5 };
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
            //*********************************************
            //新语法 foreach：依次读取 数组 元素
            //优点：使用简单，而且频率较高
            //缺点性能较差，限制很多
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            //var
            //推断类型：根据所赋值的数据，推断出类型
            //适用性：数据类型的名称较长
            //新知识点01
            var v1 = 1;//int    
            var v2 = "1";//string 
            var v3 = '1';//char
            var v4 = true;//bool
            var v5 = 1.0;//double
            var v6 = 1.0f;//float

            //新知识点02
            //声明的是爸爸 赋值给孩子
            //声明 父类类型(Array) 赋值 子类对象
            Array arr01 = new int[4] { 1, 2, 31, 1 };
            Array arr02 = new double[4];


            PrinElement(new int[] { 1, 2, 34, 5 });
            PrinElement(new float[] { 1, 2, 34, 5 });

            //新知识点03
            //万类之祖：object!
            //声明object类型 可以赋值 任意类型
            object o1 = 1;
            object o2 = true;
            object o3 = new int[2] { 9999999, 988888 };

            Fun1(o1);

            Console.ReadLine();

        }
        private static void Fun1(object obj)
        {
            Console.WriteLine(obj);
        }
        //看到参数是父类型的Array，可以传任意的数组类型
        //形参（方法需要的参数）是爸爸，实参（用的时候传的参数） 传孩子就行
        private static void PrinElement(Array arr)
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
        /// <summary>
        ///得到日期在年已经过了几天
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        private static int GetDay(int year, int month, int day)
        {
            int totalDays = 0;
            int[] daysOfMonth = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (lsLeapYear(year) == true) daysOfMonth[1] = 29;

            for (int i = 0; i < month - 1; i++)
            {
                totalDays += daysOfMonth[i];
            }
            totalDays += day;
            return totalDays;



        }

        static void Main(string[] args)
        {
            //常用方法以及属性

            //数组长度:数组名.Length
            //清除元素值(恢复默认值): Array.Clear(数组，索引，长度【如：索引的后几个】)
            //复制元素: Array.copy(原索引，指定索引【不写就是0开始】，目的地索引，指定索引【不写就是0开始】，长度)     ||   数组名.CopyTo(目的地索引，指定索引)
            //克隆:数组名.Clone 克隆一个数组不单单是赋值，数据类型和长度都一样克隆
            //查找元素: Array.IndexOf || Array.LastIndexOf
            //排序: Array.Sort
            //反转: Array.Reverse
            object  d ;
            int[] c = new int[10] ;
            int[] b = new int[6];
            int[] a = { 2, 2, 3, 4, 5,1,4 };
            Console.WriteLine(a.Length);
            Array.Clear(a, 3, 1);//a=22300

            foreach (var item in a)
            {
                Console.Write(item);
            }
            Console.WriteLine("b");

            Array.Copy(a,1, b,1, 5);
           
            foreach (var item in b)
            {
                Console.Write(item);
            }
            Console.WriteLine("b");

            a[0] += 3;
            b[0] = 7;
            foreach (var item in a)
            {
                Console.Write(item);
            }
            Console.WriteLine("a");

            a.CopyTo(c, 1);

            foreach (var item in c)
            {
                Console.Write(item);
            }
            Console.WriteLine("c");

            d= a.Clone();

            Array.Sort()


        }
    }





}
