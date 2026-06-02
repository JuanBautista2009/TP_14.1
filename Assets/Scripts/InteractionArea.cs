using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InteractionArea : MonoBehaviour
{
    public TextMeshProUGUI puntaje;
    public int score = 0;
    void Start()
    {
         puntaje.gameObject.SetActive(false);
    }
    void Update()
    {
        puntaje.gameObject.SetActive(true);
        puntaje.text = "Score" + ":" + score.ToString();
    }
    void OnTriggerEnter(Collider col){
        if (col.gameObject.CompareTag("Pickable")){
            Destroy(col.gameObject);
            score ++;
            Debug.Log("Puntaje: " + score);
        }
    }
}
