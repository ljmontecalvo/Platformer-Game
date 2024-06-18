using UnityEngine;

public class ExitBox : MonoBehaviour
{
    public GameObject winText;
    
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            winText.SetActive(true);
        }
    }
}
