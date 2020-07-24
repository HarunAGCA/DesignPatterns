using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = Manager.CreateAsSingleton();
            manager.TestAction();
                
        }
    }

    class Manager
    {
        private static Manager _manager;
        private static object _lockObject = new object();

        private Manager()
        {

        }

        /// <summary>
        /// Creates thread safe singleton instance
        /// </summary>
        /// <returns>Manager</returns>
        public static Manager CreateAsSingleton()
        {
            lock (_lockObject)  //lock for thread safing

            {
                if (_manager == null)
                {
                    _manager = new Manager();
                }
            }

            return _manager;
        }
        /// <summary>
        /// Represents any action. Created for testing purpose.
        /// </summary>
        public void TestAction()
        {
            Console.WriteLine("Test action ran.");
        }
    }
}
