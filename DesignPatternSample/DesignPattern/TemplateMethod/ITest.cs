using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.TemplateMethod
{
    // 処理の流れの形式化
    interface ITest
    {
        void Start();
        void MainLogic();
        void End();
    }

    public class ATest : ITest
    {
        public void Start()
        {
            Console.WriteLine("Start!!");
        }

        public void MainLogic()
        {
            Console.WriteLine("Main!!");
        }
        public void End()
        {
            Console.WriteLine("End!!");
        }
    }

    public class Employee
    {
        ATest _aTest = null;

        public Employee(ATest aTest)
        {
            _aTest = aTest;
        }

        public void Execute()
        {
            _aTest.Start();
            _aTest.MainLogic();
            _aTest.End();
        }
    }
}
