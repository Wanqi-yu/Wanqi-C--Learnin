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
             */
            /*
            
            数据类型:指变量可以存储的数据的类型,在C#中，数据类型分为以下几种
            1.值类型(Values types):值类型变量可以直接分配给一个值，他们是从类Syestem.ValueType派生的类型，
            值类型变量直接存储数据本身，常见的值类型有整数类型(int, long, short等)、浮点数类型(float, double等)、字符类型(char)和布尔类型(bool)等
            如果想要获得一个类型或一个变量准确尺寸，可以使用sizeof运算符来获取该类型的字节大小
            如果相应确认一个变量的数据类型，可以使用GetType方法来获取
            2.引用类型(Reference types):引用类型变量存储的是对数据的引用，而不是数据本身，引用类型变量是从类System.Object派生的类型，
            换句话说，引用类型变量存储的是数据在内存中的地址，而不是数据本身的值，使用多个变量时，多个变量可以引用同一个对象，
            这样就可以在多个地方访问和修改同一个对象的值
            C#常见的引用类型有字符串(string)、数组(array)和类(class)等
            对象类型(Object)Object类型是C#中所有类型的基类，所有类型都可以被视为Object类型
            3.动态类型(Dynamic types):动态类型是C#中的一种特殊类型，它允许在运行时动态地确定变量的类型，
            声明动态类型变量时，可以使用关键字dynamic，动态类型变量可以存储任何类型的值，并且在运行时可以改变其类型
            字符串类型(String):字符串类型是C#中用于存储文本数据的类型，字符串是不可变的，一旦创建就不能修改，
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
            //Day3 运算符与表达式
            /*运算符:运算符是用于执行特定操作的符号或关键字，C#中有多种类型的运算符，包括算术运算符、关系运算符、逻辑运算符等
             算术运算符:用于执行基本的数学运算，如加法、减法、乘法和除法等
             关系运算符:用于比较两个值之间的关系，如大于、小于、等于等
             逻辑运算符:用于执行逻辑操作，如与、或、非等
             */
            //定义两个整数变量
            int a = 10;
            int b = 5;
            //算术运算符
            int sum = a + b; //加法
            int difference = a - b; //减法
            int product = a * b; //乘法
            int quotient = a / b; //除法
            int remainder = a % b; //取余
            //输出结果 使用字符串插值输出结果
            Console.WriteLine($"Sum:{sum}, Difference:{difference}, Product:{product}, Quotient:{quotient}, Remainder:{remainder}");
            //关系运算符
            bool isEqual = (a == b); //等于
            bool isNotEqual = (a != b); //不等于
            bool isGreater = (a > b); //大于
            bool isLess = (a < b); //小于
            bool isGreaterOrEqual = (a >= b); //大于等于
            bool isLessOrEqual = (a <= b); //小于等于
            //输出关系运算符结果
            Console.WriteLine($"Is Equal:{isEqual}, Is Not Equal:{isNotEqual}, Is Greater:{isGreater}, Is Less:{isLess}, Is Greater Or Equal:{isGreaterOrEqual}, Is Less Or Equal:{isLessOrEqual}");
            //逻辑运算符
            bool andResult = (a > 0 && b > 0); //与运算
            Console.WriteLine($"And Result: {andResult}");
            bool orResult = (a > 0 || b < 0); //或运算
            Console.WriteLine(a > 0 || b < 0 ? "Or Result: True" : "Or Result: False");
            bool notResult = !(a < b); //非运算
            Console.WriteLine(a < b ? "Not Result: False" : "Not Result: True");
            //Daty4 if条件语句
            /*在编程中，条件判断语句是控制程序流程的关键部分，它允许程序根据不同的条件执行不同的代码块，其中if语句是最常用的条件判断语句之一*/
            /*if语句，是C#中用于执行条件判断的语句，它允许程序根据条件的真假来决定是否执行某些代码块，
             一个if语句通常由一个条件表达式和一个代码块组成，当条件表达式为true时，代码块中的代码将被执行
             基本语法格式如下
            if (condition)
            {
                // 当条件为true时执行的代码块
            }
            下面是一个简单的if语句示例
             */
            int number = 10;
            if (number > 0)
            {
                Console.WriteLine("Number is positive.");
            }
            //else语句,else语句是if语句的一个扩展，它允许程序在条件不满足时执行另一段代码块，
            //else语句通常与if语句一起使用，用于处理条件不满足的情况，基本语法格式如下
            /*if (condition)
            {
                // 当条件为true时执行的代码块
            }
            else
            {
                // 当条件为false时执行的代码块
            }*/
            if (number < 0)
            {
                Console.WriteLine("Number is negative.");
            }
            else
            {
                Console.WriteLine("Number is non-negative.");
            }
            //else if语句,else if语句是if语句的一个扩展，它允许程序在多个条件之间进行选择，
            //当有多个条件需要判断时，可以使用else if语句来处理不同的情况，基本语法格式如下
            /*if (condition1)
            {
                // 当条件1为true时执行的代码块
            }
            else if (condition2)
            {
                // 当条件2为true时执行的代码块
            }
            else
            {
                // 当所有条件都不满足时执行的代码块
            }*/
            if (number > 0)
            {
                Console.WriteLine("Number is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine("Number is negative.");
            }
            else
            {
                Console.WriteLine("Number is zero.");
            }
            //嵌套if语句,嵌套if语句是指在一个if语句的代码块中再包含另一个if语句，这种结构允许程序在满足某个条件时进一步判断其他条件，
            //基本语法格式如下
            bool isEven = true; // 

            if (number > 0)
                { 
                    if (isEven)
                    {
                        Console.WriteLine("Number is positive and even.");
                    }
                    else
                    {
                        Console.WriteLine("Number is positive and odd.");
                }
                //使用逻辑运算符,在C#中，可以使用逻辑运算符来组合多个条件，从而实现更复杂的条件判断，
                //逻辑运算符包括与（&&）、或（||）和非（!）等，
                //与运算符（&&）用于判断多个条件是否同时为true，
                //如果所有条件都为true，则整个表达式为true，否则为false，
                //或运算符（||）用于判断多个条件中是否至少有一个为true，
                //如果至少有一个条件为true，则整个表达式为true，否则为false，
                //非运算符（!）用于对条件进行取反操作，如果条件为true，则取反后为false，反之亦然
                //使用逻辑运算符进行条件判断
                if (number > 0 && isEven)
                {
                    Console.WriteLine("Number is positive and even.");
                }
                else if (number > 0 && !isEven)
                {
                    Console.WriteLine("Number is positive and odd.");
                }
                else if (number < 0 || number == 0)
                {
                    Console.WriteLine("Number is negative or zero.");
                }
                //Day 5 Switch语句
                /*
                 在C#中，Switch语句是一种根据不同的条件执行不同代码块的控制流结构，它允许程序根据一个表达式的值，
                选择执行与该值相关联的特定代码块
                基本语法如下
                Switch (表达式)
                {
                    case value1
                    //代码块
                        break
                    case value2
                    //代码块
                        break
                    default
                        //默认代码块
                        break
                }
                 */
            }
        }
    }
}
