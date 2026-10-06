/**
 * Definition for a binary tree node.
 * class TreeNode {
 *     constructor(val = 0, left = null, right = null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

class Solution {
    /**
     * @param {TreeNode} root
     * @param {TreeNode} subRoot
     * @return {boolean}
     */
    isSubtree(root, subRoot) {

        if (!root) {
            return false
        }

        if (root.val == subRoot.val) {
            if (this.isEqual(root, subRoot)) {
                return true
            }
        }

        return this.isSubtree(root.left, subRoot) || this.isSubtree(root.right, subRoot)
    }

    isEqual(a, b) {

        if (!a && !b) {
            return true
        }

        if (!a || !b) {
            return false
        }

        return a.val == b.val && this.isEqual(a.left, b.left) && this.isEqual(a.right, b.right)

    }
}
