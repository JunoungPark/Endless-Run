using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadManager : MonoBehaviour
{

    public GameObject road;

    GameObject nextroad;

    public float speed;

    List<GameObject> roadList;
    // Start is called before the first frame update

    Vector3 nextRoad = Vector3.zero;

    int firstRoad, lastRoad;
    void Start()
    {
        roadList = new List<GameObject>();

        for (int i = 0; i < 61; i += 30)
        {
            roadList.Add(Instantiate(road, new Vector3(0, 0, i), Quaternion.identity));
        }

        lastRoad = 0;
        firstRoad = roadList.Count - 1;
    }
    // Update is called once per frame
    void Update()
    {
        RoadMove();
        
       
    }
    void RoadMove()
    {
        for(int i = 0; i < roadList.Count; i++)
        {
            roadList[i].transform.Translate(-Vector3.forward * speed * Time.deltaTime);
        }

        if (roadList[lastRoad].transform.position.z < -21)
        {
            roadList[lastRoad].transform.position = roadList[firstRoad].transform.position + new Vector3(0, 0, 30);

            firstRoad = lastRoad;

            lastRoad++;

            if (lastRoad == roadList.Count)
                lastRoad = 0;
        }
    }
}
