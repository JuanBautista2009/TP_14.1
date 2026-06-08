using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InteractionArea : MonoBehaviour
{
    public TextMeshProUGUI puntaje;
    public TextMeshProUGUI timer;
    
    [SerializeField] private float tiempoRestante = 120f; 
    public int score = 0;

    void Update(){
        int minutos = Mathf.FloorToInt(tiempoRestante / 60);
        int segundos = Mathf.FloorToInt(tiempoRestante % 60);
        timer.text = string.Format("{0:00}:{1:00}", minutos, segundos);
        puntaje.text = "Score: " + score.ToString();

        if (tiempoRestante > 0)
        {
            tiempoRestante -= Time.deltaTime;

            if (tiempoRestante < 0)
            {
                tiempoRestante = 0;
                TerminarJuego();
            }
        }
    }

    void OnTriggerEnter(Collider col){
        if (col.gameObject.CompareTag("Pickable"))
        {
            Destroy(col.gameObject);
            score++;
            Debug.Log("Puntaje: " + score);
        }
    }

    void GameOver(){
        Debug.Log("¡Tiempo agotado!");
    }

    void YouWon(){

    }
}
