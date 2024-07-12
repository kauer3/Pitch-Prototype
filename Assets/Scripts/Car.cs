using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public float moveSpeed = 30;
    public float deadZone = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + Vector3.forward * moveSpeed * Time.deltaTime;

        if (transform.position.z > deadZone)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -100);
        }
    }
}
