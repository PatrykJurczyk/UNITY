using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorStateChange : MonoBehaviour{

    void Update(){
        GetComponent<Animator>().SetBool("isJumping", Input.GetKey(KeyCode.Space));
        GetComponent<Animator>().SetBool("isAttacking", Input.GetKey(KeyCode.A));
        GetComponent<Animator>().SetBool("isDamaging", Input.GetKey(KeyCode.D));
    }
}
