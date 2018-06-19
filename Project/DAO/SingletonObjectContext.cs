using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.DAO
{
    class SingletonObjectContext
    {
        private static readonly SingletonObjectContext instance = new SingletonObjectContext();
        private readonly ProjectRegister context;

        private SingletonObjectContext()
        {
            context = new ProjectRegister();
        }

        public static SingletonObjectContext Instance
        {
            get
            {
                return instance;
            }
        }

        public ProjectRegister Context
        {
            get
            {
                return context;
            }
        }
    }
}
