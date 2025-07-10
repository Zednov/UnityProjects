using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// allt åvanför är bonus kodpaket om ni undrar (Behöver inte kunna). Det kommer automatiskt läggas till och kan lägga in själv också. De som är vit används och de grå används inte

public class AsteroidScript : MonoBehaviour // Klassen
{
    // Defenierade Variabler
    [SerializeField] float moveSpeed;
    Rigidbody2D rb;
    
    void Start() // Start Körs I början (innan första bild / frame)
    {
        rb = GetComponent<Rigidbody2D>(); // Hämta Component

        Vector2 directionToCenter = (new Vector2(0,0) - rb.position).normalized;

        Vector2 randomDirection = Random.insideUnitCircle.normalized;

        rb.AddForce(directionToCenter*moveSpeed);
        rb.AddForce(randomDirection*moveSpeed*0.5f);
    }
}
