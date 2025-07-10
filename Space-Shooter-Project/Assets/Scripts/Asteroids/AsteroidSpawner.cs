using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// allt �vanf�r �r bonus kodpaket om ni undrar (Beh�ver inte kunna). Det kommer automatiskt l�ggas till och kan l�gga in sj�lv ocks�. De som �r vit anv�nds och de gr� anv�nds inte

public class AsteroidSpawner : MonoBehaviour // Klassen
{
    // Defenierade Variabler
    [SerializeField] GameObject asteroidPrefab;
    [SerializeField] float spawnCooldownTime;
    [SerializeField] float asteroidAmount;
    [SerializeField] float minRadius;
    [SerializeField] float maxRadius;
    
    void Start() // Start K�rs I b�rjan (innan f�rsta bild / frame)
    {
        InvokeRepeating(nameof(SpawnWave), 1f, spawnCooldownTime); // Invoke repeating repeterar en sak f�r evigt varge x sekunder. (beh�ver inte veta)
    }
    void SpawnWave() // V�ran Egen Funktion f�r Att separera koden. G�r det mer l�sbart
    {
        for (int i = 0; i < asteroidAmount; i++) //for loop g�r samma sak tills 1 �r lika med eller st�rre �n "asteroidAmount". f�r +1 varje g�ng genom i++
        {
            SpawnAsteroid(); // anropa v�ran egen funktion
        }
    }

    void SpawnAsteroid() // v�ran egnen funktion vi anropar
    {
        Vector2 spawnAngle = Random.insideUnitCircle.normalized; // H�mta en random vinkel. som att peka �t vilket h�ll som helst
        float distance = Random.Range(minRadius, maxRadius); // h�mta ett random avst�nd mellan Min och Max

        Vector2 spawnPosition = spawnAngle * distance; // g�ngra vinkel med avst�nd f�r att p� position f�r spawn

        Instantiate(asteroidPrefab, spawnPosition, Quaternion.identity); // spawna in v�ran prefab. Instansiate �r bra att kunna.
    }
}
