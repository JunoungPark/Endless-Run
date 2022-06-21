using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    public Animator animator;

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
        animator.enabled = true;
        popUp.SetActive(true);
    }

    public void UIDisable()
    {
        popUp.SetActive(false);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && GameManager.instance.condtion == true)
        {
            if (Time.timeScale == 1)
            {
                
                popUp.SetActive(true);
                Time.timeScale = 0;
                
            }
            else if (Time.timeScale == 0)
            {
                popUp.SetActive(false);
                Time.timeScale = 1;
                
            }

        }
    }
    // Start is called before the first frame update

    // Update is called once per frame

}
