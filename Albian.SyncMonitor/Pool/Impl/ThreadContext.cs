using System.Collections;

namespace Albian.SyncMonitor.Pool.Impl
{
    public sealed class ThreadContext
    {
        private static Hashtable _data = Hashtable.Synchronized(new Hashtable());

        public static object GetData(string name)
        {
            return _data[name];
        }
        public static void SetData(string name, object value)
        {
            _data.Add(name, value);
        }
        public static void FreeNamedDataSlot(string name)
        {
            _data.Remove(name);
        }
        public static void FreeNamedDataSlot()
        {
            _data.Clear();
        }
    }
}