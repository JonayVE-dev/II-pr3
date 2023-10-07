using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejer12 : MonoBehaviour
{
    Rigidbody body;
    GameObject Target;
    public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
        Target = GameObject.Find("green_sphere");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Vector3 direction = Target.transform.position - transform.position;
            body.AddForce(direction * speed);
        } else {
            float horizontalForce = Input.GetAxis("Horizontal") * speed;
            float verticalForce = Input.GetAxis("Vertical") * speed;
            body.AddForce(new Vector3(horizontalForce, 0, verticalForce));
        }
    }   
}
