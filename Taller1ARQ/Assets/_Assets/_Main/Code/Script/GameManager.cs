using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameManager : MonoBehaviour
{

    [SerializeField]
    private int vida;
    public int actVida
    {
        get { return vida; }
        set { }
    }

    [SerializeField]
    private int puntos;

    public int actPuntos
    {
        get { return vida; }
        set { }
    }


    [SerializeField]
    private GameObject Obstaculo;

    [SerializeField]
    private bool KeyActive = false;

    [SerializeField]
    private UIManager uiManager;


    public void SumarPuntos(int cantidad)
    {
        puntos += cantidad;
        uiManager.ActualizarUI("textoPuntos");

        if (puntos>=10)
        {
            Destroy(Obstaculo);
        }
    }

    public void RestarVidas(int cantidad)
    {
        vida -= cantidad;
        uiManager.ActualizarUI("textoVida");

        if (vida == 0)
        {
            SceneManager.LoadScene("Taller");
        }
    }

    public void SumarVida(int cantidad)
    {
        vida += cantidad;
        uiManager.ActualizarUI("textoVida");
    }

    public void KeyHolder(bool keyTrue)
    {
        KeyActive = keyTrue;
       // StartCoroutine(MostrarMensajes());
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
                Time.timeScale = 0;
                break;

            case "Reanudar":
                Time.timeScale = 1;
                break;

            case "Jugando":
                break;
        }
    }


}
