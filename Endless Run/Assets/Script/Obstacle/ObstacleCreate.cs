using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCreate : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Character")
        {
            Debug.Log("충돌 되었습니다.");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
