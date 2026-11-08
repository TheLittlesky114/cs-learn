//命名空间
namespace Lesson2变量
{
    //类
    internal class Program
    {
        //主函数 程序主入口
        static void Main(string[] args)
        {
            //函数语句块
            Console.WriteLine("Hello, World!");

            //知识点一 折叠代码
            //作用是在编程过程中 逻辑更清晰
            //它是由#region和#endregion组成的
            //具体作用 是可以将中间的代码折叠起来 让代码更清晰
            //本质上是 编辑器提供给我们的 预处理指令
            //只会在编辑器中起作用 不会影响程序的运行
            #region 知识点二 如何申明变量
            //变量是可以变化的容器 就是用来存储不同类型的数据的
            //不同变量类型可以存储不同类型的数据
            //变量的申明格式
            //变量类型 变量名 = 初始值;
            int a = 10;
            //变量类型有14种
            //变量名可以自定义 要按照一定的规则来命名
            //初始值一定要和变量类型匹配 否则会报错
            // =和;是固定写法 不能省略

            //变量类型
            //一定记住 各种变量类型的关键字
            //一定记住 各种变量类型 所能存储的数据范围
            //一定记住 各种变量类型 所能存储的数据类型

            //1.有符号的整形变量 是能存储 一定范围的整数
            //sbyte -128~127
            sbyte a1 = 1;
            //可以通过+来进行拼接打印
            Console.WriteLine("sbyte变量a1的值是：" + a1); 
            //int -2,147,483,648~2,147,483,647(-21亿~21亿多)
            int a2 = 1;
            //short -32,768~32,767
            short a3 = 1;
            //long -9,223,372,036,854,775,808~9,223,372,036,854,775,807（-9百万兆~9百万兆）
            long a4 = 1;

            //2.无符号的整形变量
            //byte 0~255
            byte a5 = 1;
            //uint 0~4,294,967,295(0~42亿多)
            uint a6 = 1;
            //ushort 0~65,535
            ushort a7 = 1;
            //ulong 0~18,446,744,073,709,551,615(0~18百万兆)
            ulong a8 = 1;

            //3.浮点型变量（小数）
            //float 存储7/8位有效数字 根据编译器不同 有效数字也可能不同 会四舍五入
            //float类型的变量在申明时 必须在初始值后面加上f 否则会报错 因为默认情况下 小数是double类型的
            //有效数字是指一个数中 从第一个不为0的数字开始 到最后一个数字为止 所有的数字
            float a9 = 0.01234567890f;
            Console.WriteLine(a9);
            //double 存储15~17位有效数字 也会四舍五入
            double a10 = 0.12345678901234567890123456789;
            Console.WriteLine(a10);
            //decimal 存储27~28位有效数字 不建议使用
            decimal a11 = 0.12345678901234567890123456789m;
            Console.WriteLine(a11);

            //4.特殊类型变量
            //bool 存储true和false 表示真假
            bool a12 = true;
            bool a12_1 = false;
            Console.WriteLine(a12 + "_" + a12_1);
            //char 存储单个字符
            char a13 = 'A';
            Console.WriteLine(a13);
            //string 是字符串的类型 用来存储多个字符 没有上限
            string a14 = "Hello, World!";
            Console.WriteLine(a14);


            int x = 0;
            Console.WriteLine(x);
            //变量的使用和修改 不能无中生有 必须先申明变量 才能使用和修改
            x = 100;
            Console.WriteLine(x);
            #endregion


            #region 知识点三 为什么有那么多变量类型
            //不同的变量类型 存储的范围和类型不同 本质上占用的内存空间大小不同
            //选择不同的数据（变量）类型装在不同的数据 可以节省内存空间 提高程序运行效率
            //姓名
            string name = "张三";
            //年龄
            byte age = 18;
            //身高
            float height = 177.5f;
            //体重
            float weight = 70.5f;
            //性别
            bool isMale = true;
            #endregion


            #region 知识点四 多个相同类型变量 同时申明
            int i1 = 0;
            float f1 = 0.0f;
            string s1 = "Hello";
            bool b = true;
            //多个相同类型变量 同时申明
            //格式：变量类型 变量名1 = 初始值1, 变量名2 = 初始值2, 变量名3 = 初始值3......;
            int b1 = 1, b2 = 2, b3 = 3;
            Console.WriteLine(b1);
            string s2 = "Hello", s3 = "World", s4 = "!";
            Console.WriteLine(s2 + s3 + s4);
            #endregion


            #region 知识点五 变量初始化相关
            //变量申明时 可以不赋初始值 但是在使用变量之前 必须给变量赋值 否则会报错（不建议这样写 因为不安全）
            int ii;
            ii = 0;
            Console.WriteLine(ii);
            #endregion

            #region 练习题
            //名字
            string myName = "李四";
            //年龄
            byte myAge = 18;
            //身高
            float myHeight = 177.5f;
            //体重
            float myWeight = 70.5f;
            //性别
            bool isMyMale = true;
            //住址
            string myAddress = "北京市朝阳区";
            Console.WriteLine("我的名字是：" + myName + "，年龄是：" + myAge + "，身高是：" + myHeight + "，体重是：" + myWeight + "，性别是否为男：" + isMyMale + "，住址是：" + myAddress);

            string info1 = "小明的数学考试成绩是";
            byte scoreMath = 80;
            string info2 = "语文的考试成绩是";
            byte scoreChinese = 78;
            string info3 = "英语的考试成绩是";
            byte scoreEnglish = 98;
            Console.WriteLine(info1 + scoreMath + '，' + info2 + scoreChinese + '，' + info3 + scoreEnglish);
            #endregion

        }
    }
}
