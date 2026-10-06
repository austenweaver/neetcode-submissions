public class MinStack {

    private List<int> _data;
    private List<int> _mins;

    public MinStack() {
        _data = new List<int>();
        _mins = new List<int>();
    }
    
    public void Push(int val) {
        _data.Add(val);
        if (_mins.Count == 0) {
            _mins.Add(val);
        }
        else {
            _mins.Add(Math.Min(val, _mins.Last()));
        }
    }
    
    public void Pop() {
        _data.RemoveAt(_data.Count - 1);
        _mins.RemoveAt(_mins.Count - 1);
    }
    
    public int Top() {
        return _data.Last();
    }
    
    public int GetMin() {
        return _mins.Last();
    }
}
