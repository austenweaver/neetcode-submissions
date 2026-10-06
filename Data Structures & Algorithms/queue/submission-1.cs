class Deque {

    private ListNode head;
    private ListNode tail;

    public Deque() {
        
    }

    public bool isEmpty() {
        return head == null && tail == null;
    }

    public void append(int value) {

        if (isEmpty()) {
            head = new ListNode(value);
            tail = head;
        }

        else {
            tail.next = new ListNode(value);
            tail.next.prev = tail;
            tail = tail.next;
        }
    }

    public void appendleft(int value) {

        if (isEmpty()) {
            head = new ListNode(value);
            tail = head;
            return;
        }

        head.prev = new ListNode(value);
        head.prev.next = head;
        head = head.prev;
    }

    public int pop() {

        if (isEmpty()) {
            return -1;
        }

        int val = tail.val;

        if (head == tail) {
            head = null;
            tail = null;
        }

        else {
            tail = tail.prev;
            tail.next = null;
        }
        
        return val;
    }

    public int popleft() {

        if (isEmpty()) {
            return -1;
        }

        int val = head.val;

        if (head == tail) {
            head = null;
            tail = null;
        }

        else {
            head = head.next;
            head.prev = null;
        }
        
        return val;
    }

    class ListNode {
        public int val;
        public ListNode next;
        public ListNode prev;

        public ListNode(int val) {
            this.val = val;
        }
    }
}
