using System;

namespace InterfaceSealed
{
    //ISum, IDifference, IMultiply, IDivide interface-leri olsun
    //Calculator.cs olsun 4 interface-in methodlarin implement etsin.

    class Program
    {
        static void Main(string[] args)
        {
            #region Interface

            //Car c = new Car();
            //Person p = new Person();
            //Print(c);
            //Print(p);

            //IMoveable obj = new IMoveable();

            #endregion

            #region Sealed

            //string word = "";

            //instance almaq
            //Engineer e = new Engineer();
            SoftwareDeveloper sd = new SoftwareDeveloper();
            sd.Knowledge();

            #endregion
        }

        #region Interface

        static void Print(IMoveable obj)
        {
            Console.WriteLine("Hello");
            obj.Move();
            obj.Print();
        }

        //static void Print(Car c)
        //{
        //    Console.WriteLine("Hello");
        //    c.Move();
        //}

        //static void Print(Person p)
        //{
        //    Console.WriteLine("Hello");
        //    p.Move();
        //}

        #endregion
    }

    #region Interface

    //Interface-ler multiple inheritance(implement) olur
    //Instance almaq olmur
    //C# 8.0-e kimi interfacelerde access modifier olmurdu ve bodysi olan method olmurdu.
    interface IMoveable
    {
        void Move();

        public void Print()
        {
            Console.WriteLine("Print");
        }
    }

    interface IPower
    {
        void Power();
    }

    public class Test
    {

    }

    public class Test1
    {

    }

    public class Car : Test, IMoveable, IPower
    {
        public void Move()
        {
            Console.WriteLine("Move as Car");
        }

        public void Power()
        {
            throw new NotImplementedException();
        }
    }

    //public class Person : IMoveable
    //{
    //    public void Move()
    //    {
    //        Console.WriteLine("Move as Person");
    //    }
    //}

    #endregion

    #region Sealed

    abstract class Person
    {
        public abstract void Knowledge();
        //public virtual void Knowledge()
        //{
        //    Console.WriteLine("Knowledge as Person");
        //} 
    }

    abstract class Engineer : Person
    {
        public override void Knowledge()
        {
            Console.WriteLine("Knowledge as Engineer");
        }
    }

    class SoftwareDeveloper : Engineer
    {
        public sealed override void Knowledge()
        {
            Console.WriteLine("Knowledge as SoftwareDeveloper");
        }

        public virtual void Print()
        {

        }
    }

    sealed class BackendDeveloper : Engineer
    {
        public void Develop()
        {
            Console.WriteLine("Develop");
        }
    }

    class Developer : SoftwareDeveloper
    {
        //public override void Knowledge()
        //{
        //    Console.WriteLine("Knowledge as Developer");
        //}

        public override void Print()
        {
            base.Print();
        }
    }

    #endregion
}
