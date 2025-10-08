using UnityEngine;

public class ControlBolos : MonoBehaviour
{
    private Rigidbody rb;

    void Start()
    {
        // Obtener el componente Rigidbody
        rb = GetComponent<Rigidbody>();

        // Asegurarse de que el bolo sea cinematico al inicio (deberia estar ya marcado en el Inspector)
        // Por seguridad, lo volvemos a poner
        if (rb != null)
        {
            rb.isKinematic = true;
        }
    }

    // Esta funcion se llama cuando el Collider del bolo toca a otro Collider
    void OnCollisionEnter(Collision collision)
    {
        // Verifica si el objeto con el que colisiono es la bola de boliche.
        // Asumo que tu bola tiene el tag "BowlingBall" (debes crearlo y asignarlo).
        if (collision.gameObject.CompareTag("BowlingBall"))
        {
            // El bolo fue impactado: ¡Desactiva Is Kinematic!
            // Esto permite que el Rigidbody sea afectado por la fisica (gravedad, impacto).
            if (rb != null)
            {
                rb.isKinematic = false;
            }
        }
    }
}
