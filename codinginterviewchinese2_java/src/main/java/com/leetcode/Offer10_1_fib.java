package com.leetcode;

public class Offer10_1_fib {

    public int fib(int n) {
        final int MOD = 1000000007;
        if(n < 2){
            return n;
        }

        int p = 0, q = 0, temp = 1;
        for(int i=2; i <= n; i++){
            p = q;
            q = temp;
            temp = (p + q) % MOD;
        }
        return temp;
    }
}
