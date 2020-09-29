using System;

namespace Library
{
    public class Singleton<T> where T: new()
    {

        private static Greeter instance;

        public static Greeter Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Greeter();
                }

                return instance;
            }
        }
    }
}