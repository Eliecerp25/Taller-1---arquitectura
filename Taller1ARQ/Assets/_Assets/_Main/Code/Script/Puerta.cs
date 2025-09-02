using UnityEngine;
using System.Collections; // necesario para IEnumerator

public class Puerta : MonoBehaviour
{
    public GameManager gameManager; // referencia al GameManager

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (gameManager.KeyActive) // si el jugador tiene la llave
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

    private IEnumerator MostrarMensajeTemporal(string mensaje, float duracion)
    {
        gameManager.textoGame.text = mensaje;
        yield return new WaitForSeconds(duracion);
        gameManager.textoGame.text = ""; // ⚡ lo borramos después del tiempo
    }

void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
