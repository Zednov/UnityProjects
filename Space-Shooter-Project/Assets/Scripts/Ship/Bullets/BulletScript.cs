using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// allt �vanf�r �r bonus kodpaket om ni undrar (Beh�ver inte kunna). Det kommer automatiskt l�ggas till och kan l�gga in sj�lv ocks�. De som �r vit anv�nds och de gr� anv�nds inte

public class BulletScript : MonoBehaviour // Klassen
{
    // Defenierade Variabler
    [SerializeField] float lifetime;
    void Start() // Start K�rs I b�rjan (innan f�rsta bild / frame)
    {
        Destroy(gameObject,lifetime); // F�rst�r kulan efter "lifetime" tid
    }

    private void OnCollisionEnter2D(Collision2D collision) // Kollision funktion, collision �r det andra objectet vi kolliderat med 
    {
        Destroy(collision.gameObject); // f�rst�r det vi kolliderade med
        Destroy(gameObject); // f�rst�r oss sj�lva (kulan)
    }
}
