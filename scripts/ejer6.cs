using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer6 : MonoBehaviour
{
    public float speed = 1f;
    public Vector3 moveDirection = Vector3.zero;
    GameObject Target;

    // Start is called before the first frame update
    void Start()
    {
        Target = GameObject.Find("green_sphere");
    }

    // Update is called once per frame
    void Update()
    {
        moveDirection = Target.transform.position - transform.position;
        transform.Translate(moveDirection.normalized * speed * Time.deltaTime);
    }
}
