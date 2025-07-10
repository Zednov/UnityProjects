using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;
// allt åvanför är bonus kodpaket om ni undrar (Behöver inte kunna). Det kommer automatiskt läggas till och kan lägga in själv också. De som är vit används och de grå används inte

public class ShipMovement : MonoBehaviour // Klassen
{
    // Defenierade Variabler
    Rigidbody2D rb;
    [SerializeField] float rotateSpeed;
    [SerializeField] float moveSpeed;
    void Start() // Start Körs I början (innan första bild / frame)
    {
        rb = GetComponent<Rigidbody2D>(); // Hämta Rigidbody Component

        
    }

    void FixedUpdate() // Update Körs Varge bild / frame
    {
        float moveX = Input.GetAxis("Horizontal"); // Hämta vänster - höger input. Kommer som en siffra mellan -1 0ch 1
        float moveY = Input.GetAxis("Vertical"); // Hämta upp - ner input. Kommer som en siffra mellan -1 0ch 1

        rb.MoveRotation(rb.rotation-moveX*rotateSpeed); // rotera efter moveX * hastighet
        rb.AddForce(transform.up*moveY*moveSpeed); // Lägg till kraft I uppriktning, hastighet * moveY
    }
}
