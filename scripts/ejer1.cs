using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer1 : MonoBehaviour
{
    public int velocity = 10;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float axisValue;
        if (Input.GetKey(KeyCode.UpArrow)  || Input.GetKey(KeyCode.DownArrow))
        {
            axisValue = Input.GetAxis("Vertical");
            string flecha = axisValue > 0 ? "Arriba" : "Abajo";
            Debug.Log("Flecha " + flecha + " pulsada: " + axisValue * velocity);
        } else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            axisValue = Input.GetAxis("Horizontal");
            string flecha = axisValue > 0 ? "Derecha" : "Izquierda";
            Debug.Log("Flecha " + flecha + " pulsada: " + axisValue * velocity);
        }
    }
}
