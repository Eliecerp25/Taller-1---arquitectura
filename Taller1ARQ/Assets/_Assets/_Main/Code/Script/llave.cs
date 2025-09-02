using UnityEngine;

public class llave : MonoBehaviour
{
    public GameManager gameManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gameManager.KeyHolder(true);

            Destroy(this.gameObject);

        }
    }
}