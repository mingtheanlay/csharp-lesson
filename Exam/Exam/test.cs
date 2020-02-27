using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
  

    try {
      // int[] arr1 = new int[2];
      // arr1[0] = 1;
      // arr1[1] = 2;
      // arr1[2] = 3;
    } 
    catch (FormatException) {
      // FormatException: Exception thrown when the format of argument is invalid
      // int res6 = int.Parse("2.5");
      MessageBox.Show("FormatException");
    } 
    catch (IndexOutOfRangeException) {
      // IndexOutOfRangeException: Exception thrown when the index is outside the bound of collection or array
      
      MessageBox.Show("IndexOutOfRangeException");
    } 
    catch (DivideByZeroException) {
      // DivideByZeroException: Exception thrown when is attempt to divide the value by zero
      // int n1 = 10, n2 = 0;
      // int res10 = n1 / n2;
      MessageBox.Show("DivideByZeroException");
    } 
    catch (OverflowException) {
      // OverflowException: Exception thrown when an arithmetic, casting or conversion operation is too large to store by destination data type that cause over flow
      // byte res5 = byte.Parse("256");
      MessageBox.Show("OverflowException");
    }
    catch(Exception ex) {
      MessageBox.Show(ex);
    }

    // static method: called using class name, not instance or object.

    // Add data to list
    List<int> res8 = new List<int>();
    res8.Add(1);

    //1D
    double[] arr2 = new double[3]{1.1,1.2,1.3};
    double[] arr2 = new double[] {2.1,2.2,2.3,2.4};
    double sum = 0;
    for(int i = 0; i < arr2.GetLength(0); i++) {
      MessageBox.Show(arr2[i]);
      sum += arr2[i];
    } 
    MessageBox.Show("Answer: " + sum);

    // 2D
    int[,] arr3 = new int[,]{
      {1,2,3},
      {4,5,6}
    };
    int[,] arr3 = new int[2,3] {
      {1,2,3},
      {4,5,6}
    };
    int sum = 0;
    for(int i = 0; i < arr3.GetLength(0); i++) {
      for(int j = 0; j < arr3.GetLength(1); j++) {
        sum += arr3[i,j];
      }
    }
    MessageBox.Show(sum);

    // Jagged Array:
    int[][] arr4 = new int[2][] {
      new int [2] {1,2},
      new int [1] {10}
    };
    int sum = 0;
    for(int i = 0; i < arr4.Length; i++) {
      for(int j = 0; j < arr4[i].Length; j++) {
        sum += arr4[i][j];
      }
    }
    MessageBox.Show(sum);

  }
}