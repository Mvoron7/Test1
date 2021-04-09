namespace System.Collections.Generic.Circular {
    public interface ICircularList<T> :IList<T> {
        void MoveNext();
        void MoveBack();
        T Current { get; }
        T Previous { get; }
        T Next { get; }
    }
}
