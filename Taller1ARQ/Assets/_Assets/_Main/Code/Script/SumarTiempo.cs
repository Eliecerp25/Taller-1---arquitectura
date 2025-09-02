using UnityEngine;

public class SumarTiempo : MonoBehaviour
{
    public float tiempoExtra = 10f; // segundos a sumar

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // cuando el jugador lo toca
        {
            // Buscar el Timer en la escena
            Tiempo timer = FindObjectOfType<Tiempo>();
            if (timer != null)
            {
                timer.SumarTiempo(tiempoExtra); // usamos el método correcto
            }

            // Destruir el objeto para que no se use otra vez
            Destroy(gameObject);
        }
    }
}
