using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public int vida;

    public int puntos;

    [SerializeField]
    private TMP_Text textoPuntos;

    [SerializeField]
    private TMP_Text textoVida;

    [SerializeField]
    private TMP_Text textoLlave;

    public TMP_Text textoGame;

    [SerializeField]
    private GameObject Obstaculo;

    public bool KeyActive = false;

    public void SumarPuntos(int cantidad)
    {
        puntos += cantidad;
        ActualizarUI("textoPuntos");

        if (puntos>=10)
        {
            Destroy(Obstaculo);
        }
    }

    public void RestarVidas(int cantidad)
    {
        vida -= cantidad;
        ActualizarUI("textoVida");

        if (vida == 0)
        {
            SceneManager.LoadScene("Taller");
        }
    }

    public void SumarVida(int cantidad)
    {
        vida += cantidad;
        textoVida.text = "Vida: " + vida;
        ActualizarUI("textoVida");
    }

    public void KeyHolder(bool keyTrue)
    {
        KeyActive = keyTrue;
        StartCoroutine(MostrarMensajes());
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

    public void ActualizarUI(string texto)
    {
        switch (texto) 
        {
            case "textoVida":
                textoVida.text = "Vida: " + vida;
                break;

            case "textoPuntos":
                textoPuntos.text = "Puntos: " + puntos;
                break;

            case "textoLlave":
                StartCoroutine(MostrarMensajes());
                break;
        }
    }

    public void EstadoDelJuego(string estado)
    {
        switch (estado) 
        {
            case "Ganaste":
                break;

            case "Perdiste":
                break;

            case "Pausa":
                break;

            case "Jugando":
                break;
        }
    }


}
