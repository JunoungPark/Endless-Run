using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public Animator animator;


    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.condtion == true)
        {
            transform.Translate(Vector3.back * GameManager.instance.gamespeed * Time.deltaTime);
        }
    }
    private void OnBecameInvisible()
    {
        ObjectPooling.objectPool.InsertQueue(gameObject);
        transform.position = new Vector3(transform.position.x, transform.position.y, 10);
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
            animator.enabled = true;
    }

}
