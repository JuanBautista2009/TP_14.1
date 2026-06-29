using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionArea : MonoBehaviour
{
    private UIMANAGER uiManager;

    void Start()
    {
        uiManager = FindObjectOfType<UIMANAGER>();
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Pickable")){
            Destroy(col.gameObject);
            uiManager.SumarPunto();
        }
    }
}