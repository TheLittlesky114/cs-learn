using System.ComponentModel.Design.Serialization;

namespace Lesson20循环语句for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 基本语法
            //for ( /*初始表达式*/; /*条件表达式*/; /*增量表达式*/ )
            //{
            //    //循环代码逻辑;
            //}
            // 第一个空（初始表达式）：一般申明一个临时变量，用来计数
            // 第二个空（条件表达式）：表明进入循环的条件 一个bool类型的结果（bool变量 条件运算符 逻辑运算符 算术运算符）
            // 第三个空（增量表达式）：用第一个空中的变量 进行 自增减运算

            // 第一次进入循环时 才会调用 第一个空中的代码
            // 每次进入循环之前 都会判断第二个空中的条件 满足才会进入循环逻辑
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                //执行完循环语句块中的逻辑后
                //最后执行第三个空中的代码
            }

            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(i);
            }

            //每个空位 可以按照规则进行书写
            //第一个空位 就是申明变量 所以可以连续申明
            //第二个空位 就是进入条件 只要是bool结果的表达式 都可以
            //第三个空位 就是执行一次循环逻辑过后要做的事情 做啥都行
            //for(int i = 0, j = 0; i < 10 && j < 0; ++i, j += 1) 
            //{

            //}

            #endregion

            #region 知识点二 支持嵌套
            //for(int i = 0; i < 10; i++) 
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        Console.WriteLine(i + "_" + j);
            //    }
            //    while (true)
            //    {

            //    }
            //    if (true)
            //    {

            //    }
            //    do
            //    {

            //    } while (true);
            //}

            #endregion

            #region 知识点三 特殊写法
            //for循环 这三个空位 可以都空着 可以根据需求去填写

            // for循环可以写死循环
            //for ( ; ; )
            //{
            //    Console.WriteLine("for循环的死循环");
            //}

            //int k = 0;
            //for(; k < 10;) 
            //{
            //    ++k;//k++, k += 1;
            //}

            //for(k=0; ; ++k) 
            //{
            //    if (k >= 10) 
            //    {
            //        break;
            //    }
            //}

            #endregion

            #region 知识点四 对比while循环
            //for循环 一般用来可以准确得到 一个范围中的所有数
            for(int i = 0; i < 10; ++i) 
            {

            }

            int j = 0;
            while (j < 10)
            {
                ++j;
            }

            #endregion

            #region 练习题
            Console.WriteLine("*********************");
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("*********************");
            int sum = 0;
            for(int i = 1; i <= 100 ; i++) 
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }   
            }
            Console.WriteLine("偶数之和为: " + sum);

            Console.WriteLine("**********************");
            for (int i = 100; i <= 999; i++)
            {
                if ((i / 100)* (i / 100)* (i / 100) + 
                    (i / 10 - i / 100 * 10)* (i / 10 - i / 100 * 10) * (i / 10 - i / 100 * 10) + 
                    (i % 100 % 10) * (i % 100 % 10) * (i % 100 % 10) == i)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("*******************");
            //for (int i1 = 1,i3 = 1; i1 <= 9; i1++,i3++)
            //{
            //    for (int i2 = i3; i2 <= 9; i2++)
            //    {
            //        Console.WriteLine(i1 + "×" + i2 + "=" + i1 * i2);
            //    }
            //}
            for (int i = 1; i <= 9; i++)
            {
                for (int j1 = 1; j1 <= i; j1++)
                {
                    Console.Write("{0}×{1}={2}  ", j1, i, i * j1);
                }
                Console.WriteLine();
            }

            Console.WriteLine("********************");
            for (int width = 1; width <= 10; width++)
            {
                if (width == 1 || width == 10)
                {
                    for (int length = 1; length <= 10; length++)
                    {
                        if (length < 10)
                        {
                            Console.Write("*");
                        }
                        if (length == 10)
                        {
                            Console.WriteLine("*");
                        }
                    }
                }
                if (width >= 2 && width <= 9)
                {
                    for (int length = 1; length <= 10; length++)
                    {
                        if (length == 1)
                        {
                            Console.Write("*");
                        }
                        if (length > 1 && length < 10)
                        {
                            Console.Write(" ");
                        }
                        if (length == 10)
                        {
                            Console.WriteLine("*");
                        }
                    }
                }
            }

            Console.WriteLine("**********************");

            for (int width = 1; width <= 10; width++)
            {
                for (int length = 1; length <= width; length++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("**********************");
            //在控制台上输出如下10行的三角形方阵
            //         *            1    1   ——> 2i - 1     9   10 - i
            //        ***           2    3   ——> 2i - 1     8   10 - i
            //       *****          3    5   ——> 2i - 1     7
            //      *******         4    7   ——> 2i - 1     6
            //     *********        5    9   ——> 2i - 1     5
            //    ***********       6    11  ——> 2i - 1     4
            //   *************      7    13  ——> 2i - 1     3
            //  ***************     8    15  ——> 2i - 1     2
            // *****************    9    17  ——> 2i - 1     1
            //*******************   10   19  ——> 2i - 1     0
            for (int i = 1; i <= 10; i++)
            {
                //打印空格
                for (int k = 1; k <= 10 - i; k++)
                {
                    Console.Write(" ");
                }
                //打印星号
                for (int length = 1; length <= 2*i-1; length++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            #endregion
        }
    }
}
