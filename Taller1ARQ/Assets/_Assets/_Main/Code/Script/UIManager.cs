using UnityEngine;
using UnityEngine.UI;
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

    public TextMeshProUGUI timerText;


    [SerializeField] 
    private Image[] corazones;

    [SerializeField] 
    private Sprite VidaSprite;

    [SerializeField] 
    private Sprite NoVidaSprite;


    public void ActualizarUI(string texto)
    {
        switch (texto)
        {
            case "textoVida":
                ActualizarCorazones(gameManager.actVida);
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

            case "TiempoUI":
               timerText.text = "TIEMPO: " + Mathf.Ceil(gameManager.actTimeLeft).ToString();
                break;

        }
    }

    private void ActualizarCorazones(int vidas)
    {
        for (int i = 0; i < corazones.Length; i++)
        {
            if (i < vidas)
            {
                corazones[i].sprite = VidaSprite;
            }
            else
            {
                corazones[i].sprite = NoVidaSprite;
            }
        }
    }


    private IEnumerator MostrarMensajes()
    { 
        textoLlave.text = "Ya tienes la llave.\nBusca la puerta...";
        yield return new WaitForSeconds(3f);

        textoLlave.text = "Correeee, se te acaba el tiempo!!!";
        yield return new WaitForSeconds(3f);

        textoLlave.text = "";
    }

    

    public IEnumerator MostrarMensajeNoLave(string mensaje, float duracion)
    {
        textoGame.text = mensaje;
        yield return new WaitForSeconds(duracion);
        textoGame.text = ""; 
    }
}
        