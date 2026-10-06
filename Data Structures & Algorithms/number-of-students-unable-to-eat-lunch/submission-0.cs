public class Solution {
    public int CountStudents(int[] students, int[] sandwiches) {
        Queue<int> queue = new Queue<int>();

        int circle = 0;
        int square = 0;

        for (int i = 0; i < students.Length; i++) {
            queue.Enqueue(students[i]);
            if (students[i] == 0) {
                circle++;
            }
            else {
                square++;
            }
        }

        int j = 0;
 
        while (queue.Count != 0) {

            if (sandwiches[j] == 0 && circle == 0) {
                return queue.Count;
            }
            if (sandwiches[j] == 1 && square == 0) {
                return queue.Count;
            }

            if (queue.Peek() != sandwiches[j]) {
                queue.Enqueue(queue.Dequeue());
            }
            else {
                if (queue.Dequeue() == 0) {
                    circle--;
                }
                else {
                    square--;
                }
                j++;
            }

        }

        return queue.Count;
    }
}