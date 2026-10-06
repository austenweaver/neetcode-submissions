public class ListNode {
    public int _val;
    public ListNode? _next;
    public ListNode(int val) {
        _val = val;
        _next = null;
    }
}

public class LinkedList {

    private ListNode? _head;
    private int _length;

    public LinkedList() {
        _head = null;
        _length = 0;
    }

    public int Get(int index) {

        if (index >= _length) {
            return -1;
        }

        ListNode? curr = _head;
        for (int i = 0; i < index; i++) {
            curr = curr._next;
        }

        return curr._val;
    }

    public void InsertHead(int val) {

        ListNode? oldHead = _head;
        _head = new ListNode(val);
        _head._next = oldHead;
        _length++;
    }

    public void InsertTail(int val) {
        
        if (_length == 0) {
            _head = new ListNode(val);
        }

        else {
            ListNode? curr = _head;

            while (curr._next != null) {
                curr = curr._next;
            }

            curr._next = new ListNode(val);
        }
        _length++;
        return;
    }

    public bool Remove(int index) {

        if (index >= _length) {
            return false;
        }

        if (index == 0) {
            _head = _head._next;
            _length--;
            return true;
        }

        ListNode? curr = _head;

        for (int i = 0; i < index - 1; i++) {
            curr = curr._next;
        }

        curr._next = curr._next._next;

        _length--;
        return true;
    }

    public List<int> GetValues() {
        List<int> vals = new List<int>();


        ListNode? curr = _head;

        while (curr != null) {
            vals.Add(curr._val);
            curr = curr._next;
        }

        return vals;
    }
}