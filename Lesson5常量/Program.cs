namespace Lesson5常量
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 知识点一 常量的申明
            //关键字 const
            //固定写法：
            //const 变量类型 变量名 = 初始值;
            //变量的申明
            int i = 0;
            //常量的申明
            const int j = 0;
            #endregion

            #region 知识点二 常量的特点
            // 1.必须初始化
            // 2.不能被修改

            //变量申明可以不初始化
            string name;
            //之后可以修改
            name = "张三";
            name = "李四";

            const string myName = "张三";

            //作用：申明一些常用不变的变量

            //PI 3.1415926
            const float PI = 3.1415926f;
            Console.WriteLine(PI);

            #endregion

            #region 练习题
            //常量有什么特点？
            // 1.必须初始化
            // 2.不能被修改
            // 3.常量的申明 就是申明变量的时候 前面加上const关键字
            // const int i = 1;

            //之后 讲解了静态关键字后 static 会回过头来 讲解常量的特点



            //请简述你觉得在游戏开发中常量的作用
            // 常量是用来申明一些游戏当中不会变化的变量的
            // 例如  PI  角度转弧度  弧度转角度  重力加速度
            // 一些数学定理或者公理性质变量 用来参与计算的变量

            // 如果你的游戏比较特别 玩家的最大血量 是不变
            #endregion
        }
    }
}
