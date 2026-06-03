using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InteractionArea : MonoBehaviour
{
    public TextMeshProUGUI puntaje;
    public TextMeshProUGUI timer;
    private float tiempoTranscurrido = 0f;
    public int score = 0;
    void Start()
    {
        
    }
    void Update()
    {
       
        puntaje.text = "Score" + ":" + score.ToString();
        tiempoTranscurrido += Time.deltaTime;
        int minutos = Mathf.FloorToInt(tiempoTranscurrido / 60);
        int segundos = Mathf.FloorToInt(tiempoTranscurrido % 60);
        timer.text = string.Format("{0:00}:{1:00}", minutos, segundos);
    }
    void OnTriggerEnter(Collider col){
        if (col.gameObject.CompareTag("Pickable")){
            Destroy(col.gameObject);
            score ++;
            Debug.Log("Puntaje: " + score);
        }
    }
}
