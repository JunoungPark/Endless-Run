using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCreate : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Character")
        {
            Debug.Log("�浹 �Ǿ����ϴ�.");
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
