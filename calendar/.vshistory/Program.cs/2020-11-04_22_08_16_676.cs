﻿using System;


namespace calendar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入查询年月");
            string strYearMonth = Console.ReadLine();
            int strMonth = strYearMonth.IndexOf("月");

            int strYear = strYearMonth.IndexOf("年");
            int year = int.Parse(strYearMonth.Remove(strYear));//得到年

            string monthNumber = strYearMonth.Remove(strMonth);
            monthNumber = strYearMonth.Remove(0, strYear + 1);
            int month = int.Parse(monthNumber);//得到月

            if (year % 400 == 0)
            {

            }

        }
        private static int MonthDay(int year, int month)
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
                        if (year % 400 == 0)
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
    }
}
