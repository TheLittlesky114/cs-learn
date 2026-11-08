using Microsoft.VisualBasic;

namespace Lesson4变量的命名规则
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 知识点一 必须遵守的命名规则
            //1.不能重名
            //2.不能以数字开头
            //3.不能使用程序关键字（例如int, string, class等）
            //4.不能使用特殊符号（除了下划线_）

            //建议的命名规则：变量名要有意义——>用英文（拼音）表示变量的作用
            //非常不建议使用中文命名变量 因为在不同的操作系统中 中文可能会出现乱码
            #endregion

            #region 知识点二 常用命名规则
            //1.驼峰命名法（变量）——>第一个单词首字母小写 后面每个单词首字母大写 例如：myVariableName

            //2.帕斯卡命名法（函数、类）——>每个单词首字母大写 例如：MyVariableName

            //潜在知识点——C#中对大小写是敏感的——>myVariableName和MyVariableName是两个不同的变量名
            #endregion

            #region 练习题
            //下面的变量名哪些是错误的？
            //U3d    对      No.1   错          3day    错
            //$money 错      discount_ 1  错    Shang Hai   错
            //class  错      int    错          _a_b_c_   对
            //Main   对      _ 2C   错          print   对


            //myAge  mySex  myHeight  myWeight  myAttackPower  myDefendPower

            #endregion
        }
    }
}
