namespace System.Collections.Generic.Circular {

    public partial class CircularList<T> :ICircularList<T> {

        private int currentPosition;

        private readonly List<T> list;

        public CircularList() {
            currentPosition = 0;
            list = new List<T>();
        }

        public T Current => list[currentPosition];

        public T Previous => list[CheckPosition(currentPosition - 1)];

        public T Next => list[CheckPosition(currentPosition + 1)];

        public void MoveBack() {
            currentPosition = CheckPosition(currentPosition - 1);
        }

        public void MoveNext() {
            currentPosition = CheckPosition(currentPosition + 1);
        }

        private int CheckPosition(int v) {
            if (v < 0) {
                return list.Count - 1;
            } else if (v >= list.Count) {
                return 0;
            } else {
                return v;
            }
        }
    }
}
