using UnityEngine;
using TMPro;
using System.Collections;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private GameObject CanvaPausa;

    [SerializeField]
    private TMP_Text textoPuntos;

    [SerializeField]
    private TMP_Text textoVida;

    [SerializeField]
    private TMP_Text textoLlave;

    [SerializeField]
    private TMP_Text textoGame;

    [SerializeField]
    private GameManager gameManager;

    public void ActualizarUI(string texto)
    {
        switch (texto)
        {
            case "textoVida":
                textoVida.text = "VIDA: " + gameManager.actVida;

                break;

            case "textoPuntos":
                textoPuntos.text = "PUNTOS: " + gameManager.actPuntos;
                break;

            case "textoLlave":
                StartCoroutine(MostrarMensajes());
                break;

            case "TextoNoLLave":
                StartCoroutine(MostrarMensajeNoLave("Aún no tienes la llave ;(", 3f));
                break;

            case "PausaUI":
                CanvaPausa.SetActive(true);
                break;

            case "ReanudarUI":
                CanvaPausa.SetActive(false);
                break;
        }
    }


    private IEnumerator MostrarMensajes() //IEnumerator para darle funcionalidad a la corotina y mostrar mensaje en un determinado tiempo y momento
    {
        // Primer mensaje
        textoLlave.text = "Ya tienes la llave.\nBusca la puerta...";
        yield return new WaitForSeconds(3f);

        // Segundo mensaje
        textoLlave.text = "Correeee, se te acaba el tiempo!!!";
        yield return new WaitForSeconds(3f);

        // lo deja vacío (opcional)
        textoLlave.text = "";
    }

    public IEnumerator MostrarMensajeNoLave(string mensaje, float duracion)//IEnumerator para darle funcionalidad a la corotina y mostrar mensaje en un determinado tiempo y momento
    {
        textoGame.text = mensaje;
        yield return new WaitForSeconds(duracion);// yield return determina el tiempo de espera del mensaje
        textoGame.text = ""; // sirve para borrar después del tiempo
    }
}
        