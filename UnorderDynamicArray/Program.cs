using System;
using DynamicArray;

class Program{
    public static void Main(String[] args){
        UnorderIntDynamicArray arr = new UnorderIntDynamicArray();
 
        arr.Add(20);
        arr.Add(70);
        arr.Add(60);
        arr.Add(46);

        arr.Remove(60);

        Console.WriteLine(arr.ToString());
    }
}