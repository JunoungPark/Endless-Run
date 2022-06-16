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

    // Update is called once per frame
    void Update()
    {
        
    }
}
