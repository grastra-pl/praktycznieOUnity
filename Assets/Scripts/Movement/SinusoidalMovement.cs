using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinusoidalMovement : MonoBehaviour
{
    public float amplitude = 1f;  // Amplituda sinusoidy
    public float frequency = 1f;  // Częstotliwość sinusoidy
    public float speed = 1f;      // Prędkość poruszania

    private Vector3 startPosition;
    private bool shouldMove = true;
    private float rightLimit;

    void Start()
    {
        startPosition = transform.position;

        // Pobieranie wartości RightLimit z innego skryptu
        Limits limitsScript = FindObjectOfType<Limits>();
        if (limitsScript != null)
        {
            rightLimit = limitsScript.RightLimit;
        }
        else
        {
            Debug.LogWarning("Nie można znaleźć skryptu Limits.");
        }
    }

    void Update()
    {
        if (!shouldMove)
            return;

        // Obliczanie nowej pozycji na podstawie czasu
        float time = Time.time * speed;
        float newY = Mathf.Sin(time * frequency) * amplitude;
        float newX = transform.position.x + Time.deltaTime * speed;  // Poruszanie się w prawo
        Vector3 newPosition = new Vector3(newX, startPosition.y + newY, transform.position.z);

        // Sprawdzanie czy osiągnięto limit
        if (newX >= rightLimit)
        {
            newPosition.x = rightLimit;  // Ustawianie dokładnej pozycji x na limit po prawej stronie
            shouldMove = false;          // Zatrzymywanie poruszania się
        }

        // Ustawianie nowej pozycji obiektu
        transform.position = newPosition;
    }
}
