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
     * @return {number}
     */
    diameterOfBinaryTree(root) {

        if (!root) {
            return 0
        }

        let left = this.dfs(root.left);
        let right = this.dfs(root.right);

        return Math.max(left[1], right[1], left[0] + right[0]);


    }

    dfs(root) {
        if (!root) {
            return [0, 0]
        }

        let left = this.dfs(root.left)
        let right = this.dfs(root.right)

        return [Math.max(left[0], right[0]) + 1, Math.max(left[0] + right[0], left[1], right[1])]
    }
}
