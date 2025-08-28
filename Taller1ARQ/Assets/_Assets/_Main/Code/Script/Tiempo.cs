using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tiempo : MonoBehaviour
{
    public float timeLeft = 60f;
    public TextMeshProUGUI timerText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Restamos el tiempo
        timeLeft -= Time.deltaTime;

        // Que no baje de 0
        if (timeLeft < 0) timeLeft = 0;

        if (timeLeft == 0)
        {
            SceneManager.LoadScene("Taller");
        }

        // Mostramos el tiempo en pantalla (segundos enteros)
        timerText.text = "TIEMPO: " + Mathf.Ceil(timeLeft).ToString();
    }
}
