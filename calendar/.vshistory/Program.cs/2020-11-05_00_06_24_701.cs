using System;

namespace calendar
{
    class Program //写日历，输入年或者年月得到月历
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入查询年月");
            string strYearMonth = Console.ReadLine();

            if (strYearMonth.Contains("年") == true && strYearMonth.Contains("月") == true)//有年有月
            {
                int strMonth = strYearMonth.IndexOf("月");
                int strYear = strYearMonth.IndexOf("年");

                int year = int.Parse(strYearMonth.Remove(strYear));//得到年


                string monthNumber = strYearMonth.Remove(strMonth);
                monthNumber = monthNumber.Remove(0, strYear + 1);
                int month = int.Parse(monthNumber);//得到月

                int day = GetMonthByDay(year, month);//得到每月有多少天
                if (year > 0 && month > 0)
                {
                    Console.WriteLine("日\t一\t二\t三\t四\t五\t六");//表头
                    int blankNumber = GetWeekByDay(year, month, 1);//得到这个月1日是星期几
                    for (int i = 1; blankNumber >= i; i++)
                    {
                        Console.Write(" \t");
                    }
                    for (int i = 1; day >= i; i++)
                    {
                        Console.Write(+i + "\t");
                        if (GetWeekByDay(year, month, i) == 6)
                        {
                            Console.Write("\r\n");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("输入错误");
                }
            }
            else if (strYearMonth.Contains("年") == true && strYearMonth.Contains("月") == false)
            {
                int strYear = strYearMonth.IndexOf("年");
                int year = int.Parse(strYearMonth.Remove(strYear));//得到年
                if (year > 0)
                {
                    for (int monthAdd = 1; monthAdd <= 12; monthAdd++)
                    {
                        Console.WriteLine(monthAdd + "月");
                        Console.WriteLine("日\t一\t二\t三\t四\t五\t六");//表头

                        int day = GetMonthByDay(year, monthAdd);//得到每月有多少天

                        int blankNumber = GetWeekByDay(year, monthAdd, 1);//得到每个月1日是星期几


                        for (int i = 1; blankNumber >= i; i++)
                        {
                            Console.Write(" \t");
                        }
                        for (int i = 1; day >= i; i++)
                        {
                            Console.Write(+i + "\t");
                            if (GetWeekByDay(year, monthAdd, i) == 6)
                            {
                                Console.Write("\r\n");
                            }
                            if (day == i)
                            {
                                Console.Write("\r\n\r\n");
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("输入错误");
                }
            }
            else
            {
                Console.WriteLine("输入错误");
            }


        }
        /// <summary>
        /// 每个月的天数
        /// </summary>
        /// <param name="year">月</param>
        /// <param name="month">日</param>
        /// <returns>天数</returns>
        private static int GetMonthByDay(int year, int month)
        {
            int day = 0;
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
                        if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                        {
                            day = 28;
                        }
                        else
                        {
                            day = 29;
                        }
                        break;
                    default:
                        day = 31;
                        break;
                }

            }
            else
            {
                Console.WriteLine("无此月份");
            }
            return day;
        }
        /// <summary>（文档注释）
        /// 根据年月日，计算星期数的方法 
        /// </summary>
        /// <param name="year">年</param>
        /// <param name="month">月</param>
        /// <param name="day">日</param>
        /// <returns>星期数</returns>
        private static int GetWeekByDay(int year, int month, int day)
        {
            DateTime dt = new DateTime(year, month, day);
            return (int)dt.DayOfWeek;

        }
        //老师写的
        private static bool lsLeapYear(int year)
        {

            return year % 400 == 0 || (year % 4 == 0 && year % 100 != 0);

        }
    }
}
