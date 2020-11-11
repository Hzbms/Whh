using System;


namespace calendar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入查询年月");
            Console.ReadLine().IndexOf("年"); ;

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
