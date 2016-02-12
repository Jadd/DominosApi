namespace DominosApi.Runtime {
    public static class Singleton<T> where T : new() {

        public static readonly T Instance;

        static Singleton() {
            Instance = new T();
        }

    }
}
