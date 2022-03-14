package com.leetcode;

import java.util.HashSet;
import java.util.Set;

/**
 * Hello world!
 *
 */
public class Offer03_findRepeatNumber 
{
    public static int findRepeatNumber(int[] nums) {
        Set<Integer> set = new HashSet<Integer>();
        int repeat = -1;
        for(int num : nums){
            if(!set.add(num)){
                repeat = num;
                break;
            }
        }
        return repeat;
    }
}
