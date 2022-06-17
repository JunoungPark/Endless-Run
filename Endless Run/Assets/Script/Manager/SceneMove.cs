using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneMove : MonoBehaviour
{
    public void SceneNumber(string name)
    {

        SceneManager.LoadScene(name);
        GameManager.instance.condtion = true;
        GameManager.instance.gamespeed = 10f;
    }
    // Start is called before the first frame update
}