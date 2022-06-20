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
            if (GameManager.instance.gamespeed < 95)
            {
                GameManager.instance.gamespeed++;
            }
            GameManager.instance.crashCount ++;
            if (GameManager.instance.crashCount % 10 == 0)
            {
                DataManager.instance.level++;
            }
        }

        
    }
    // Start is called before the first frame update

}
