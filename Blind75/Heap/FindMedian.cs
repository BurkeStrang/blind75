namespace Blind75.Heap;

public class MedianFinder
{
    private readonly PriorityQueue<int, int> _maxHeap = new(Comparer<int>.Create((a, b) => b - a));
    private readonly PriorityQueue<int, int> _minHeap = new();

    public void AddNum(int num)
    {
        if (_maxHeap.Count == 0 || num < _maxHeap.Peek())
            _maxHeap.Enqueue(num, num);
        else
            _minHeap.Enqueue(num, num);

        BalanceHeaps();
    }

    private void BalanceHeaps()
    {
        PriorityQueue<int, int> biggerHeap = _maxHeap.Count > _minHeap.Count ? _maxHeap : _minHeap;
        PriorityQueue<int, int> smallerHeap = _maxHeap.Count > _minHeap.Count ? _minHeap : _maxHeap;

        if (biggerHeap.Count - smallerHeap.Count > 1)
        {
            int value = biggerHeap.Dequeue();
            smallerHeap.Enqueue(value, value);
        }
    }

    public double FindMedian()
    {
        if (_maxHeap.Count > _minHeap.Count)
        {
            return _maxHeap.Peek();
        }
        else if(_maxHeap.Count < _minHeap.Count)
        {
            return _minHeap.Peek();
        }
        return (_maxHeap.Peek() + _minHeap.Peek()) / 2.0;
    }
}
