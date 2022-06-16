using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public int count = 0;

    public Animator animator;

    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.condtion == true)
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
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Tire Stack")
        {
            GameManager.instance.condtion = false;
            animator.SetTrigger("Death");
            UIManager.instance.UIActive();
        }
    }

}
