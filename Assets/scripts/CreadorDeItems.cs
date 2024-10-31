using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Definición de la clase CreadorDeItems, que hereda de MonoBehaviour
public class CreadorDeItems : MonoBehaviour
{
    // Variables privadas para almacenar referencias a los prefabs de los items
    [SerializeField]
    private GameObject prefabRed;

    [SerializeField]
    private GameObject prefabBlue;

    // Variable para mantener la referencia al objeto creado
    private GameObject objetoCreado;

    // Método Update que se llama una vez por frame
    void Update()
    {
        // Comprobar si se presiona la tecla R o B
        if (Input.GetKeyDown(KeyCode.R) || Input.GetKeyDown(KeyCode.B))
        {
            // Crear un rayo desde la cámara principal hacia la posición del mouse
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // Comprobar si el rayo colisiona con algún objeto
            if (Physics.Raycast(ray, out hit))
            {
                // Comprobar si se presiona la tecla R
                if (Input.GetKeyDown(KeyCode.R))
                {
                    // Instanciar prefabRed en la posición del punto de impacto (hit.poit) y con rotación por defecto (quaternion.identity)
                    objetoCreado = Instantiate(prefabRed, hit.point, Quaternion.identity);
                }
                // Comprobar si se presiona la tecla B
                else if (Input.GetKeyDown(KeyCode.B))
                {
                    // Instanciar prefabBlue en la posición del punto de impacto y con rotación por defecto
                    objetoCreado = Instantiate(prefabBlue, hit.point, Quaternion.identity);
                }

                // Ajustar la altura del objeto creado para evitar que quede medio introducido
                objetoCreado.transform.position += new Vector3(0, objetoCreado.transform.localScale.y / 2, 0);
            }
        }
    }
}



