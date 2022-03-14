package com.leetcode;

import javax.lang.model.element.Element;

public class Offer04_findNumberIn2DArray {

    public boolean findNumberIn2DArray1(int[][] matrix, int target) {
        if(matrix == null || matrix.length == 0 || matrix[0].length == 0){
            return false;
        }
        int r = matrix.length, c = matrix[0].length;
        for(int i = 0; i < r; i++){
            for(int j = 0; j < c; j++){
                if(matrix[i][j] == target){
                    return true;
                }
            }
        }
        return false;
    }

    public boolean findNumberIn2DArray2(int[][] matrix, int target) {
        if(matrix == null || matrix.length == 0 || matrix[0].length == 0){
            return false;
        }
        int rows = matrix.length, columns = matrix[0].length;
        int r = 0, c = columns -1;
        while(r < rows && c >= 0){
            int currNum = matrix[r][c];
            if(currNum == target)
                return true;
            else if(currNum > target)
                c--;
            else
                r++;
            
        }
        return false;
    }
}
