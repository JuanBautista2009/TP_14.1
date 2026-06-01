using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionArea : MonoBehaviour
{
    public int score = 0;
    void Start()
    {
         
    }
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider col){
        if (col.gameObject.CompareTag("Pickable")){
            Destroy(col.gameObject);
            score ++;
            Debug.Log("Puntaje: " + score);
        }
    }
}
