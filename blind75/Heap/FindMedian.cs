namespace Blind75.Heap;

public class MedianFinder
{
    private readonly PriorityQueue<int, int> _leftHeap = new(Comparer<int>.Create((a, b) => b - a));
    private readonly PriorityQueue<int, int> _rightHeap = new();

    // T: log(n)
    public void AddNum(int num)
    {
        if (_leftHeap.Count == 0 || num > _leftHeap.Peek())
            _rightHeap.Enqueue(num, num);
        else
            _leftHeap.Enqueue(num, num);

        Balance();
    }

    private void Balance()
    {
        (PriorityQueue<int, int> big, PriorityQueue<int, int> small) =
            _leftHeap.Count > _rightHeap.Count ? (_leftHeap, _rightHeap) : (_rightHeap, _leftHeap);

        while (big.Count - small.Count > 1)
        {
            int value = big.Dequeue();
            small.Enqueue(value, value);
        }
    }

    // T: O(1)
    public double FindMedian()
    {
        return _leftHeap.Count == _rightHeap.Count
            ? (_leftHeap.Peek() + _rightHeap.Peek()) / 2.0
            : _leftHeap.Count > _rightHeap.Count
                ? _leftHeap.Peek()
                : _rightHeap.Peek();
    }
}
