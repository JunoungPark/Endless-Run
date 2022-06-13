using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyRotation : MonoBehaviour
{
    float rotateData = 0.0f;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        rotateData += Time.deltaTime;
        if (360 < rotateData)
            rotateData -= 360;

        RenderSettings.skybox.SetFloat("_Rotation", rotateData);


    }
}
