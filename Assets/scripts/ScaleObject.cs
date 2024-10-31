using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleObject : MonoBehaviour
{
    // Velocidad de escalado, modificable desde el editor de Unity
    [SerializeField]
    private float speedScale = 3.0f;

    // Awake se llama antes de cualquier inicialización, útil para configuraciones iniciales
    void Awake()
    {
        // Inicializaciones necesarias pueden ir aquí
    }

    // Start se llama antes de la primera actualización del frame
    private void Start()
    {
        // Inicializaciones adicionales pueden ir aquí
    }

    // Update se llama una vez por frame
    void Update()
    {
        // Obtenemos el tamaño actual del objeto
        Vector3 nuevotamaño = transform.localScale;

        // Calculamos el cambio en el tamaño basado en la rueda del ratón y la velocidad
        nuevotamaño += Vector3.one * Input.mouseScrollDelta.y * speedScale * Time.deltaTime;

        // Asignamos el nuevo tamaño al objeto
        transform.localScale = nuevotamaño;
    }
}

