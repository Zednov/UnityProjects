using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// allt �vanf�r �r bonus kodpaket om ni undrar (Beh�ver inte kunna). Det kommer automatiskt l�ggas till och kan l�gga in sj�lv ocks�. De som �r vit anv�nds och de gr� anv�nds inte

public class AsteroidScript : MonoBehaviour // Klassen
{
    // Defenierade Variabler
    [SerializeField] float moveSpeed;
    Rigidbody2D rb;
    
    void Start() // Start K�rs I b�rjan (innan f�rsta bild / frame)
    {
        rb = GetComponent<Rigidbody2D>(); // H�mta Component

        Vector2 directionToCenter = (new Vector2(0,0) - rb.position).normalized;

        Vector2 randomDirection = Random.insideUnitCircle.normalized;

        rb.AddForce(directionToCenter*moveSpeed);
        rb.AddForce(randomDirection*moveSpeed*0.5f);
    }
}
