using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// allt åvanför är bonus kodpaket om ni undrar (Behöver inte kunna). Det kommer automatiskt läggas till och kan lägga in själv också. De som är vit används och de grå används inte

public class PlayerLife : MonoBehaviour // Klassen
{
    private void OnCollisionEnter2D(Collision2D collision) // Kollision funktion, collision är det andra objectet vi kolliderat med 
    {
        Destroy(collision.gameObject); // förstör det vi kolliderade med
        gameObject.SetActive(false); // Disabla oss själva, eftersom att det är lättare att respawna
    }
}
