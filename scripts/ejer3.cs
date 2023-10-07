using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer3 : MonoBehaviour
{
    public float speed = 1;
    public Vector3 moveDirection = Vector3.up;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Transform>().Translate(moveDirection * speed * Time.deltaTime);
    }
}
