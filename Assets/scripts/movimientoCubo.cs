using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoCubo : MonoBehaviour
{
    // Velocidad de movimiento, modificable desde el editor de Unity
    [SerializeField]
    private float vel = 1.5f;

    // Indicador de ejes invertidos, modificable desde el editor de Unity
    [SerializeField]
    private bool invertedAxes;

    // Awake se ejecuta antes de cualquier otro m�todo incluido Start
    void Awake()
    {
        // Invertimos la velocidad si invertedAxes es verdadero
        if (invertedAxes)
        {
            vel = -vel;  // Multiplicamos por -1 para invertir la direcci�n
        }
    }

    // Update se llama una vez por frame
    void Update()
    {
        // Obtenemos la entrada del usuario en los ejes horizontal y vertical
        float movX = Input.GetAxis("Horizontal");
        float movZ = Input.GetAxis("Vertical");

        // Creamos un vector de movimiento basado en la entrada del usuario y la velocidad
        Vector3 mov = new Vector3(movX, 0.0f, movZ) * vel * Time.deltaTime;

        // Movemos el objeto en la direcci�n calculada
        transform.Translate(mov);
    }
}

