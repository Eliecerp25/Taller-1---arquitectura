using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System.Collections;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private TMP_Text textoPuntos;

    [SerializeField]
    private TMP_Text textoVida;

    [SerializeField]
    private TMP_Text textoLlave;

    public TMP_Text textoGame;

    [SerializeField]
    private GameManager gameManager;

    public void ActualizarUI(string texto)
    {
        switch (texto)
        {
            case "textoVida":
                textoVida.text = "Vida: " + gameManager.actVida;

                break;

            case "textoPuntos":
                textoPuntos.text = "Puntos: " + gameManager.actPuntos;
                break;

            case "textoLlave":
                StartCoroutine(MostrarMensajes());
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
}






        