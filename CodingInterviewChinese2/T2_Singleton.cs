using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterviewChinese2
{
    /// <summary>
    /// 没有考虑多线程
    /// </summary>
    public sealed class T2_Singleton1
    {
        private T2_Singleton1()
        {
        }
        private static T2_Singleton1 instance = null;
        public static T2_Singleton1 Instance
        {
            get
            {
                if (instance == null)
                    instance = new T2_Singleton1();

                return instance;
            }
        }
    }

    /// <summary>
    /// Lock保证一个时刻只能有一个线程得到同步锁
    /// 考虑了多线程但是效率低
    /// </summary>
    public sealed class T2_Singleton2
    {
        private T2_Singleton2()
        {
        }

        private static readonly object obj = new object();
        private static T2_Singleton2 instance = null;
        public static T2_Singleton2 Instance
        {
            get
            {
                lock (obj)
                {
                    if (instance == null)
                        instance = new T2_Singleton2();

                }
                return instance;
            }
        }
    }
    /// <summary>
    /// 每次都加同步锁比较耗时，所以通过if 语句保证只有没有创建的实例的情况下才加锁
    /// </summary>
    public sealed class T2_Singleton3
    {
        private T2_Singleton3()
        {
        }

        private static readonly object obj = new object();
        private static T2_Singleton3 instance = null;
        public static T2_Singleton3 Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (obj)
                    {
                        if (instance == null)
                            instance = new T2_Singleton3();

                    }
                }
                return instance;
            }
        }
    }

    /// <summary>
    /// 静态构造函数由.Net运行时调用，能保证只调用一次
    /// 虽然没有显示的静态构造函数，但是初始化静态字段时，会调用静态构造函数
    /// 会出现过早调用静态构造函数的情况
    /// </summary>
    public sealed class T2_Singleton4    
    {
        private T2_Singleton4()
        {
        }

        private static T2_Singleton4 _instance = new T2_Singleton4(); 
        public static T2_Singleton4 Instance
        {
            get
            {
                return _instance;
            }
        }
    }

    /// <summary>
    /// 只有在第一次调用Instance时才会触发Nested的静态构造函数初始化instance，避免过早构造的问题
    /// </summary>
    public sealed class T2_Singleton5
    {
        private T2_Singleton5()
        {
        }

        public static T2_Singleton5 Instance
        {
            get
            {
                return Nested.instance;
            }
        }

        class Nested
        {
            static Nested()
            {
            }

            internal static readonly T2_Singleton5 instance = new T2_Singleton5();
        }
    }

    //public sealed class Singleton { 
    //    private Singleton()
    //    {
    //    }

    //    //private static Singleton _instance = null;
    //    //private static readonly object o = new object();

    //    //public static Singleton Instance { 
    //    //    get 
    //    //    { 
    //    //        if(_instance == null)
    //    //        {
    //    //            lock (o)
    //    //            {
    //    //                if (_instance == null)
    //    //                    _instance = new Singleton();
    //    //            }
    //    //        }
    //    //        return _instance;
    //    //    } 
    //    //}

    //    //private static Singleton _instance = new Singleton();
    //    //public static Singleton Instance
    //    //{
    //    //    get
    //    //    {
    //    //        return _instance;
    //    //    }
    //    //}

    //    public static Singleton Instance
    //    {
    //        get
    //        {
    //            return Nested.Instance;
    //        }
    //    }

    //    class Nested
    //    {
    //        internal static readonly Singleton Instance = new Singleton();
    //    }
    //}
}
