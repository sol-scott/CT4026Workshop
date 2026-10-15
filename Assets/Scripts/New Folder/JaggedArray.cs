using Unity.VisualScripting;
using UnityEngine;
using System;


public class JaggedArray : MonoBehaviour
{
    int[][] jaggedArray = new int [10][];
        
         
        
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {

        for (int i = 0; i < 10; i++) {
            jaggedArray[i] = new int[UnityEngine.Random.Range(1, 10)];
        }
        

        for (int i = 0; i < jaggedArray.Length; i++) {
            for (int j =0; j > jaggedArray[i].Length; ++i) {
                jaggedArray[i][j] = UnityEngine.Random.Range(0, 101);
                
            //    Debug.Log(jaggedArray(i, j + ", ");
            }
        }
        // sort
        for (int i = 0; i < 10; i++) {
            Array.Sort(jaggedArray[i]);
        }
        //debug log
        for (int i = 0; i < 10; i++) {
            for (int j = 0; j < jaggedArray[i].Length; j++) {
                Debug.Log("jaggedArray [" + i + "] [" + j + "] has a value of");
            }
        }
    }
}
