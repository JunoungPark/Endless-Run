using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) && count > -2)
        {
            count--;
            transform.position += Vector3.left;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && count < 2)
        {
            count++;
            transform.position += Vector3.right;
        }
    }
}
