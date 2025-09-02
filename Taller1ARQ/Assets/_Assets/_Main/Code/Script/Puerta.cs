using UnityEngine;
using System.Collections; // necesario para IEnumerator

public class Puerta : MonoBehaviour
{
    public GameManager gameManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (gameManager.KeyActive)  // si el jugador tiene la llave
            {
                gameManager.textoGame.text = "¡¡¡GANASTE!!!";
                Time.timeScale = 0f; // pausa el juego
            }
            else
            {
                StartCoroutine(MostrarMensajeTemporal("Todavia no tienes la llave.", 3f));
            }
        }
    }

    private IEnumerator MostrarMensajeTemporal(string mensaje, float duracion)//IEnumerator para darle funcionalidad a la corotina y mostrar mensaje en un determinado tiempo y momento
    {
        gameManager.textoGame.text = mensaje;
        yield return new WaitForSeconds(duracion);// yield return determina el tiempo de espera del mensaje
        gameManager.textoGame.text = ""; // sirve para borrar después del tiempo
    }
}
