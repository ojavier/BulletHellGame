using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    public bulletCount bulletController;
    public float speed = 15f;  // Velocidad de la bala
    public float lifetime = 5f; // Tiempo de vida de la bala en segundos
    private Rigidbody rb;

    void Start()
    {
        if (bulletController != null)
        {
            bulletController.count++; // Incrementa el contador de balas al iniciar una nueva bala
        }
        else
        {
        Debug.LogWarning("bulletController no asignado en el Inspector.");
        }
        
        rb = GetComponent<Rigidbody>();

        if (rb != null)
        {
            rb.isKinematic = false;  // Asegúrate de que el Rigidbody no sea cinemático
            rb.useGravity = false;   // Desactiva la gravedad

            // Establece la velocidad solo en el eje X
            rb.velocity = transform.right * speed;  // Movimiento en el eje X
        }
        else
        {
            Debug.LogWarning("Rigidbody no encontrado en la bala.");
        }
        Destroy(gameObject, lifetime); // Destruye la bala después de 'lifetime' segundos
    }

    void OnCollisionEnter(Collision collision)
    {
        // Comprobación para el daño a los enemigos por una bala del jugador
        if (collision.gameObject.CompareTag("Enemy") && gameObject.CompareTag("PlayerBullet"))
        {
            Destroy(gameObject); // Destruye la bala al colisionar con un enemigo
            return; // Evita que se ejecuten más comprobaciones
        }

        // Comprobación para el daño al jugador por una bala del enemigo
        if (collision.gameObject.CompareTag("Player") && gameObject.CompareTag("EnemyBullet"))
        {
            Destroy(gameObject); // Destruye la bala al colisionar con el jugador
            return; // Evita que se ejecuten más comprobaciones
        }

        // Evitar que las balas de enemigo dañen a otros enemigos
        if (collision.gameObject.CompareTag("Enemy") && gameObject.CompareTag("EnemyBullet"))
        {
            return; // No hacer nada si una bala de enemigo colisiona con otro enemigo
        }
    }
}
