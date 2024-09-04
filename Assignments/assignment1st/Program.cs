using System;
using DataType;

class Assignment1{
    public static void Main(){
            _INT a = new _INT(10);
            _INT b = new _INT(20);
            Console.WriteLine(a.division(a,b));
            Console.WriteLine(a.addition(a,b));
            Console.WriteLine(b.subtraction(a,b));

            _FLOAT c = new _FLOAT(10);
            _FLOAT d = new _FLOAT(20);
            Console.WriteLine(c.division(a,b));
            Console.WriteLine(c.addition(a,b));
            Console.WriteLine(d.subtraction(a,b));
        }
}