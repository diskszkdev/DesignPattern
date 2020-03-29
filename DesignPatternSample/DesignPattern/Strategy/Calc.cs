using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Strategy
{
    public interface ICalc
    {
        int calc(int a, int b);
    }

    /// <summary>
    /// ソフトウェア１
    /// </summary>
    public class Add : ICalc
    {
        public int calc(int a, int b)
        {
            return a + b;
        }
    }

    /// <summary>
    /// ソフトウェア２
    /// </summary>
    public class Sub : ICalc
    {
        public int calc(int a, int b)
        {
            return a - b;
        }
    }


    /// <summary>
    /// ハードウェア
    /// </summary>
    public class Calc
    {
        public int calc(ICalc obj, int a, int b)
        {
            return obj.calc(a, b);
        }
    }
}
