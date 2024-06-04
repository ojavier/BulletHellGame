using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Rigidbody rb;
    
    // Start is called before the first frame update
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
