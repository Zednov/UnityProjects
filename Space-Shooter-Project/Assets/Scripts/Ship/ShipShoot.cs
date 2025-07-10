using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// allt �vanf�r �r bonus kodpaket om ni undrar (Beh�ver inte kunna). Det kommer automatiskt l�ggas till och kan l�gga in sj�lv ocks�. De som �r vit anv�nds och de gr� anv�nds inte

public class ShipShoot : MonoBehaviour // Klassen
{
    // Defenierade Variabler
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] GameObject firePosition;
    [SerializeField] float bulletSpeed;

    void Update() // Update K�rs Varge bild / frame
    {
        if(Input.GetKeyDown("space")) // om (vi trycker p� space)
        {
            Shoot(); // anropa v�ran egen funktion
        }
    }

    void Shoot() // v�ran egen funktion vi anropar
    {
        GameObject bullet = Instantiate(bulletPrefab, firePosition.transform.position, firePosition.transform.rotation); // spawner in v�ran kula men beh�ller bullet som en egen variabel som vi anv�nder sen
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>(); // h�mtar rigidbody2d component fr�n bullet

        rb.velocity = firePosition.transform.up * bulletSpeed; // s�tter hastighet p� kular i riktningen / rotationen av firepostition
    }
}
