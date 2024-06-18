using UnityEngine;

public class ExitBox : MonoBehaviour
{
    public GameObject winText;
    
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            winText.SetActive(true);
        }
    }
}
