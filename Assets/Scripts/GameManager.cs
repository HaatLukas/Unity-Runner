using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    // Singleton - Jeden konrektny element w ca³ym projekcie

    public static GameManager settings; // Tworzymy jeden konrektny
    // obiekt dla ustawieñ

    // Ile mamy punktów
    private float score;

    public Text scoreText; //Wynik wyœwietlany tekstowo

    private void FixedUpdate()
    {
        score += worldSpeed;
        scoreText.text = score.ToString("0");
    }

    public float worldSpeed = 0.2f;
    private void Start()
    {
        // Zawsze na scenie/grze bêdzie tylko jeden GameManager
        if (settings == null)
        {
            settings = this;
        }
    }



}
