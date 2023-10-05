using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RotatePlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 90.0f);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 180.0f);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 270.0f);
        }


    }
}
