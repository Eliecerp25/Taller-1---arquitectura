using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class GameManager : MonoBehaviour
{
    public int vida;

    public int puntos;

    [SerializeField]
    private TMP_Text textoPuntos;

    [SerializeField]
    private TMP_Text textoVida;

    [SerializeField]
    private GameObject Obstaculo;

    public void SumarPuntos(int cantidad)
    {
        puntos += cantidad;
        textoPuntos.text = "Puntos: " + puntos;

        if (puntos==10)
        {
            Destroy(Obstaculo);
        }
    }

    public void RestarVidas(int cantidad)
    {
        vida -= cantidad;
        textoVida.text = "Vida: " + vida;

        if (vida == 0)
        {
            SceneManager.LoadScene("Taller");
        }
    }

    public void SumarVida(int cantidad)
    {
        vida += cantidad;
        textoVida.text = "Vida: " + vida;
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
