using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public Animator animator;


    // Update is called once per frame
    
    
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
            animator.enabled = true;
    }

}
