namespace Singleton;
public static class SingletonProvider<TInstance> where TInstance : class, new()
{
    private static  TInstance? instance;
    private static readonly object @lock = new();
    public static TInstance Instance
    {
        get
        {
            if (instance == null)
            {
                lock (@lock)
                {
                    instance ??= new TInstance();
                }
            }

            return instance;
        }
    }
    static SingletonProvider()
    {

    }
}