package com.leetcode;

import java.util.Stack;

public class Offer09_CQueue {

    Stack<Integer> stack1;
    Stack<Integer> stack2;
    
    public Offer09_CQueue() {
        stack1 = new Stack<>();
        stack2 = new Stack<>();
    }
    
    public void appendTail(int value) {
        stack1.push(value);
    }
    
    public int deleteHead() {

        if(stack2.isEmpty()){
            while(!stack1.isEmpty()){
                stack2.add(stack1.pop());
            }
        }

        if( stack2.isEmpty())
            return -1;
        else{
            return stack2.pop();
        }
    }
}
