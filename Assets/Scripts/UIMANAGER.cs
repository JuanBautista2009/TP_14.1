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
        YouWon.gameObject.SetActive(false);
        GameOver.gameObject.SetActive(false);
    }

    void Update()
    {
        if (juegoTerminado) return;

        if (tiempoRestante > 0){
            tiempoRestante -= Time.deltaTime;
        }
        else{
            tiempoRestante = 0;
            juegoTerminado = true;
            GameOver.gameObject.SetActive(true);
        }

        int minutos = Mathf.FloorToInt(tiempoRestante / 60);
        int segundos = Mathf.FloorToInt(tiempoRestante % 60);

        timer.text = string.Format("{0:00}:{1:00}", minutos, segundos);
        puntaje.text = "Score: " + score.ToString();
    }

    public void SumarPunto()
    {
        if (juegoTerminado) return;

        score++;

        if (score >= 7){
            juegoTerminado = true;
            YouWon.gameObject.SetActive(true);
        }
    }
}