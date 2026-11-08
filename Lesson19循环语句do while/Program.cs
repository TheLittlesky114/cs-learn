namespace Lesson19循环语句do_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 知识点一 基本语法
            // while循环 先判断条件再执行
            // do while循环 是先斩后奏 先至少执行一次循环语句块中的逻辑 再判断是否继续
            //do
            //{
            //    //do while循环语句块;
            //} while (bool类型的值);
            // 注意 do while语句 存在一个重要的分号
            #endregion

            #region 知识点二 实际使用

            //do while使用较少

            //do
            //{
            //    Console.WriteLine("do while循环语句块");
            //} while (false);

            int a = 0;
            do
            {
                Console.WriteLine(a);
                ++a;
            } while (a < 2);
            #endregion

            #region 知识点三 嵌套使用
            // if switch while do while
            do
            {
                //if (true)
                //{

                //}
                //while (true)
                //{

                //}
                //int i = 1;
                //switch (i)
                //{
                //    default:
                //        break;
                //}
                //break;
                Console.WriteLine(a);
                continue;//回到while中
            } while (false);
            #endregion

            #region 练习题
            string userName;
            string password;
            bool isShow = false;
            do
            {
                if (isShow)
                {
                    Console.WriteLine("用户名或密码错误");
                }
                userName = Console.ReadLine();
                password = Console.ReadLine();
                isShow = true;  
            } while (userName != "admin" || password != "8888");
            
            string name;
            do
            {
                Console.WriteLine("输入用户名");
                name = Console.ReadLine();
            } while (name != "q");
            #endregion
        }
    }
}
