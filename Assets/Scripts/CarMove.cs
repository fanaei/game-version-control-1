using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarMove : MonoBehaviour
{
    float MoveX = 0;
    // ------------
    void Start()
    {
        
    }

    // ---------------
    void Update()
    {
        MoveX += 0.001f;

        if (Input.GetKey(KeyCode.Space))
        {
            gameObject.transform.position = new Vector3(MoveX, 0, 0);
        }
    }
}
