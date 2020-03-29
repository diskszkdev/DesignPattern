using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryMethod
{
    public class ClassA
    {
        public void Print()
        {
            ITest obj = this.Create();
            string str = obj.GetMessage();
            Console.WriteLine(str);
        }

        public virtual ITest Create()
        {
            var classB = new ClassB();
            return classB;
        }
    }

    public class ClassAEx : ClassA
    {
        public override ITest Create()
        {
            var obj = new ClassC();
            return obj;
        }
    }

    public class ClassB : ITest
    {
        public string GetMessage()
        {
            return "apple";
        }
    }

    public class ClassC : ITest
    {
        public string GetMessage()
        {
            return "orange";
        }
    }

    public interface ITest
    {
        string GetMessage();
    }

}
