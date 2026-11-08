using System.Diagnostics.CodeAnalysis;

namespace Lesson10算数运算符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 知识点一 赋值符号
            // =
            // 关键知识点
            // 先看右侧 再看左侧 把右侧的值赋给左侧的变量
            string myName = "小空";
            int myAge = 18;
            float myHeight = 177.5f;

            #endregion

            #region 知识点二 算数运算符
            #region 加 +            
            // 用自己计算 先算右侧结果 再赋值给左侧变量
            int i = 1;
            // 3
            i = i + 2;
            Console.WriteLine(i);
            // 连续运算 先算右侧结果 再赋值给左侧变量
            // 99
            i = 1 + 3 + 89 + i + i;
            Console.WriteLine(i);
            // 4
            i = 1 + 2 + 1;
            Console.WriteLine(i);
            // 初始化时就运算 先算右侧结果 再赋值给左侧变量
            int i2 = 1 + 2 + 4 + i;
            Console.WriteLine(i2);
            #endregion

            #region 减 -
            // 用自己计算 先算右侧结果 再赋值给左侧变量
            int j = 1;
            j = j - 1;
            Console.WriteLine(j);
            // 连续运算 先算右侧结果 再赋值给左侧变量
            j = 1 - 2 - 3;
            Console.WriteLine(j);
            j = 1 - j;
            Console.WriteLine(j);//5
            // 初始化时就运算 先算右侧结果 再赋值给左侧变量
            int j2 = 1 - j - 0;
            Console.WriteLine(j2);
            #endregion

            #region 乘 *
            // 用自己计算 先算右侧结果 再赋值给左侧变量
            int c = 1;
            c = c * 10;
            Console.WriteLine(c);
            // 连续运算 先算右侧结果 再赋值给左侧变量
            c = 1 * 2 * 3;
            Console.WriteLine(c);
            c = 2 * c * 2;
            Console.WriteLine(c);
            // 初始化时就运算 先算右侧结果 再赋值给左侧变量
            int c2 = c * 2;
            Console.WriteLine(c2);
            #endregion

            #region 除 /
            // 用自己计算 先算右侧结果 再赋值给左侧变量
            int chu = 1;
            chu = 10 / chu;
            Console.WriteLine(chu);
            // 连续运算 先算右侧结果 再赋值给左侧变量

            // 初始化时就运算 先算右侧结果 再赋值给左侧变量

            chu = 1;
            chu = 1 / 2;
            Console.WriteLine(chu);
            //默认的整数 是int 如果用来做除法运算 要注意 会丢失小数点后的小数
            //如果你想用浮点数来存储 一定是 在运算时要有浮点数的特征
            float f = 1f / 2;
            Console.WriteLine(f);
            #endregion

            #region 取余 %
            // 用自己计算 先算右侧结果 再赋值给左侧变量
            int y = 4;
            // 4 / 3 得到余数 1
            y = y % 3;
            // 连续运算 先算右侧结果 再赋值给左侧变量

           y = 4 % 3 % 2;
            Console.WriteLine(y);
            // 初始化时就运算 先算右侧结果 再赋值给左侧变量

            #endregion

            #endregion

            #region 知识点三 算数运算符的 优先级
            //优先级 是指 在混合运算时的运算顺序

            //乘除取余 优先级高于 加减 先算乘除取余 后算加减
            // 1 + 3 + 1 + 6
            int a = 1 + 2 * 3 / 2 + 1 + 2 * 3;
            Console.WriteLine(a);

            a = 1 + 4 % 2 * 3 / 2 + 1;
            Console.WriteLine(a);

            //括号可以改变优先级 优先计算括号内内容
            a = 1 + 4 % (2 * 3 / 2) + 1;
            Console.WriteLine(a);

            //多组括号 先算最里层括号 依次往外算
            a = 1 + 4 % (2 * (3 / 2)) + 1;
            Console.WriteLine(a);
            #endregion

            #region 知识点四 算数运算符的 复合运算符
            // 固定写法 运算符=
            // += -= *= /= %=
            // 复合运算符 适用于 自己=自己进行运算
            int i3 = 1;
            i3 = i3 + 2;
            Console.WriteLine(i3);

            i3 = 1;
            i3 += 2;//i3 = i3 + 2;
            Console.WriteLine(i3);

            i3 = 2;
            i3 += 2;//4
            i3 -= 2;//2
            i3 /= 2;//1
            i3 *= 2;//2
            i3 %= 2;//0
            Console.WriteLine(i3);

            int i4 = 10;
            // i4 += 4
            i4 += 20 * 2 / 10;
            Console.WriteLine(i4);

            //注意：复合运算符 只能进行一种运算 不能混合运算
            //i4 */-= 2;

            #endregion

            #region 知识点五 算数运算符的 自增减
            int a2 = 1;
            a2 = a2 + 1;
            
            a2 = 1;
            a2 += 1;

            //自增运算符 让自己+1
            a2 = 1;
            a2++;//先用再加
            Console.WriteLine(a2);
            ++a2;//先加再用
            Console.WriteLine(a2);

            a2 = 1;
            Console.WriteLine(a2++);//1
            //2
            Console.WriteLine(++a2);//3

            //自减运算符 让自己-1
            a2 = 1;
            a2--;//先用再加
            --a2;//先加再用
            
            a2 = 1;
            Console.WriteLine(a2--);//1
            //0
            Console.WriteLine(--a2);//-1

            #endregion

            #region 练习题
            Console.WriteLine("练习题");
            int age = 18;
            age += 10;
            Console.WriteLine(age);

            float radius = 5;
            float PI = 3.1415926f;
            float area = radius * radius * PI;
            Console.WriteLine(area);
            float perimeter = radius * 2 * PI;
            Console.WriteLine(perimeter);

            int cs = 80;
            int unity = 90;
            int math = 60;
            int sum = cs + unity + math;
            Console.WriteLine(sum);
            float average = sum / 3f;
            Console.WriteLine(average);

            int tshirtPrice = 285;
            int pantsPrice = 720;
            int money = tshirtPrice * 2 + pantsPrice * 3;
            Console.WriteLine(money);
            float money1 = money * 3.8f / 10;
            Console.WriteLine(money1);

            a = 10;
            int b = 20; 
            int number1 = ++a + b; //31
            a = 10; 
            b = 20; 
            int number2 = a + b++; //30
            a = 10; 
            b = 20; 
            int number3 = a++ + ++b + a++;//42   10+21+11
            Console.WriteLine(number1 + " " + number2 + " " + number3);

            a = 99;
            b = 87;
            int c1 = a;
            a = b;
            b = c1;
            Console.WriteLine(a + " " + b);
            a = 99;
            b = 87;
            a = a + b;//a = 99 + 87
            b = a - b;//b = 99 + 87 - 87
            a = a - b;//a = 99 + 87 - 99
            Console.WriteLine(a + " " + b);

            int oneDayS = 60 * 60 * 24;
            int oneHourS = 60 * 60;
            int oneMinS = 60;
            // 算一天 用总的秒数 / 一天有多少秒
            int day = 987652 / oneDayS;
            // 算小时 用不足一天的秒 / 一小时对应的秒数
            // 987652 % oneDayS 余数结果 就是不足一天的秒数
            int hour = 987652 % oneDayS / oneHourS;
            // 算分钟 用不足一小时的秒数 / 一分钟对应的秒数
            // 987652 % oneHourS 余数结果 就是不足一小时的秒数
            int minute = 987652 % oneHourS / oneMinS;
            int second = 987652 % oneMinS;
            Console.WriteLine(day + "天" + hour + "小时" + minute + "分钟" + second + "秒");
            #endregion
        }
    }
}
