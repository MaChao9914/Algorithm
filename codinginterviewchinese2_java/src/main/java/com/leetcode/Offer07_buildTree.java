package com.leetcode;

import java.util.HashMap;
import java.util.Map;

public class Offer07_buildTree {
    private Map<Integer, Integer> indexMap;
    public TreeNode buildTree(int[] preorder, int[] inorder) {
        indexMap = new HashMap<Integer, Integer>();
        int length = preorder.length;
        for(int i = 0; i < length; i++){
            indexMap.put(inorder[i], i);
        }

        return buildTree(preorder, inorder, 0, length-1, 0, length-1);
    }

    private TreeNode buildTree(int[] preorder, int[] inorder, int preorder_start, int preorder_end, int inorder_start, int inorder_end){
        if(preorder_start > preorder_end)
            return null;

        int preorder_root = preorder_start;

        int inorder_root = indexMap.get(preorder[preorder_root]);

        int size_left_subtree = inorder_root - inorder_start;

        TreeNode tree = new TreeNode(preorder[preorder_root]);

        tree.left = buildTree(preorder, inorder, preorder_start + 1, preorder_start + size_left_subtree, inorder_start, inorder_root - 1);
        tree.right = buildTree(preorder, inorder, preorder_start + size_left_subtree + 1, preorder_end, inorder_root + 1, inorder_end);
        return tree;

    }
}

class TreeNode {
    int val;
    TreeNode left;
    TreeNode right;
    TreeNode(int x) { val = x; }
}