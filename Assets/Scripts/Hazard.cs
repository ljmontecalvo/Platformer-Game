using System;
using UnityEngine;

public class Hazard : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("1");
        if (!col.CompareTag("Player")) return;
        col.GetComponent<PlayerController>().Kill();
    }
}
