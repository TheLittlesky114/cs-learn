using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks.Sources;

namespace Lesson18循环语句while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 知识点一 作用
            // 让顺序执行的代码 可以不停的循环执行某一代码块的内容
            // 条件分支语句 是 让代码产生分支
            // 循环语句 是 让代码可以被重复执行
            #endregion

            #region 知识点二 语法相关
            // bool类型变量 条件运算符 逻辑运算符
            //while (bool类型的值)
            //{
            //    //当满足条件时 就会执行while语句块中的内容
            //    //......
            //    //......
            //    //......
            //    //......
            //    //当代码逻辑执行完 会回到while循环开头
            //    //再次进行条件判断
            //}
            //Console.WriteLine("主代码逻辑");

            //死循环
            //就不停的执行循环中的逻辑 “知道死为止”
            //死循环只有在目前我们学习 控制台程序时 会频繁使用
            //之后进入 unity过后 基本不会使用死循环
            //1、可能因为内存问题 造成程序崩溃 闪退
            //2、造成程序卡死
            //while (true) 
            //{
            //    Console.WriteLine("*****************");
            //    Console.WriteLine("请玩家输入用户名密码");
            //    Console.ReadLine();
            //}

            //计算一个为0的整形变量 让他只能累加1 不停加到10为止
            //int i = 0;
            //bool类型的值 还可以用逻辑运算符 && || ! 条件运算符 算术运算结合运算
            //while (i < 10)
            //{
            //    ++i;
            //}
            //Console.WriteLine(i);
            #endregion

            #region 知识点三 嵌套使用
            // 不仅可以嵌套 if switch 还可以嵌套 while
            int a = 0;
            int b = 0;
            while (a < 10)
            {
                ++a;
                while (b < 10)
                {
                    ++b;
                }
            }

            a = 0;
            b = 0;
            while (a < 10) 
            {
                ++a;
                if (b < 10)
                {
                    ++b;
                }
            }

            int a2 = 0;
            while (a2 < 10)
            {
                ++a2;
                //每次从外层循环进来时
                //b2和上一次的b2有没有关系 是不是一个变量
                //切记 没有关系
                int b2 = 0;
                while(b2 < 10)
                {
                    ++b2;
                }
            }

            #endregion

            #region 知识点四 流程控制关键词
            //作用： 控制循环逻辑的关键词
            // break：跳出循环
            while (true)
            {
                Console.WriteLine("break之前的代码");
                break;
                Console.WriteLine("break之后的代码");
            }
            Console.WriteLine("循环外的代码");

            int i = 0;
            while (true)
            {
                ++i;
                Console.WriteLine(i);
                if (i == 10)
                {
                    break;
                }
            }
            Console.WriteLine(i);

            // continue：回到循环开始 继续执行
            //while (true)
            //{
            //    Console.WriteLine("continue前的代码");
            //    continue;
            //    Console.WriteLine("continue后的代码");
            //}
            //Console.WriteLine("循环外的代码");

            //打印1~20之间的 奇数
            int a1 = 0;
            while (a1 < 20)
            {
                ++a1;
                //什么样的数是奇数
                //不能被2整除的数 ——> %
                if (a1 % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine(a1);
            }

            //注意：break和continue主要是和循环配合使用的 和if语句无关
            // break在switch中的作用 和 while循环中的作用有异曲同工之妙

            //while (true)
            //{
            //    int a3 = 1;
            //    switch (a3)
            //    {
            //        default:
            //            continue;
            //            break;
            //    }
            //    Console.WriteLine("1111111");
            //}
            #endregion

            #region 练习题

            //Console.WriteLine("********************************");
            //int number = 0;
            //while (number < 100)
            //{
            //    ++number;
            //    Console.WriteLine(number);
            //}

            //number = 0;
            //int sum = 0;
            //while (number < 100)
            //{
            //    ++number;
            //    sum += number;
            //}
            //Console.WriteLine(sum);

            //number = 0;
            //sum = 0;
            //while (number < 100)
            //{
            //    ++number;
            //    if (number % 7 == 0)
            //    {
            //        continue;
            //    }
            //    sum += number;
            //}
            //Console.WriteLine(sum);

            //Console.WriteLine("请输入一个数");
            //number = int.Parse(Console.ReadLine());
            //int index = 2;
            //while (index < number)
            //{
            //    if(number % index == 0)
            //    {
            //        break;
            //    }
            //    ++index;
            //}
            //if (index != number)
            //{
            //    Console.WriteLine("不是质数");
            //}
            //else
            //{
            //    Console.WriteLine("是质数");
            //}

            //while (true)
            //{
            //    string name = Console.ReadLine();
            //    string password = Console.ReadLine();
            //    if (name == "admin" && password == "8888")
            //    {
            //        Console.WriteLine("输入正确");
            //        break;
            //    }
            //    else 
            //    {
            //        Console.WriteLine("用户名或密码错误");
            //    }   
            //}

            //Console.WriteLine("请输入班级人数");
            //int person = int.Parse(Console.ReadLine());
            //int person1 = 1;
            //double sum1 = 0;
            //while (true)
            //{
            //    Console.Write("第{0}个学员成绩：", person1);
            //    ++person1;
            //    double score = double.Parse(Console.ReadLine());
            //    sum1 += score;
            //    if (person1 == person + 1)
            //    {
            //        break;
            //    }
            //}
            //Console.WriteLine("总成绩：" + sum1);
            //Console.WriteLine("平均成绩：" + sum1 / person);

            //int sum2 = 0;
            //int number2 = 1;
            //while (number2 <= 100)
            //{
            //    sum2 += number2;
            //    if (sum2 > 500)
            //    {
            //        break;
            //    }
            //    ++number2;
            //}
            //Console.WriteLine("累加到{0}个数字就是可以使sum>500", number2);

            //float classmate = 100f;
            //int month = 1;
            //while (true)
            //{
            //    classmate *= 1.2f;
            //    ++month;
            //    if (classmate >= 1000)
            //    {
            //        break;
            //    }
            //}
            //Console.WriteLine("经历{0}个月看唐老师的视频的同学能达到1000人",month);

            //数列 1,1,2,3,5,8,13......第20位数是多少
            // 2 = 1 + 1
            // 3 = 2 + 1
            // 5 = 3 + 2
            int n1 = 1;
            int n2 = 1;
            int index = 0;
            int result = 0;
            while(index < 20)
            {
               ++index;
                if (index == 1)
                {
                    result = n1;
                }
                else if (index == 2)
                {
                    result = n2;
                }
                else
                {
                    //从第三个数以后 都是用前两个数相加得到结果
                    // 2 = 1 + 1;
                    //目前算的是第三个数
                    result = n1 + n2;
                    //接下来要算第四个数
                    n1 = n2;
                    n2 = result;
                }
            }
            Console.WriteLine(result);

            int num = 2;
            while (num < 100)
            {
                ++num;
                int index1 = 2;
                while (index1 < num)
                {
                    if (num % index1 == 0)
                    {
                        break;
                    }
                    ++index1;
                }
                if(index1 == num)
                {
                    Console.WriteLine(num);
                }
            }

            #endregion
        }
    }
}
