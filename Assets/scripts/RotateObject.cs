using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    // Velocidad de rotaci�n ajustable desde el editor
    [SerializeField]
    private float VelRot = 3.0f;

    // Start se llama antes de la primera actualizaci�n del frame
    void Start()
    {
        // Inicializaciones necesarias pueden ir aqu�
    }

    // Update se llama una vez por frame
    void Update()
    {
        // Verifica si la tecla 'Q' est� presionada para rotar a la izquierda
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0, 0, VelRot * Time.deltaTime);  // Rota el objeto en el eje Z
        }

        // Verifica si la tecla 'E' est� presionada para rotar a la derecha
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0, 0, -VelRot * Time.deltaTime);  // Rota el objeto en el eje Z en la direcci�n opuesta
        }
    }
}