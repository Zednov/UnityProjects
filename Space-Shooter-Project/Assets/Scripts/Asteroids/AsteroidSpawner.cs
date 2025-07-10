using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// allt åvanför är bonus kodpaket om ni undrar (Behöver inte kunna). Det kommer automatiskt läggas till och kan lägga in själv också. De som är vit används och de grå används inte

public class AsteroidSpawner : MonoBehaviour // Klassen
{
    // Defenierade Variabler
    [SerializeField] GameObject asteroidPrefab;
    [SerializeField] float spawnCooldownTime;
    [SerializeField] float asteroidAmount;
    [SerializeField] float minRadius;
    [SerializeField] float maxRadius;
    
    void Start() // Start Körs I början (innan första bild / frame)
    {
        InvokeRepeating(nameof(SpawnWave), 1f, spawnCooldownTime); // Invoke repeating repeterar en sak för evigt varge x sekunder. (behöver inte veta)
    }
    void SpawnWave() // Våran Egen Funktion för Att separera koden. Gör det mer läsbart
    {
        for (int i = 0; i < asteroidAmount; i++) //for loop gör samma sak tills 1 är lika med eller större än "asteroidAmount". får +1 varje gång genom i++
        {
            SpawnAsteroid(); // anropa våran egen funktion
        }
    }

    void SpawnAsteroid() // våran egnen funktion vi anropar
    {
        Vector2 spawnAngle = Random.insideUnitCircle.normalized; // Hämta en random vinkel. som att peka åt vilket håll som helst
        float distance = Random.Range(minRadius, maxRadius); // hämta ett random avstånd mellan Min och Max

        Vector2 spawnPosition = spawnAngle * distance; // gångra vinkel med avstånd för att på position för spawn

        Instantiate(asteroidPrefab, spawnPosition, Quaternion.identity); // spawna in våran prefab. Instansiate är bra att kunna.
    }
}
