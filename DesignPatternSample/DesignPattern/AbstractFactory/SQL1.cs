using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbstractFactory
{
    public class MySQL1 : DB1 { }
    public class MySQL2 : DB2 { }
    public class MySQL3 : DB3 { }
    public class Oracle1 : DB1 { }
    public class Oracle2 : DB2 { }
    public class Oracle3 : DB3 { }
    public interface DB1 { }
    public interface DB2 { }
    public interface DB3 { }


    public interface IFactory
    {
        DB1 CreateDb1();
        DB2 CreateDb2();
        DB3 CreateDb3();

    }

    public class MySQLFactory : IFactory
    {
        public DB1 CreateDb1()
        {
            return new MySQL1();
        }

        public DB2 CreateDb2()
        {
            return new MySQL2();
        }

        public DB3 CreateDb3()
        {
            return new MySQL3();
        }
    }

    public class OracleFactory : IFactory
    {
        public DB1 CreateDb1()
        {
            return new Oracle1();
        }

        public DB2 CreateDb2()
        {
            return new Oracle2();
        }

        public DB3 CreateDb3()
        {
            return new Oracle3();
        }
    }

    public class Factory
    {
        public static IFactory GetFactory(int dbType)
        {
            if (dbType == 1)
            {
                return new MySQLFactory();
            }
            else
            {
                return new OracleFactory();
            }
        }
    }
}
