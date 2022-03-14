package com.leetcode;

import static org.junit.Assert.assertEquals;

import org.junit.Test;

public class Offer03_findRepeatNumberTest {
    @Test
    public void testFindRepeatNumber() {
        int[] nums = {2, 3, 1, 0, 2, 5, 3 }; 
        int response = Offer03_findRepeatNumber.findRepeatNumber(nums);
        assertEquals(2, response);
    }
}
