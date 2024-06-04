using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class bulletCount : MonoBehaviour
{
    public TextMeshProUGUI bulletCountText;
    public int count = 0;

    void Update()
    {
        // Actualiza el texto del contador de balas
        bulletCountText.text = "Balas: " + count.ToString(); // Cambia toString() a ToString() con "T" mayúscula
    }
}