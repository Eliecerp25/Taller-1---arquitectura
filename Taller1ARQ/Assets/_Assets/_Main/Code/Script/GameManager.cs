using TMPro;
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

    [SerializeField]
    private float timeLeft = 120f;

    public float actTimeLeft
    {
        get { return timeLeft; }
        set { }
    }



    public void Start()
    {
        uiManager.ActualizarUI("textoVida");
        uiManager.ActualizarUI("textoPuntos");
        uiManager.ActualizarUI("TiempoUI");
    }

    public void Update()
    {
        //Funcion ESCAPE
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

        //Tiempo
        timeLeft -= Time.deltaTime;
        uiManager.ActualizarUI("TiempoUI");


        if (timeLeft <= 0)
        {
            EstadoDelJuego("Perdiste");
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

    public void AddTime(float extraTime)
    {
        timeLeft += extraTime;
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

        }
    }


}
