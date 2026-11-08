namespace Lesson6转义字符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 知识点一 转义字符的使用
            //什么是转义字符
            //它是字符串的一部分 用来表示一些特殊的字符
            //比如：当字符串中表现 单引号 引号 空号等等
            //string str = "wowwo"wowk";


            #region 固定写法
            //固定写法 \字符
            //不同的 \和字符和组合 表示不同的特殊字符

            //常用的转义字符
            //单引号 \'
            string str = "\'666\'";
            Console.WriteLine(str);

            //双引号 \"
            str = "\"666\"";
            Console.WriteLine(str);

            //换行 \n
            str = "66666666\n6666666";
            Console.WriteLine(str);

            //斜杠 \\  计算机文件路径 是要用到\符号的
            str = "6666\\66";
            Console.WriteLine(str);

    
            //不常用的转义字符（了解）
            //制表符 \t（空一个tab键，也就是4格）
            str = "66666666\t6666666";
            Console.WriteLine(str);
            //光标退格 \b（光标退格，删除前一个字符）
            str = "123\b123";
            Console.WriteLine(str);
            //空字符 \0（没有什么作用）
            str = "123\0456";
            Console.WriteLine(str);
            //警报音 \a（电脑发出警报音）
            str = "\a";
            Console.WriteLine(str);


            Console.WriteLine("123123\n123123\a\t123123");

            #endregion

            #endregion

            #region 知识点二 取消转义字符

            string str2 = @"123\123";
            Console.WriteLine(str2);

            Console.WriteLine(@"\n\\");
            #endregion

            #region 练习题
            //写出至少5种转义字符
            // 单引号\'  双引号\"  换行\n  斜杠\\  空4格\t  警报音\a  无意义\0

            Console.WriteLine("我是小明\n我今年18\n我的爱好是制作游戏\n我要好好学习，天天向上");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("我是小明");
            Console.WriteLine("我今年18");
            Console.WriteLine("我的爱好是制作游戏");
            Console.WriteLine("我要好好学习，天天向上");

            #endregion
        }
    }
}
