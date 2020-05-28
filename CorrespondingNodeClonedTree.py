# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, x):
#         self.val = x
#         self.left = None
#         self.right = None
# Given two binary trees original and cloned and given a reference to a node target in the original tree.
class Solution:
    def getTargetCopy(self, original: TreeNode, cloned: TreeNode, target: TreeNode) -> TreeNode:
        if (original.left == None and original.right == None) or original == target:
            return cloned
        compare = original
        queue = [original]
        comp_queue = [cloned]
        while True:
            if target == original:
                return compare
            if original.left:
                queue.append(original.left)
                comp_queue.append(cloned.left)
            if original.right:
                queue.append(original.right)
                comp_queue.append(cloned.right)
                
            original = queue.pop(0)
            cloned = comp_queue.pop(0)
            compare = cloned