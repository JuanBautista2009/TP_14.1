using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI puntaje;
    public TextMeshProUGUI timer;
    public TextMeshProUGUI YouWon;
    public TextMeshProUGUI GameOver;

    private float tiempoRestante = 120f;
    private int score = 0;
    private bool juegoTerminado = false;

    void Start()
    {
        // Seguridad: Solo los desactiva si los arrastraste al Inspector
        if (YouWon != null) YouWon.gameObject.SetActive(false);
        if (GameOver != null) GameOver.gameObject.SetActive(false);
    }

    void Update()
    {
        if (juegoTerminado) return;

        if (tiempoRestante > 0)
        {
            tiempoRestante -= Time.deltaTime;
        }
        else
        {
            tiempoRestante = 0;
            juegoTerminado = true;
            if (GameOver != null) GameOver.gameObject.SetActive(true);
        }

        int minutos = Mathf.FloorToInt(tiempoRestante / 60);
        int segundos = Mathf.FloorToInt(tiempoRestante % 60);

        // Seguridad: Evita que el juego falle si falta asignar la UI
        if (timer != null) timer.text = string.Format("{0:00}:{1:00}", minutos, segundos);
        if (puntaje != null) puntaje.text = "Score: " + score.ToString();
    }

    public void SumarPunto()
    {
        if (juegoTerminado) return;

        score++;

        if (score >= 7)
        {
            juegoTerminado = true;
            if (YouWon != null) YouWon.gameObject.SetActive(true);
        }
    }
}