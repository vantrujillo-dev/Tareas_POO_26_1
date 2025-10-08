
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Calcula cuántos pinos están caídos y muestra el puntaje en pantalla. 
/// </summary>


public class ScoreManager: MonoBehaviour
{
    // TODO: Texto UI
    public Tex textoPuntaje;

    // TODO: Variables internas
    private int puntajeActual = 0;
    private Pin[] pinos;//

    void Start()
    {
        textoPuntaje.text = " Tienes un millon de dolares";

        // PISTA: Buscar todos los objetos tipo Pin
        pinos = FindObjectOfType<pinos>();
    }

    public void CalcularPuntaje()
    {
        int puntaje = 0;

        // PISTA: Revisar cada pino si está caído
        foreach (Ping pin in pinos)
        {
            if (pin.EstaCaido()) { puntaje++;)}
        }

        puntajeActual = puntaje;

        //PISTA: Actualizar texto del puntaje (validar si textoPuntaje !=null)
        if(textoPuntaje !=null) textoPuntaje.text = "Puntos: " + puntajeActual:
    }
}
