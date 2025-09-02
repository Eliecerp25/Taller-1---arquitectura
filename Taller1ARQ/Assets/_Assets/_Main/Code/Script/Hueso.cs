using UnityEngine;

public class Hueso : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag ("Player"))
        {
            Destroy(this.gameObject);
            gameManager.SumarPuntos(1);
        }

    }
}
