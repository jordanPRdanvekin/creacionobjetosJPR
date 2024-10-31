using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleObject : MonoBehaviour
{
    // Velocidad de escalado, modificable desde el editor de Unity
    [SerializeField]
    private float speedScale = 3.0f;

    // Awake se llama antes de cualquier inicializaci�n, �til para configuraciones iniciales
    void Awake()
    {
        // Inicializaciones necesarias pueden ir aqu�
    }

    // Start se llama antes de la primera actualizaci�n del frame
    private void Start()
    {
        // Inicializaciones adicionales pueden ir aqu�
    }

    // Update se llama una vez por frame
    void Update()
    {
        // Obtenemos el tama�o actual del objeto
        Vector3 nuevotama�o = transform.localScale;

        // Calculamos el cambio en el tama�o basado en la rueda del rat�n y la velocidad
        nuevotama�o += Vector3.one * Input.mouseScrollDelta.y * speedScale * Time.deltaTime;

        // Asignamos el nuevo tama�o al objeto
        transform.localScale = nuevotama�o;
    }
}

