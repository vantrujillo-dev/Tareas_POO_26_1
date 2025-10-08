using UnityEngine;

public class CamaraSeguimiento : MonoBehaviour
{
    // Objeto (la bola) que la camara debe seguir
    public Transform objetivo;

    // Distancia fija desde el objetivo (Offset)
    // Ajusta estos valores en el Inspector para el mejor angulo
    public Vector3 offset;

    // Velocidad con la que la camara se mueve hacia el objetivo (suavizado)
    public float velocidadSuavizado = 0.125f;

    // Variable para saber si la camara debe seguir a la bola
    private bool debeSeguir = false;


    void Start()
    {
        // Calcular el offset inicial basado en la posicion actual de la camara
        // con respecto al objetivo.
        if (objetivo != null)
        {
            offset = transform.position - objetivo.position;
            // La camara empieza a seguir la bola en cuanto se inicia el juego.
            debeSeguir = true;
        }
    }

    // LateUpdate se llama despues de que todos los Updates han terminado.
    // Esto asegura que la camara siga el objetivo *despues* de que este se haya movido.
    void LateUpdate()
    {
        if (objetivo != null && debeSeguir)
        {
            // La posicion deseada es la posicion del objetivo mas el offset.
            Vector3 posicionDeseada = objetivo.position + offset;

            // Suavizar el movimiento de la camara usando Lerp (interpolacion lineal).
            // Esto evita que el movimiento sea robotico o brusco.
            Vector3 posicionSuavizada = Vector3.Lerp(transform.position, posicionDeseada, velocidadSuavizado);

            // Asignar la nueva posicion a la camara.
            transform.position = posicionSuavizada;

            // Opcional: Asegurar que la camara siempre mire a la bola.
            transform.LookAt(objetivo);
        }
    }

    // Metodo para detener el seguimiento (util si la bola cae a la cuneta o termina su recorrido)
    public void DetenerSeguimiento()
    {
        debeSeguir = false;
    }
}
