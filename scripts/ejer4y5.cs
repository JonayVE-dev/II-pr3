using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer4 : MonoBehaviour
{
    public float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float movH = Input.GetAxis("Horizontal");
        float movV = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(movH, 0, movV) * speed * Time.deltaTime);
    }
}
