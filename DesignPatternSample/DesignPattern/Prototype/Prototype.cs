using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Prototype
{
    public class ProtoA:IProto
    {
        public int v1 = 0;
        public int v2 = 0;
        public int v3 = 0;


        public string GetV1()
        {
            return v1.ToString();
        }

        public IProto Clone()
        {
            //　参照ではなく、コピーを作成する
            return (ProtoA)this.MemberwiseClone();
        }
    }

    public class ProtoB : IProto
    {
        public string v1 = "";
        public string v2 ="";
        public string v3 = "";

        public string GetV1()
        {
            return v1;
        }

        public IProto Clone()
        {
            //　参照ではなく、コピーを作成する
            return (ProtoB)this.MemberwiseClone();
        }
    }

    public interface IProto
    {
        string GetV1();
        IProto Clone();
    }

    public class PrototypeManager
    {
        private Dictionary<string, IProto> _dict = new Dictionary<string, IProto>();

        private static PrototypeManager _proto;

        public static PrototypeManager GetInstance()
        {
            if(_proto == null)
            {
                _proto = new PrototypeManager();
                return _proto;
            }

            return _proto;
        }

        public void Add(string name,IProto proto)
        {
            _dict.Add(name,proto);
        }

        public IProto Get(string name)
        {
            return _dict.GetValueOrDefault(name);
        }
    }
}
