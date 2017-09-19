using System;
namespace SingletonThreaded
{
    public class SingletonThreadedEarlyInitilization
    {
        private static readonly SingletonThreadedEarlyInitilization instance = new SingletonThreadedEarlyInitilization();
        private  SingletonThreadedEarlyInitilization() {}

        public static SingletonThreadedEarlyInitilization GetInstance {

            get { return instance; }
        }
      
    }
}
