using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer8 : MonoBehaviour
{
    public float rotationSpeed = 150f;
    public float speed = 2f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        transform.Rotate(0, rotation, 0);
        transform.Translate(transform.forward * speed * Time.deltaTime, Space.World);
        Debug.DrawRay(transform.position, transform.forward * 10, Color.red);
    }
}
