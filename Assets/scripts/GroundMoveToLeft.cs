using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMoveToLeft : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * 0.5f * Time.deltaTime;
        if(transform.position.x <= -0.742)
        {
            transform.position = new Vector3(0.752f, transform.position.y, transform.position.z);
        }
    }
}
