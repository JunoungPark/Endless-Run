using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public bool condtion = true;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;

            DontDestroyOnLoad(instance);
        }
        else
        {
            Destroy(instance);
        }
    }
    // Start is called before the first frame update
}
