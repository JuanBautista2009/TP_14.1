using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIMANAGER : MonoBehaviour
{
    [Header("Componentes de Texto UI")]
    public TextMeshProUGUI puntaje;
    public TextMeshProUGUI timer;
    public TextMeshProUGUI YouWon;
    public TextMeshProUGUI GameOver;

    [Header("Configuración del Juego")]
    private float tiempoRestante = 40f;
    private int score = 0;
    private bool juegoTerminado = false;

    void Start(){
        if (YouWon != null) YouWon.gameObject.SetActive(false);
        if (GameOver != null) GameOver.gameObject.SetActive(false);
    }

    void Update(){
        if (juegoTerminado) return;

        if (tiempoRestante > 0){
            tiempoRestante -= Time.deltaTime;
        }
        else{
            tiempoRestante = 0;
            juegoTerminado = true;
            if (GameOver != null) GameOver.gameObject.SetActive(true);
        }

        int minutos = Mathf.FloorToInt(tiempoRestante / 60);
        int segundos = Mathf.FloorToInt(tiempoRestante % 60);

        if (timer != null) timer.text = string.Format("{0:00}:{1:00}", minutos, segundos);

        if (puntaje != null) puntaje.text = "Score: " + score.ToString();
    }

    public void SumarPunto(){
        if (juegoTerminado) return;
        score++;

        if (score >= 7){
            juegoTerminado = true;
            if (YouWon != null) YouWon.gameObject.SetActive(true);
        }
    }
}