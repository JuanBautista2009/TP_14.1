using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionArea : MonoBehaviour
{
    private UIManager uiManager;

    void Start()
    {
        uiManager = FindObjectOfType<UIManager>();
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Pickable")){
            Destroy(col.gameObject);
            uiManager.SumarPunto();
        }
    }
}