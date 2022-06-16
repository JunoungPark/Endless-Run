using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    public GameObject popUp;


    private void Start()
    {
        instance = this;
    }
    public void UIActive()
    {
        Invoke("InvokeActive", 1f);
    }

    public void InvokeActive()
    {
        popUp.SetActive(true);
    }

    // Start is called before the first frame update

    // Update is called once per frame
    
}
