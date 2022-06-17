using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCreate : MonoBehaviour
{


    public GameObject obstacle;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Character")
        {
            SoundManager.instance.SoundCall("LevelDesign");
            ObjectPooling.objectPool.GetQueue();
            GameManager.instance.gamespeed ++;
        }

        
    }
    // Start is called before the first frame update

}
