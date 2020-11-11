using System;

namespace day1         //命名空间
{
    class Program        //类
    {
        static void Main(string[] args)    //方法
        {
            Console.WriteLine("请输入枪的名字：");
            string gunName = Console.ReadLine();
            Console.WriteLine("请输入枪的弹夹容量：");
            string gunCapacity = Console.ReadLine();
            Console.WriteLine("请输入枪的当前弹夹容量：");
            string gunCapacityResidue = Console.ReadLine();
            Console.WriteLine("请输入剩余子弹：");
            string remainingBullets = Console.ReadLine();
            Console.WriteLine("枪的名字：" + gunName + " ,弹夹容量："
                + gunCapacity + " ,当前弹夹容量：" + gunCapacityResidue
                + " ,当前剩余子弹：" + remainingBullets + " 。");
            Console.ReadLine();


        }
    }
}
