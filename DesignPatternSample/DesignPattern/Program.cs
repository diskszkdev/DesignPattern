using DesignPattern.AbstractFactory;
using DesignPattern.FactoryMethod;
using DesignPattern.Prototype;
using DesignPattern.Singleton;
using DesignPattern.Strategy;
using DesignPattern.TemplateMethod;
using System;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Template Methodパターン
            var templateMethod = new Employee(new ATest());
            templateMethod.Execute();

            // Strategyパターン
            var strategy = new Calc();
            var result = strategy.calc(new Add(), 100, 200);
            Console.WriteLine(result.ToString());
            result = strategy.calc(new Sub(), 500, 250);
            Console.WriteLine(result.ToString());

            //Factory Methodパターン
            var factoryMethod = new ClassA();
            factoryMethod.Print();
            var factoryMethod2 = new ClassAEx();
            factoryMethod2.Print();

            // Abstract Factoryパターン
            int dbType = 1;// 設定ファイルから読み込む
            DB1 db1;
            DB2 db2;
            DB3 db3;

            IFactory factory = Factory.GetFactory(dbType);
            db1 = factory.CreateDb1();
            db2 = factory.CreateDb2();
            db3 = factory.CreateDb3();


            // Singletonパターン
            var singleton = SingletonA.GetInstance();
            singleton.Message();
            var singleton2 = SingletonA.GetInstance();
            singleton2.Message();


            // Prototypeパターン
            var proto = new ProtoA();
            proto.v1 = 1;
            proto.v2 = 2;
            proto.v3 = 3;
            var proto2 = new ProtoB();
            proto2.v1 = "a";
            proto2.v2 = "b";
            proto2.v3 = "c";


            // 管理人に渡す
            var protoManager = PrototypeManager.GetInstance();
            protoManager.Add(nameof(ProtoA), proto);
            protoManager.Add(nameof(ProtoB), proto2);
            // 管理人から受け取る
            var obj = protoManager.Get(nameof(ProtoA));
            Console.WriteLine(obj.GetType().ToString());
            Console.WriteLine(obj.GetV1());






            Console.ReadKey();
        }
    }
}
