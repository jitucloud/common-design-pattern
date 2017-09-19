using System;
namespace SingletonThreaded
{
    public class SingletonThreadedLazyInitialization
    {
        private static volatile SingletonThreadedLazyInitialization instance;
        private static readonly object _lockthis = new object();
        private SingletonThreadedLazyInitialization() { }

		//https://www.codeproject.com/Articles/1178694/Singleton-and-Multiton-Pattern

		public static SingletonThreadedLazyInitialization GetInstance()
        {
            if (instance == null)
            {

                lock(_lockthis)
                {
                    if (instance == null)
                    {
                        instance = new SingletonThreadedLazyInitialization();
                    }

                }
            }
            return instance;
        }
    }
}
