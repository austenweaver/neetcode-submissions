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
     * @return {boolean}
     */
    isBalanced(root) {

        return this.dfs(root).isBalanced;

    }

    dfs(root) {

        if (!root) {
            return {isBalanced: true, height: 0}
        }

        let left = this.dfs(root.left);
        let right = this.dfs(root.right);




        return {isBalanced: left.isBalanced && right.isBalanced && (Math.abs(left.height - right.height) < 2), height: Math.max(left.height, right.height) + 1}
    }
}
