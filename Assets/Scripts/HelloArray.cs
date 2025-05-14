using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloArray : MonoBehaviour
{
    /*
        배열이 왜 필요할까?
    다량의 메모리 관리가 어렵다!
        
     */
    void Start()
    {
        int[] scores = new int[50];
        // index
        // 0 1 2 3 4 5 6 7 8 9
        // [][][][][][][][][][]
        scores[0] = 100;
        scores[1] = 20;
        scores[2] = 40;
        scores[3] = 20;
        scores[4] = 120;
        scores[5] = 160;
        scores[6] = 19;
        scores[7] = 100;
        scores[8] = 11;
        scores[9] = 10;
        Debug.Log(scores[0]);


        scores = new int[20];

        // 배열이 클래스로 구현되어 있어서 가지는 장점
        // 내장변수, 내장함수가 존재한다.    



        // scores.Length
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
