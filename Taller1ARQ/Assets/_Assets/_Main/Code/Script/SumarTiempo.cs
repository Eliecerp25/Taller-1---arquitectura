using UnityEngine;

public class SumarTiempo : MonoBehaviour
{
    public GameManager gameManager;

    [SerializeField]
    private float extraTime = 10f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
            gameManager.AddTime(extraTime);
        }
    }
}

