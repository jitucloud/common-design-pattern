using System;

namespace SingletonThreaded
{

    public class SingletonNotThreaded
    {
        private static SingletonNotThreaded instance;

        private SingletonNotThreaded(){}

        public static SingletonNotThreaded GetInstance()
        {
			// Below line is not safe for multi threaded environment where two threads are simultaebluly on below line
			// https://www.codeproject.com/Articles/1178694/Singleton-and-Multiton-Pattern
			if(instance == null)
            {
                instance = new SingletonNotThreaded();
            }
            return instance;
        }

	 
    }
}
