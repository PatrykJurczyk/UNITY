using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lab6_zadanie6 : MonoBehaviour{

    void Start(){}

    void Update(){}

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.CompareTag("ENEMY"))
        {
            //print("Wykryto kolizje gracza z przeszkodą");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.transform.root.CompareTag("ENEMY"))
        {
            print("Początek kolizji z przeszkodą");
        }
    }
}
