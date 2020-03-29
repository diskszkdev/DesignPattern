using System;

namespace DesignPattern.Singleton
{
    public class SingletonA
    {
        private int count = 0;
        private static SingletonA _singletonA;

        public static SingletonA GetInstance()
        {
            if (_singletonA == null)
            {
                _singletonA = new SingletonA();
                return _singletonA;
            }
            return _singletonA;
        }

        public void Message()
        {
            count++;
            Console.WriteLine($"Hello World!!{count}回目");
        }
    }
}
