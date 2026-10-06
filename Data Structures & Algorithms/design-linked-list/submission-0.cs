public class MyLinkedList {

    ListNode head;
    ListNode tail;
    int size;

    public MyLinkedList() {
        size = 0;
    }
    
    public int Get(int index) {
        Console.WriteLine("Get");
        
        if (index >= size) {
            return -1;
        }

        if (index > size/2) {

            ListNode curr = tail;
            for (int i = 0; i < size - index - 1; i++) {
                curr = curr.prev;
            }
            return curr.val;
        }

        else {
            ListNode curr = head;
            for (int i = 0; i < index; i++) {
                curr = curr.next;
            }

            return curr.val;

        }
    }
    
    public void AddAtHead(int val) {
        Console.WriteLine("AddAtHead");

        ListNode newHead = new ListNode(val);

        if (size == 0) {
            head = newHead;
            tail = newHead;
        }
        else {
            newHead.next = head;
            head.prev = newHead;
            head = newHead;
        }
        
        size++;
    }
    
    public void AddAtTail(int val) {
        Console.WriteLine("AddAtTail");

        ListNode newTail = new ListNode(val);

        if (size == 0) {
            head = newTail;
            tail = newTail;
        }

        newTail.prev = tail;
        tail.next = newTail;
        tail = newTail;
        size++;
    }
    
    public void AddAtIndex(int index, int val) {

        Console.WriteLine("AddAtIndex");
        if (index == 0) {
            AddAtHead(val);
            return;
        }
        if (index == size) {
            AddAtTail(val);
            return;
        }

        ListNode curr = head;

        for (int i = 0; i < index; i++) {
            curr = curr.next;
        }

        ListNode newNode = new ListNode(val);

        newNode.prev = curr.prev;
        newNode.prev.next = newNode;
        newNode.next = curr;
        curr.prev = newNode;
        
        size++;
    }
    
    public void DeleteAtIndex(int index) {

        Console.WriteLine("DeleteAtIndex");

        if (index >= size) {
            return;
        }

        if (index == 0) {
            head = head.next;
            head.prev = null;
        }
        else if (index == size - 1) {
            tail = tail.prev;
            tail.next = null;
        }
        else {

            ListNode curr = head;
            for (int i = 0; i < index; i++) {
                curr = curr.next;
            }

            curr.prev.next = curr.next;
            curr.next.prev = curr.prev;
        }

        size--;
    }
}

public class ListNode {
    public int val;
    public ListNode next;
    public ListNode prev;

    public ListNode(int value) {
        val = value;
    }
}

/**
 * Your MyLinkedList object will be instantiated and called as such:
 * MyLinkedList obj = new MyLinkedList();
 * int param_1 = obj.Get(index);
 * obj.AddAtHead(val);
 * obj.AddAtTail(val);
 * obj.AddAtIndex(index,val);
 * obj.DeleteAtIndex(index);
 */