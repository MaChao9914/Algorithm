package com.leetcode;

import java.util.Stack;

public class Offer06_reversePrint {

    public int[] reversePrint(ListNode head) {
        Stack<ListNode> stack = new Stack<ListNode>();
        ListNode temp = head;
        while(temp != null){
            stack.push(temp);
            temp = temp.next;
        }
        int size = stack.size();
        int[] ans = new int[size];
        for(int i = 0; i < size; i++){
            ans[i] = stack.pop().val;
        }
        return ans;
    }
}


class ListNode {
    int val;
    ListNode next;
    ListNode(int x) { val = x; }
}
 