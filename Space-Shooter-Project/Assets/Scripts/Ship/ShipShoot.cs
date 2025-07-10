using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// allt åvanför är bonus kodpaket om ni undrar (Behöver inte kunna). Det kommer automatiskt läggas till och kan lägga in själv också. De som är vit används och de grå används inte

public class ShipShoot : MonoBehaviour // Klassen
{
    // Defenierade Variabler
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] GameObject firePosition;
    [SerializeField] float bulletSpeed;

    void Update() // Update Körs Varge bild / frame
    {
        if(Input.GetKeyDown("space")) // om (vi trycker på space)
        {
            Shoot(); // anropa våran egen funktion
        }
    }

    void Shoot() // våran egen funktion vi anropar
    {
        GameObject bullet = Instantiate(bulletPrefab, firePosition.transform.position, firePosition.transform.rotation); // spawner in våran kula men behåller bullet som en egen variabel som vi använder sen
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>(); // hämtar rigidbody2d component från bullet

        rb.velocity = firePosition.transform.up * bulletSpeed; // sätter hastighet på kular i riktningen / rotationen av firepostition
    }
}
