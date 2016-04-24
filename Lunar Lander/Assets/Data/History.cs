namespace Assets.Data {
    public class History<T> : IHistory<T> {
        private readonly System.Collections.Generic.Stack<T> _items = new System.Collections.Generic.Stack<T>();

        public void AddHistory(T item) {  }
        public void ClearHistory() { this._items.Clear(); }
    }
}
