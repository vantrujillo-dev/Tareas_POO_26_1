
using UnityEngine;

/// <summary>
/// Controla el seguimiento de la cámara a la bola.
/// </summary>

public class CamaraFollow : MonoBehaviour
{
    // TODO: Referencia al objetivo (bola)

    public Transform objetivo;

    // TODO: Offset o separación entre la cámara y el objetivo
    //           Transform position     x    y    z

    public Vector3 offset = new Vector3(0f, 3f, -6f);

    // TODO: Variable para activar o desactivar el seguimiento
   

    void LateUpdate()
    {
        // PISTA: Solo seguir si está activado y el objetivo está correctamente referenciado
        if (seguir && objetivo != null)

        {
            // PISTA: Posicionar cámara con offset
            //transform.position = ???
        }

    }

    // PISTA: Método para iniciar seguimiento
    public void IniciarSeguimiento()
    {
        // Seguir = true;
    }

    // PISTA: Método para detener seguimiento
    public void DetenerSeguimiento()
    {
        // seguir = false;
    }


  
}
