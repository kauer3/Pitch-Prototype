using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10f;
    public float rotationSpeed = 6f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 input = new Vector3(Input.GetAxisRaw("Vertical"), 0, Input.GetAxisRaw("Horizontal") * -1);
        Vector3 inputDirection = input.normalized;

        transform.Translate(inputDirection * speed * Time.deltaTime);

        transform.Rotate(Vector3.up * Time.deltaTime * Input.GetAxis("Mouse X") * rotationSpeed);
    }
}
