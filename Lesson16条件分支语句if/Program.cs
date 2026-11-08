namespace Lesson16条件分支语句if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 知识点一 作用
            //让顺序执行的代码 产生分支
            //if语句是第一个 可以让我们的程序 产生逻辑变化的 语句
            #endregion

            #region 知识点二 if语句
            //作用：满足条件时 多执行一些代码
            //语法：
            // if( bool类型值 )  //bool类型相关：bool变量 条件运算符表达式 逻辑运算符表达式
            // {
            //      满足条件要执行的代码 写在if代码块中;
            // }
            // 注意：
            // if语句的语法部分 不需要写分号
            // if语句可以嵌套使用

            if (true)
            {
                Console.WriteLine("进入了if语句代码块，执行其中的代码逻辑");
            }
            Console.WriteLine("if语句外的代码");

            int a = 1;
            if ( a > 0 && a < 5 )
            {
                Console.WriteLine("a在0~5之间");
            }

            string name = "小明";
            string passWord = "666";
            if(name == "小明" && passWord == "666")
            {
                Console.WriteLine("登录成功");
            }

            //嵌套使用
            if (name == "小明")
            {
                Console.WriteLine("用户名验证成功");
                if (passWord == "666")
                {
                    Console.WriteLine("密码验证成功");
                    //可以无限嵌套
                }
            }

            #endregion

            #region 知识点三 if...else语句
            // 作用：产生两条分支 十字路 满足条件做什么 不满足做什么

            //语法：
            // if( bool类型值 )
            // {
            //      满足条件执行的代码;
            // }
            // else
            // {
            //      不满足条件执行的代码;
            // }
            // 注意：
            // if...else 语句 语法部分 不需要写分号
            // if...else 语句 可以嵌套

            if( true)
            {
                Console.WriteLine("满足if条件做什么");
                if (true)
                {

                }
                else
                {

                }
            }
            else
            {
                Console.WriteLine("不满足if条件做什么");
                if (true)
                {

                }
                else
                {

                }
            }

            //其他的使用和if的使用时一样
            // 嵌套使用 也是和if语句 一样的

            #endregion

            #region 知识点四 if...else if...else 语句
            //作用：产生n条分支 多条道路选择 最先满足其中的一个条件 就做什么

            // 语法：
            // if( bool类型值 )
            // {
            //      满足条件执行的代码;
            // }
            // else if( bool类型值 )
            // {
            //      满足条件执行的代码;
            // }
            // ...中间可以有n个 else if语句代码块
            // else
            // {
            //      不满足条件执行的代码;
            // }

            //注意：
            // 和前面两个是一样的 不需要写分号
            // 是可以嵌套的
            // else 是可以省略的
            // 注意 条件判断 从上到下执行 满足第一个后 之后的都不需要执行了

            int a3 = 10;
            if (a3 >= 10)
            {
                Console.WriteLine("a大于等于10");
            }
            else if(a3>5 && a3 < 10)
            {
                Console.WriteLine("a在6~9之间");
            }
            else if (a3 > 0 && a3 < 5)
            {
                Console.WriteLine("a在0~5之间");
            }
            else
            {
                Console.WriteLine("a小于0");
            }

            //if语句相关 if if...else  if...else if...else
            //else if 和 else 是组合套餐 根据实际情况选择使用

            //if ( true )
            //{

            //}
            //if (true)
            //{

            //}
            //也可以这样 但是效率更低
            #endregion

            #region 练习题
            Console.WriteLine("今日观看唐老师视频花了多少分钟？");
            int minute = int.Parse(Console.ReadLine());
            if (minute > 60)
            {
                Console.WriteLine("今天看视频花了{0}分钟，看你离成功又进一步！",minute);
            }

            int chineseScore = int.Parse(Console.ReadLine());
            int mathScore = int.Parse(Console.ReadLine());
            int englishScore = int.Parse(Console.ReadLine());
            if(chineseScore>70 && mathScore>80 && englishScore>90 ||chineseScore==100 || chineseScore==100 || englishScore ==100 || chineseScore>90 && (mathScore>70 || englishScore > 70))
            {
                Console.WriteLine("非常棒，继续加油！");
            } 

            int score = int.Parse(Console.ReadLine());
            if (score >= 90)
            {
                Console.WriteLine("奖励100块");
            }
            else
            {
                Console.WriteLine("你一个月不能玩游戏");
            }

            a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a % b == 0 || b % a == 0 || a + b > 100)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(b);
            }

            int c = int.Parse(Console.ReadLine());
            if (c % 2 == 0)
            {
                Console.WriteLine("Your input is even");
            }
            else
            {
                Console.WriteLine("Your input is odd");
            }

            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int f = int.Parse(Console.ReadLine());
            if (d > e && d > f)
            {
                Console.WriteLine(d);
            }
            else if (e > d && e > f)
            {
                Console.WriteLine(e);
            }
            else
            {
                Console.WriteLine(f);
            }

            //int g = Convert.ToInt32(Console.ReadKey().KeyChar);
            //通过Convert把char转成整形 转过去的是对应的ASCII码的数值
            // char类型可以隐式转换为 数值类型
            int ascii = Console.ReadKey().KeyChar;
            int zeroAsc = '0';
            int nineAsc = '9';
            if ( ascii >= zeroAsc && ascii <= nineAsc )
            {
                Console.WriteLine("您输入了一个数字");
            }
            else
            {
                Console.WriteLine("这不是一个数字");
            }

            Console.Write("请输入用户名：");
            string h = Console.ReadLine();
            Console.Write("请输入密码：");
            int i = int.Parse(Console.ReadLine());
            if (h == "admin" && i == 8888)
            {
                Console.WriteLine("正确");
            }
            else if (h != "admin")
            {
                Console.WriteLine("用户名不存在");
            }
            else if (h == "admin" && i != 8888)
            {
                Console.WriteLine("密码错误");
            }

            Console.Write("请输入年龄：");
            int age = int.Parse(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("你可以查看");
            }
            else if(age >=13 && age < 18)
            {
                Console.WriteLine("是否继续查看（yes、no）");
                string age1 = Console.ReadLine();
                if(age1 == "yes")
                {
                    Console.WriteLine("请查看");
                }
                else
                {
                    Console.WriteLine("你不能查看");
                }
            }

            // 语句块 会影响 变量的 生命周期
            //int a1 = 5; 
            //if (a1 > 3)
            //{
            //    int b1 = 0; ++b1; b1 += a1;
            //}
            //Console.WriteLine(b1);//会报错

            //函数语句块 目前我们学习知识时 是层级最高的语句块

            #endregion
        }
    }
}
