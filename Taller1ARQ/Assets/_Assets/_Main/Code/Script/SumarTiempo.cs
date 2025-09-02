using UnityEngine;

public class SumarTiempo : MonoBehaviour
{
    public Tiempo timer;
    private float extraTime = 10f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
            timer.AddTime(extraTime);
        }
    }
}

