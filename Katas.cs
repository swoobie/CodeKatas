namespace CodeKatas;

public class Katas {
 
/*
* 9/18/2024
* Given an array of integers, write a function to determine if it contains a Pythagorean triplet.
* A Pythagorean triplet consists of three integers (a, b, c) such that: a² + b² = c²
*/
    public static bool ContainsPythagoreanTriplet(int[] arr) {
        // square all elements
        for (int i = 0; i < arr.Length; i++) {
            arr[i] = arr[i] * arr[i];
        }
        
        // sort them
        Array.Sort(arr);
        
        // check if there is a triplet
        for (int i = arr.Length - 1; i >= 2; i--) {
            var left = 0;
            var right = i - 1;
            while (left < right) {
                if (arr[left] + arr[right] == arr[i]) {
                    return true;
                }
                if (arr[left] + arr[right] < arr[i]) {
                    left++;
                } else {
                    right--;
                }
            }
        }
        
        return false;
    }
}