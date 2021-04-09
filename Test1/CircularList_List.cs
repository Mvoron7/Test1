namespace System.Collections.Generic.Circular {

    public partial class CircularList<T> :ICircularList<T> {

        public T this[int index] {
            get => list[index];
            set => list[index] = value;
        }

        public int Count => list.Count;

        public bool IsReadOnly => ((IList)list).IsReadOnly;

        public void Add(T item) {
            list.Add(item);
        }

        public void Clear() {
            list.Clear();
        }

        public bool Contains(T item) {
            return list.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex) {
            list.CopyTo(array, arrayIndex);
        }

        public IEnumerator<T> GetEnumerator() {
            return list.GetEnumerator();
        }

        public int IndexOf(T item) {
            return list.IndexOf(item);
        }

        public void Insert(int index, T item) {
            list.Insert(index, item);
        }

        public bool Remove(T item) {
            return list.Remove(item);
        }

        public void RemoveAt(int index) {
            list.RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return list.GetEnumerator();
        }
    }
}
