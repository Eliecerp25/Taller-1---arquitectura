using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tiempo : MonoBehaviour
{
    private float timeLeft = 120f; // tiempo inicial del contador en segundos
    public TextMeshProUGUI timerText;

    void Update()
    {
        timeLeft -= Time.deltaTime;

        if (timeLeft <= 0)
        {
            SceneManager.LoadScene("Taller"); // vuelve a cargar la escena
        }

        timerText.text = "TIEMPO: " + Mathf.Ceil(timeLeft).ToString(); // muestra en pantalla el tiempo restante
    }

    public void AddTime(float extraTime)
    {
        timeLeft += extraTime;
    }
}



