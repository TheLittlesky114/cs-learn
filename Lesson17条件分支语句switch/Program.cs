namespace Lesson17条件分支语句switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 知识点一 作用
            //让顺序执行的代码 产生分支
            #endregion

            #region 知识点二 基本语法
            //switch (变量)
            //{
            //    // 变量 == 常量 执行 case和 break之间的代码
            //    case 常量:
            //        满足条件执行的代码逻辑;
            //        break;
            //    case 常量:
            //        满足条件执行的代码逻辑;
            //        break;
            //    case 可以有无数个
            //    default;
            //        如果上面的case条件都不满足 就会执行 default中的代码
            //}
            // 注意： 常量！！ 只能写一个值 不能去写一个范围 条件运算符 逻辑运算符
            // switch 只判断变量是否等于某一个固定值！！！！

            int a = 3;
            switch (a)
            {
                //这个条件一定是常量
                case 1:
                    Console.WriteLine("a等于1");
                    break;
                case 2:
                    Console.WriteLine("a等于2");
                    break;
                case 3:
                    Console.WriteLine("a等于3");
                    break;
                default:
                    Console.WriteLine("什么条件都不满足，执行default中的内容");
                    break;
            }

            float f = 1.4f;
            //他一般配合枚举使用
            switch (f)
            {
                case 1.5f:
                    Console.WriteLine("f=1.5");
                    break;
                default:
                    Console.WriteLine("什么条件都不满足，执行default中的内容");
                    break;
            }
            #endregion

            #region 知识点三 default可省略
            string str = "123";
            switch (str)
            {
                case "123":
                    Console.WriteLine("等于123");
                    break;
            }
            #endregion

            #region 知识点四 可自定义常量
            char c = 'A';
            //1.必须初始化 2.不能修改
            const char c2 = 'A';
            switch (c)
            { 
                case c2:
                    Console.WriteLine("c=A");
                    break;
                default:
                    break;
            }
            #endregion

            #region 知识点五 贯穿
            //作用：满足某些条件时 做的事情是一样的 就可以使用贯穿
            int aa = 1;
            switch (aa)
            {
                // 不写case后面配对的break 就叫贯穿
                // 满足 1 3 4 2其中一个条件 就会执行 之后的代码
                case 1:
                case 3:
                case 4:
                case 2:
                    // case和break之间可以写n句语句
                    // 并且可以嵌套使用
                    Console.WriteLine("是个数字");
                    Console.WriteLine("是个数字");
                    Console.WriteLine("是个数字");
                    Console.WriteLine("是个数字");
                    Console.WriteLine("是个数字");
                    if (aa == 1)
                    {
                        switch (aa)
                        {
                            default:
                                break;
                        }
                    }
                    else
                    {

                    }
                    break;
                default:
                    break;
            }
            #endregion

            #region 练习题
            Console.WriteLine("请输入唐老师的评级（很兴奋、很充实、还好吧、难理解、枯燥乏味）");
            string pingJia = Console.ReadLine();
            int salary = 4000;
            switch (pingJia)
            {
                case "很兴奋":
                    salary += 500;
                    break;
                case "很充实":
                    break;
                case "还好吧":
                    salary -= 300;
                    break;
                case "难理解":
                    salary -= 500;
                    break;
                case "枯燥乏味":
                    salary -= 800;
                    break;
                default:
                    Console.WriteLine("请输入正确等级");
                    break;
            }
            Console.WriteLine("唐老师的工资是：" + salary);

            int money = 10;
            Console.WriteLine("请输入选择的型号（中杯、大杯、超大杯）");
            string size = Console.ReadLine();
            switch (size)
            {
                case "中杯":
                    money -= 5;
                    break;
                case "大杯":
                    money -= 7;
                    break;
                case "超大杯":
                    money -= 11;
                    break;
            }
            if (money < 0)
            {
                Console.WriteLine("钱不够，请换其他型号");
            }
            else
            {
                Console.WriteLine("购买成功");
                Console.WriteLine("您还剩{0}块钱",money);
            }

            Console.WriteLine("请输入你的考试成绩");
            int score = int.Parse(Console.ReadLine());
            switch (score / 10)
            {
                case 9:
                case 10:
                    Console.WriteLine("A");
                    break;
                case 8:
                    Console.WriteLine("B");
                    break;
                case 7:
                    Console.WriteLine("C");
                    break;
                case 6:
                    Console.WriteLine("D");
                    break;
                default:
                    Console.WriteLine("E");
                    break;
            }
            try
            {
                int number = int.Parse(Console.ReadKey().KeyChar.ToString());
                switch (number)
                {
                    case 0:
                        Console.WriteLine("零");
                        break;
                    case 1:
                        Console.WriteLine("一");
                        break;
                    case 2:
                        Console.WriteLine("二");
                        break;
                    case 3:
                        Console.WriteLine("三");
                        break;
                    case 4:
                        Console.WriteLine("四");
                        break;
                    case 5:
                        Console.WriteLine("五");
                        break;
                    case 6:
                        Console.WriteLine("六");
                        break;
                    case 7:
                        Console.WriteLine("七");
                        break;
                    case 8:
                        Console.WriteLine("八");
                        break;
                    case 9:
                        Console.WriteLine("九");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("请输入0~9的数");
            }

            #endregion
        }
    }
}
