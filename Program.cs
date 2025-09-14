using System;

namespace abstratction
{ 
    class example
    {

    }
    interface i1
    {

    }
    interface i2
    {

    }
    interface myinterface:i1, i2 // Interface can inherit a multiple interfaces but cannot inherit a class.
    {
        //myinterface()  //An interface cannot declare constructor and destructor.
        //{

        //}
        void print();
        
    }
    abstract class myclass : example, i1, i2 // Abstract class can inherit a class and a multiple interfaces.
    {
        public abstract void show();
        public myclass()  //Abstractv contain constructor and destructor.
        {
            Console.WriteLine("Abstract Class Constructor");
        }
        ~myclass()
        {
            Console.WriteLine("Abstract class destructor");
        }
        
    }
    class myclass1:myclass,myinterface
    {
        public override void show() //An abstract class method is implemented using the override keyboard.
        {
            Console.WriteLine("An abstract class method is implemented using override keyword");
        }
        public void print()  //An interface  method is implemented without using the override keyboard.
        {
            Console.WriteLine("An interface method is implemented withiut using override keyword");
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            myclass1 obj = new myclass1();
            obj = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Console.WriteLine("End of Main()");
        }
    }
}