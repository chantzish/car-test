using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cartest : MonoBehaviour
{
    float min = 0f;
    float max = 0f;
    public float speed = 2.0f;
    // Start is called before the first frame update
    //void Start()
    //{

    //}

    // Update is called once per frame
    void Update()
    {
        float rotateMouse = Input.GetAxis("Mouse X");
        if (rotateMouse < min) min = rotateMouse;
        if (rotateMouse > max) max = rotateMouse;
        transform.Rotate(0, rotateMouse, 0);
        if(rotateMouse != 0)
        {
            Debug.Log($"max: {max} min: {min}");
            Debug.Log(transform.eulerAngles);
        }
        
    }
}
