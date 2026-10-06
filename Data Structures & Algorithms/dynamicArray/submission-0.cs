public class DynamicArray {
    
    private int[] _data;
    private int _size;
    private int _end;

    public DynamicArray(int capacity) {
        _data = new int[capacity];
        _size = capacity;
        _end = 0;
    }

    public int Get(int i) {
        return _data[i];
    }

    public void Set(int i, int n) {
        _data[i] = n;
    }

    public void PushBack(int n) {
        if (_end == _size) {
            Resize();
        }

        _data[_end] = n;
        _end++;
    }

    public int PopBack() {
        _end--;
        return _data[_end];
    }

    private void Resize() {
        int[] newArray = new int[_size * 2];
        for (int i = 0; i < _size; i++) {
            newArray[i] = _data[i];
        }
        _data = newArray;
        _size *= 2;
    }

    public int GetSize() {
        return _end;
    }

    public int GetCapacity() {
        return _size;
    }
}
