namespace Lesson3变量本质
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 知识点一 变量的存储空间（内存中）
            // 1byte = 8bit
            // 1KB = 1024byte
            // 1MB = 1024KB
            // 1GB = 1024MB
            // 1TB = 1024GB
            // 通过sizeof方法 可以获取变量类型所占的内存空间（单位：字节）
            //有符号
            int sbyteSize = sizeof(sbyte);
            Console.WriteLine("sbyte类型所占的内存空间为：" + sbyteSize + " 字节");
            int intSize = sizeof(int);
            Console.WriteLine("int类型所占的内存空间为：" + intSize + " 字节");
            int shortSize = sizeof(short);
            Console.WriteLine("short类型所占的内存空间为：" + shortSize + " 字节");
            int longSize = sizeof(long);
            Console.WriteLine("long类型所占的内存空间为：" + longSize + " 字节");
            Console.WriteLine("==============================================");
            //无符号
            int byteSize = sizeof(byte);
            Console.WriteLine("byte类型所占的内存空间为：" + byteSize + " 字节");
            int uintSize = sizeof(uint);
            Console.WriteLine("uint类型所占的内存空间为：" + uintSize + " 字节");
            int ushortSize = sizeof(ushort);
            Console.WriteLine("ushort类型所占的内存空间为：" + ushortSize + " 字节");
            int ulongSize = sizeof(ulong);
            Console.WriteLine("ulong类型所占的内存空间为：" + ulongSize + " 字节");
            Console.WriteLine("==============================================");
            //浮点型
            int floatSize = sizeof(float);
            Console.WriteLine("float类型所占的内存空间为：" + floatSize + " 字节");
            int doubleSize = sizeof(double);
            Console.WriteLine("double类型所占的内存空间为：" + doubleSize + " 字节");
            int decimalSize = sizeof(decimal);
            Console.WriteLine("decimal类型所占的内存空间为：" + decimalSize + " 字节");
            Console.WriteLine("==============================================");
            //特殊类型
            int boolSize = sizeof(bool);
            Console.WriteLine("bool类型所占的内存空间为：" + boolSize + " 字节");
            int charSize = sizeof(char);
            Console.WriteLine("char类型所占的内存空间为：" + charSize + " 字节");
            //sizeof方法不能获取string类型所占的内存空间 因为字符串长度是可变的 不是固定的 所以无法获取
            //int stringSize = sizeof(string);


            #endregion
            #region 知识点二 变量的本质
            //变量的本质是二进制——>计算机中所有数据都是以二进制的形式存储的 是一堆0和1组成的
            //为什么计算机中所有数据都是以二进制的形式存储的呢？
            //数据传递只能通过电信号，只有开和关两种状态，开表示1，关表示0，所以计算机中所有数据都是以二进制的形式存储的
            //计算机中的存储单位最小的是bit（位） 1bit只能存储一个0或者1
            //1bit 就是一个数 不是0就是1
            //为了方便数据表示
            //计算机中规定了一个叫byte（字节）的单位，它是由8个bit组成的
            //所以我们一般说一个字节为8位
            // 1byte = 0000 0000

            #endregion
        }
    }
}
