using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlBola : MonoBehaviour
{

    public Rigidbody rb;

    //Variables para apuntar 
    public float velocidadDeApuntado = 5f;
    public float limiteIzquierdo = -2f;
    public float limiteDerecho = -2f;


    public float fuerzaDeLanzamiento = 1000f;

    private bool haSidoLanzada = false;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Expresion: mientras que haSidoLanzada sea falso puedes disparar
        if (haSidoLanzada == false)
        {
            Apuntar();
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Lanzar();
            }
        }
    }

    void Apuntar()
    {
        //Leer un input horizontal de tipo axis (eje) te permite registrar entradas con las teclas A y D, 
        //Y flecha izquierda, y flecha derecha
        float inputHorizontal = Input.GetAxis("Horizontal");

        //Mover la bola hacia los lados
        transform.Translate(Vector3.right * inputHorizontal * velocidadDeApuntado * Time.deltaTime);

        //Delimitar el movimiento de la bola
        Vector3 posicionActual = transform.position;

        posicionActual.x = Mathf.Clamp(posicionActual.x, limiteIzquierdo, limiteDerecho);

        transform.position = posicionActual;
    }
    void Lanzar()
    {
        haSidoLanzada = true;
        rb.AddForce(Vector3.forward * fuerzaDeLanzamiento);
        
        this.enabled = false;
    }

} //Bienvenido a la entrada al infierno

