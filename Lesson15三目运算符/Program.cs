namespace Lesson15三目运算符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 知识点一 基本语法
            //套路： 3个空位 2个符号 
            //固定语法：空位     ? 空位                : 空位;         
            //关键信息：bool类型 ? bool类型为真返回内容 : bool类型为假返回内容;
            //三目运算符 会有返回值，这个返回值类型必须一致，并且必须使用
            #endregion

            #region 知识点二 具体使用
            string str = true ? "真" : "假";
            Console.WriteLine(str);

            int a = 5;
            str = a > 1 ? "对" : "错";
            Console.WriteLine(str);

            int i = a > 1 ? 123 : 234;

            //第一个空位 始终是结果为bool类型的表达式 可以是 bool变量 条件表达式 逻辑运算符表达式
            //第二三个空位 什么表达式都可以 只要保证他们的结果是一致的

            bool b = a > 1 ? a > 6 : !false;

            #endregion

            #region 练习题

            Console.WriteLine(5 > 6 ? "5大" : "6大");

            Console.Write("请输入姓名：");
            string str1 = Console.ReadLine();
            Console.WriteLine(str1 == "帅哥" ? "帅哥" : "美女");

            Console.Write("请输入姓名：");
            Console.ReadLine();
            Console.Write("请输入c#成绩：");
            int csScore = Convert.ToInt32(Console.ReadLine());
            Console.Write("请输入unity成绩：");
            int unityScore = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(csScore + unityScore >=90 ? "你可以毕业" : "你不能毕业");

            Console.Write("请输入年份：");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine(year % 400 == 0 || year % 4 == 0 && year % 100 != 0 ? "是闰年" : "不是闰年");
            #endregion
        }
    }
}
