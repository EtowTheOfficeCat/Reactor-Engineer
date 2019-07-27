using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
   

    // Update is called once per frame
    void Update()
    {


        transform.position = new Vector3((transform.position.x), Mathf.Clamp(transform.position.y, 0.95f, 1f), (transform.position.z));
    }
}

