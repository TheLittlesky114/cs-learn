namespace Lesson7隐式转换
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 什么是隐式转换
            // 隐式转换 是指在不同变量类型之间相互转换

            // 隐式转换规则——>不同类型之间自动转换
            // 大范围装小范围

            #region 知识点一 相同大类型之间的转换

            //有符号  long——>int——>short——>sbyte
            long a = 1;
            int b = 2;
            short c = 3;
            sbyte d = 4;
            //隐式转换 int隐式转换成了long
            //可以用大范围 装小范围的类型（隐式转换）
            a = b;
            //不能用小范围的类型装在大范围的类型
            //b = a;
            a = b;
            a = c;
            a = d;
            b = c;
            c = d;

            //无符号  ulong——>uint——>ushort——>byte
            ulong ul = 1;
            uint ui = 2;
            ushort us = 3;
            byte by = 4;
            ul = ui;
            ul = us;
            ul = by;
            ui = us;
            ui = by;

            //浮点数  decimal   double——>float
            decimal de = 1.1m;
            double dou = 2.2;
            float fl = 3.3f;
            //decimal不能隐式转换成double和float
            //de = dou;
            //de = fl;
            //float可以隐式转换成double
            dou = fl;

            //特殊类型  bool char string
            //他们之间 不存在隐式转换

            #endregion

            #region 知识点二 不同大类型之间的转换

            #region 无符号和有符号之间的转换
            //无符号 不能装负数
            byte by2 = 1;//0~255
            ushort us2 = 2;
            uint ui2 = 4;
            ulong ul2 = 3;
            //有符号
            sbyte sb2 = 1;
            short s2 = 3;
            int i2 = 2;
            long l2 = 4;

            //无符号装有符号
            // 有符号的变量 是不能 隐式转换成 无符号的
            //by2 = sb2;
            //us2 = sb2;
            //ui2 = sb2;

            //有符号装无符号
            // 有符号变量 是可以 隐式转换成 无符号的 前提是 有符号变量的值 不能超过 无符号变量的范围
            //i2 = ui2;//因为有符号的数 可能会超过 这个无符号变量的范围
            i2 = by2;//因为有符号的数 不管是多少 都在无符号变量的范围内
            #endregion

            #region 浮点数和整数（有、无符号）之间
            //浮点数装整数 整形转换为浮点数 是可以隐式转换的
            float f2 = 1.1f;
            double d2 = 2.2;
            decimal de2 = 3.3m;

            //浮点数 是可以装载任何类型的 整数的
            f2 = l2;
            f2 = i2;
            f2 = s2;
            f2 = sb2;

            f2 = ul2;
            f2 = us2;
            f2 = ui2;
            f2 = by2;

            f2 = 10000000000000000000;
            Console.WriteLine(f2);

            //decimal 不能隐式存储 float和double
            //但是 decimal 可以隐式存储 整数类型
            de = l2;
            de = ul2;

            // double ——> float ——> 所有整形（有符号、无符号）
            // decimal ——> 所有整形（有符号、无符号）

            //整数装浮点数 整数是不能隐式转换成 浮点数的 因为 整数 不能存小数
            //i2 = f2;

            #endregion

            #region 特殊类型和其他类型之间

            //bool bool没有办法和其它类型 相互隐式转换
            bool bo2 = true;
            char c2 = 'a';
            string str2 = "hello";
            //bo2 = i2;
            //bo2 = ui2;
            //bo2 = f2;

            //i2 = bo2;
            //ui2 = bo2;
            //f2 = bo2;

            //bo2 = c2;
            //c2 = bo2;
            //bo2 = str2;
            //str2 = bo2;

            //char char没有办法 隐式转换 其它类型的变量
            //c2 = i2;
            //c2 = ui2;
            //c2 = f2;
            //c2 = str2;

            //char类型 可以隐式转换成 部分整形和浮点型 因为 char类型 是一个16位无符号整数 取值的范围是 0~65535 
            //char隐式转换成 数值类型时
            //对应的数字 其实是一个 ASCII码
            // 计算机里面存储 二进制
            // 字符 中文 英文 标点符号 在计算机中都是一个数字
            // 一个字符 对应一个数字 ASCII码就是一种对应关系

            i2 = c2;
            Console.WriteLine(i2);
            f2 = c2;
            Console.WriteLine(f2);
            ui2 = c2;
            Console.WriteLine(ui2);

            //str2 = c2;

            //string类型 无法隐式转换成 其它类型的变量
            //i2 = str2;
            //ui2 = str2;
            //f2 = str2;

            #endregion

            #endregion


            // 总结 隐式转换 规则
            // 高精度（大范围）装低精度（小范围）
            // double ——> float ——> 所有整形（有符号、无符号）——> char
            // decimal ——> 所有整形（有符号、无符号）——> char
            // string 和 bool 是不参与隐式转换规则的

            #region 练习题

            int name1 = 't';
            int name2 = 'h';
            int name3 = 'e';
            int name4 = 'l'; 
            int name5 = 'i';
            int name6 = 't';
            int name7 = 't';
            int name8 = 'l';
            int name9 = 'e';
            int name10 = 's';
            int name11 = 'k';
            int name12 = 'y';
            Console.WriteLine(name1 + " " + name2 + " " + name3 + " " + name4 + " " + name5 + " " + name6 + " " + name7 + " " + name8 + " " + name9 + " " + name10 + " " + name11 + " " + name12);
            int i100 = 120;
            char char1 = 't';
            i100 = char1;
            Console.WriteLine(i100);
            #endregion
        }
    }
}
