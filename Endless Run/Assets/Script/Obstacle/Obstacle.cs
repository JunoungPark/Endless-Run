using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float speed = 5.0f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);
    }
    private void OnBecameInvisible()
    {
        ObjectPooling.objectPool.InsertQueue(gameObject);
        transform.position = new Vector3(transform.position.x, transform.position.y, 5);
    }

}
