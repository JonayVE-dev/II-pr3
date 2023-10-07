using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer7 : MonoBehaviour
{
    GameObject Target;

    // Start is called before the first frame update
    void Start()
    {
        Target = GameObject.Find("green_sphere");
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Target.transform);
    }
}
