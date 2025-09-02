using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tiempo : MonoBehaviour
{
    public float timeLeft = 60f;
    public TextMeshProUGUI timerText;

    private bool ended = false; // evita que la escena se cargue varias veces

    void Update()
    {
        // Restamos el tiempo
        timeLeft -= Time.deltaTime;

        // Que no baje de 0
        if (timeLeft <= 0 && !ended)
        {
            timeLeft = 0;
            ended = true;
            SceneManager.LoadScene("Taller"); // asegúrate de que "Taller" esté en Build Settings
        }

        // Mostramos el tiempo en pantalla (segundos enteros)
        timerText.text = "TIEMPO: " + Mathf.Ceil(timeLeft).ToString();
    }

    // 👉 Método correcto para sumar tiempo (puedes llamarlo desde otro script)
    public void SumarTiempo(float segundos)
    {
        timeLeft += segundos;
    }
}
