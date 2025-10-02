using UnityEngine;

public class Puerta : MonoBehaviour
{
  public GameManager gameManager;
    public UIManager uiManager;

   private void OnTriggerEnter2D(Collider2D collision)
   {
       if (collision.CompareTag("Player"))
       {
           if (gameManager.actKey == true)  // si el jugador tiene la llave
           {
                gameManager.EstadoDelJuego("Ganaste");
           }
           else
           {
                uiManager.ActualizarUI("TextoNoLLave");
            }
       }
   }

  

}
   