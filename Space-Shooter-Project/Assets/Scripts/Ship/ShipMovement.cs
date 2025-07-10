using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;
// allt �vanf�r �r bonus kodpaket om ni undrar (Beh�ver inte kunna). Det kommer automatiskt l�ggas till och kan l�gga in sj�lv ocks�. De som �r vit anv�nds och de gr� anv�nds inte

public class ShipMovement : MonoBehaviour // Klassen
{
    // Defenierade Variabler
    Rigidbody2D rb;
    [SerializeField] float rotateSpeed;
    [SerializeField] float moveSpeed;
    void Start() // Start K�rs I b�rjan (innan f�rsta bild / frame)
    {
        rb = GetComponent<Rigidbody2D>(); // H�mta Rigidbody Component

        
    }

    void FixedUpdate() // Update K�rs Varge bild / frame
    {
        float moveX = Input.GetAxis("Horizontal"); // H�mta v�nster - h�ger input. Kommer som en siffra mellan -1 0ch 1
        float moveY = Input.GetAxis("Vertical"); // H�mta upp - ner input. Kommer som en siffra mellan -1 0ch 1

        rb.MoveRotation(rb.rotation-moveX*rotateSpeed); // rotera efter moveX * hastighet
        rb.AddForce(transform.up*moveY*moveSpeed); // L�gg till kraft I uppriktning, hastighet * moveY
    }
}
