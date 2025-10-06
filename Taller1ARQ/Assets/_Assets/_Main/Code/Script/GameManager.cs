using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private UIManager uiManager;

    [SerializeField]
    private GameObject Obstaculo;

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
        get { return puntos; }
        set { }
    }

    [SerializeField]
    private bool KeyActive = false;
    public bool actKey
    {
        get { return KeyActive; }
        set { }
    }
    [SerializeField]
    private bool juegoPausado = false; 

    public void Start()
    {
        uiManager.ActualizarUI("textoVida");
        uiManager.ActualizarUI("textoPuntos");
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (juegoPausado)
            {
                EstadoDelJuego("Reanudar");
                uiManager.ActualizarUI("ReanudarUI"); 
                juegoPausado = false;
            }
            else
            {
                EstadoDelJuego("Pausa");
                uiManager.ActualizarUI("PausaUI");
                juegoPausado = true;
            }
        }
    }


    public void SumarPuntos(int cantidad)
    {
        puntos += cantidad;
        uiManager.ActualizarUI("textoPuntos");

        if (actPuntos>=10)
        {
            Destroy(Obstaculo);
        }
    }
    public void SumarVida(int cantidad)
    {
        if (vida < 5)
        {
            vida += cantidad;
            uiManager.ActualizarUI("textoVida");
        }

    }

    public void RestarVidas(int cantidad)
    {
        vida -= cantidad;
        uiManager.ActualizarUI("textoVida");

        if (vida == 0)
        {
            EstadoDelJuego("Perdiste");
        }
    }

    public void KeyHolder(bool keyTrue)
    {
        KeyActive = keyTrue;
        uiManager.ActualizarUI("textoLlave");
    }

    public void EstadoDelJuego(string estado)
    {
        switch (estado) 
        {
            case "Ganaste":
                SceneManager.LoadScene(2);
                break;

            case "Perdiste":
                SceneManager.LoadScene(3);
                break;

            case "Pausa":
                Time.timeScale = 0;
                break;

            case "Reanudar":
                Time.timeScale = 1;
                break;

            case "Reiniciar":
                Time.timeScale = 1;
                SceneManager.LoadScene(1);
                break;

            case "Jugando":
                break;
        }
    }


}
