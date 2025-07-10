using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// allt åvanför är bonus kodpaket om ni undrar (Behöver inte kunna). Det kommer automatiskt läggas till och kan lägga in själv också. De som är vit används och de grå används inte

public class BulletScript : MonoBehaviour // Klassen
{
    // Defenierade Variabler
    [SerializeField] float lifetime;
    void Start() // Start Körs I början (innan första bild / frame)
    {
        Destroy(gameObject,lifetime); // Förstör kulan efter "lifetime" tid
    }

    private void OnCollisionEnter2D(Collision2D collision) // Kollision funktion, collision är det andra objectet vi kolliderat med 
    {
        Destroy(collision.gameObject); // förstör det vi kolliderade med
        Destroy(gameObject); // förstör oss själva (kulan)
    }
}
