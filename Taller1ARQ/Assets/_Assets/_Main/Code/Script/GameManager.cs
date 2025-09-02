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

        // lo dejas vacío (opcional)
        textoLlave.text = "";
    }


}
