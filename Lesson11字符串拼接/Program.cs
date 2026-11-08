namespace Lesson11字符串拼接
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 知识点一 字符串拼接方式1
            //之前的算数运算符 只是用来数值类型变量进行数学运算的
            //而 string 不存在算数运算符不能计算 但是可以通过+号来进行字符串拼接
            string str = "123";
            //用+号进行字符串拼接
            str = str + "456";
            Console.WriteLine(str);
            str = str + 1;
            Console.WriteLine(str);

            // 复合运算符 +=
            str = "123";
            str += "1" + 4 + true;
            Console.WriteLine(str);

            str += 1 + 2 + 3 + 4;
            Console.WriteLine(str);

            str += "" + 1 + 2 + 3 + 4;
            Console.WriteLine(str);

            str = "";
            str += 1 + 2 + "" + (3 + 4);
            Console.WriteLine(str);

            str = "123";
            str = str + (1 + 2 + 3);
            Console.WriteLine(str);

            //注意：用+号拼接 是用符号唯一方法 不能用-/*%......
            #endregion

            #region 知识点二 字符串拼接方式2
            //固定语法
            //string.Format("待拼接的内容",内容1,内容2,......);
            //拼接内容中的固定规则
            //想要被拼接的内容用占位符替代{数字} 数字：0~n 依次往后

            string str2 = string.Format("我是{0},我今年{1}岁,我想要{2}","张三",18,"一本书");
            Console.WriteLine(str2);

            str2 = string.Format("wqwqwqwqw{0}zxzxzxzx{1}212121212{2}",1,true,false);
            Console.WriteLine(str2);

            #endregion

            #region 知识点三 控制台打印拼接
            //后面的 内容 比占位符多 不会报错 但是不会打印出来
            //后面的 内容 比占位符少 会报错
            Console.WriteLine("A{0}B{1}C{2}", "张三", 18, "一本书",1,2);
            Console.Write("A{0}B{1}C{2}", "张三", 18, "一本书");
            #endregion

            #region 练习题
            Console.WriteLine();
            Console.WriteLine("*****************************");
            string name = "张三";
            Console.WriteLine("你好，" + name);

            name = "李四";
            sbyte age = 18;
            Console.WriteLine(name + age + "岁了");
            
            name = "王五";
            age = 18;
            string email = "1145141919@qq.com";
            string address = "北京市朝阳区";
            int salary = 1000000;
            Console.WriteLine("姓名：" + name + "，年龄：" + age + "，邮箱：" + email + "，家庭住址：" + address + "，期望工资：" + salary);

            Console.Write("请输入姓名：");
            name = Console.ReadLine();
            Console.Write("请输入年龄：");
            age = sbyte.Parse(Console.ReadLine());
            Console.Write("请输入班级：");
            string className = Console.ReadLine();
            Console.WriteLine("{0}{1}{2}",name,age,className);
            #endregion

        }
    }
}
;