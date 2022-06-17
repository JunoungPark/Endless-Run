using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleActive : MonoBehaviour
{
    public GameObject[] Tire;
    // Start is called before the first frame update
    void Start()
    {
        int rand =Random.Range(0, Tire.Length);

        for(int i = 0; i < Tire.Length; i++)
        {
            Tire[i].SetActive(false);
        }
        Tire[rand].SetActive(true);
    }
    private void Update()
    {
        if (GameManager.instance.condtion == true)
        {
            transform.Translate(Vector3.back * GameManager.instance.gamespeed * Time.deltaTime);
        }
    }
    private void OnBecameInvisible()
    {
        ObjectPooling.objectPool.InsertQueue(gameObject);
        transform.position = new Vector3(transform.position.x, transform.position.y, 55);
    }
   
}
