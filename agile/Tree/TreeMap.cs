using System;

namespace agile.Tree
{
    public class TreeMap<K, V> where K : IComparable<K>
    {
        private TreeMapNode<K, V> _topNode;
        public void Add(IComparable<K> key, V value)
        {
            if (_topNode == null)
                _topNode = new TreeMapNode<K, V>(key, value);
            else
                _topNode.Add(key, value);
        }
        public object Get(K key)
        {
            return _topNode == null ? (object) null : _topNode.Find(key);
        }
    }

    internal class TreeMapNode<K, V> where K : IComparable<K>
    {
        private static readonly int LESS = 0;
        private static readonly int GREATER = 1;
        private readonly IComparable<K> _key;
        private V _value;
        private readonly TreeMapNode<K, V>[] _nodes = new TreeMapNode<K, V>[2];
        public TreeMapNode(IComparable<K> key, V value)
        {
            _key = key;
            _value = value;
        }
        public V Find(IComparable<K> key)
        {
            if (key.CompareTo((K)_key) == 0) return _value;
            return (V) FindSubNodeForKey(SelectSubNode(key), key);
        }
        private int SelectSubNode(IComparable<K> key)
        {
            return (key.CompareTo((K)_key) < 0) ? LESS : GREATER;
        }
        private object FindSubNodeForKey(int node, IComparable<K> key)
        {
            return _nodes[node] == null ? (object) null : _nodes[node].Find(key);
        }
        public void Add(IComparable<K> key, V value)
        {
            if (key.CompareTo((K)_key) == 0)
                _value = value;
            else
                AddSubNode(SelectSubNode(key), key, value);
        }
        private void AddSubNode(int node, IComparable<K> key, V value)
        {
            if (_nodes[node] == null)
                _nodes[node] = new TreeMapNode<K, V>(key, value);
            else
                _nodes[node].Add(key, value);
        }
    }
}
