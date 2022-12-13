using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lab6_zadanie3 : MonoBehaviour{

    public Transform[] points;
    private float moveSpeed = 3;
    private int currentPoint = 0;
    private int nextPoint = 1;

    void Start(){
        if (points.Length == 0) return;
        GetComponent<Transform>().position = points[currentPoint].position;
    }

    void Update(){
        if (points.Length == 0) return;
        if (GetComponent<Transform>().position == points[currentPoint].position){
            if (currentPoint == points.Length - 1){
                nextPoint = -1;
            }
            else if (currentPoint == 0){
                nextPoint = 1;
            }
            currentPoint += nextPoint;
        }
        GetComponent<Transform>().position = Vector3.MoveTowards(GetComponent<Transform>().position, points[currentPoint].position, moveSpeed * Time.deltaTime);
    }
}
