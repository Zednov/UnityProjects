using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// allt �vanf�r �r bonus kodpaket om ni undrar (Beh�ver inte kunna). Det kommer automatiskt l�ggas till och kan l�gga in sj�lv ocks�. De som �r vit anv�nds och de gr� anv�nds inte

public class PlayerLife : MonoBehaviour // Klassen
{
    private void OnCollisionEnter2D(Collision2D collision) // Kollision funktion, collision �r det andra objectet vi kolliderat med 
    {
        Destroy(collision.gameObject); // f�rst�r det vi kolliderade med
        gameObject.SetActive(false); // Disabla oss sj�lva, eftersom att det �r l�ttare att respawna
    }
}
