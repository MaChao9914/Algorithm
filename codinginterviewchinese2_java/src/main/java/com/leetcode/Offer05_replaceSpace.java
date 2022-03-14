package com.leetcode;

public class Offer05_replaceSpace {
    public String replaceSpace(String s) {
        int length = s.length();
        int newSize = 0;
        char[] chs = new char[length * 3];
        for(int i = 0; i < length; i++){
            char ch = s.charAt(i);
            if(ch == ' '){
                chs[newSize++] = '%';
                chs[newSize++] = '2';
                chs[newSize++] = '0';
            }else{
                chs[newSize++] = ch;
            }
        }
        String newStr = new String(chs, 0, newSize);
        return newStr;
    }
}
