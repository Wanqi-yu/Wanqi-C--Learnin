using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Day1 安装环境 输出Hello World!
            Console.WriteLine("Hello World!");
            //Day2 数据类型与变量
            /*变量:一种用于存储数据的内存的名称,可以将其想象为一个盒子，盒子里面存放的物品就是变量里的值
             定义变量:在C#中定义变量时，要给出变量类型，变量名，但可以先不进行赋值
            变量名的要求
            1.变量名由字母，数字和下划线组成，但不能以数字开头
            2.不能使用C#中的关键字作为变量名
            3.变量名严格的区分大小写，User和user是两个不同的变量
            4.尽量使用描述性强的英语单词
            数据类型:在C#中，数据类型是编程的基础，用于定义变量和方法可以存储的数据种类。C#的数据类型分为两大类:值类型和引用类型，此外，C#还支持一些特殊
            的类型，如指针类型和可空类型
            值类型(Value Types):值类型直接存储数据值，存储在栈内存中，具有高性能的特点
             */
            //定义一个整数类型的变量
            int age = 25;
            //定义一个字符串类型的变量
            string name = "Wanqi.Yu";
            //定义一个浮点数类型变量 双精度浮点数 C#会将带小数点的数默认判定为double类型的浮点数，如果需要单精度浮点数，则需要在后面加f
            double height = 1.76;
            //输出这些变量 
            //字符串插值 在C#中，提供了可以直接在字符串中使用变量的方法，需要在字符串开头加一个美元符号，这样就可以在输出的字符串中直接使用变量
            Console.WriteLine($"My name is {name},I'm {age} years old,My height is {height}");
            float weight = 85.5f;
        }
    }
}
