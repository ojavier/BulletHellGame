using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float moveSpeed = 5f; // Velocidad de movimiento del jugador
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (rb == null)
        {
            Debug.LogError("Rigidbody no encontrado en el jugador.");
        }

        // Desactiva la gravedad para que la nave no caiga
        rb.useGravity = false;

        // Congela la rotación en el Rigidbody para evitar que la nave se rote
        rb.freezeRotation = true;
    }

    void Update()
    {
        // Captura la entrada de teclado para el movimiento horizontal
        float moveHorizontal = Input.GetAxis("Horizontal");
        // Captura la entrada de teclado para el movimiento vertical
        float moveVertical = Input.GetAxis("Vertical");

        // Calcula la velocidad de movimiento en los ejes X y Z
        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);

        // Aplica el movimiento al Rigidbody
        rb.velocity = movement * moveSpeed;
    }
}
