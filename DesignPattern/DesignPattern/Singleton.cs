using System;

namespace DesignPattern
{
    sealed class Singleton
    {
        private static Singleton _instance;
        public string StrName = "";

        public static Singleton Instance()
        {
            return _instance ?? (_instance = new Singleton());
        }
    }
}
