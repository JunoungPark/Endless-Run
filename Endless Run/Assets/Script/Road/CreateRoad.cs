using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateRoad : MonoBehaviour
{
    public GameObject Road;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = -6; i < 25; i += 6)
            Instantiate(Road, new Vector3(0, 0, i),Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
