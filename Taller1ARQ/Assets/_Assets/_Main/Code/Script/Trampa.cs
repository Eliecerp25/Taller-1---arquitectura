using UnityEngine;
using UnityEngine.SceneManagement;

public class Trampa : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gameManager.RestarVidas(1);
        }
    }
}
