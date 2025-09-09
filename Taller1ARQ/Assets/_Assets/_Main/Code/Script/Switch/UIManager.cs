using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TMP_Text textIntroduccion;
    [SerializeField] private TMP_InputField InputField;
    [SerializeField] private TMP_InputField InputFieldnombre;

    private string nombre;
    private int edad;
    //si mi jugador es menor de 12 años es un niño
    //si mi jugador es mayor de 12 años pero menor a 18 es un adolescente
    // si mi jugador es mayor de 18 años pero menor a 25 es un adulto joven
    //si mi jugador es mayor de 25 años pero menor a 60 es un adulto
    //si mi jugador es mayor de 60 años es un adulto mayor


    private void Start()
    {
        textIntroduccion.text = "Introduce tu edad";
    }

    public void CalcularGrupo()
    {
        edad = int.Parse(InputField.text);

        switch (edad)
        {
            case 20:
                textIntroduccion.text=("¡Tienes 20 años!");
                break;
        }

    }
}






        /*
        if (edad <= 12 ) 
        {
            Debug.Log("Eres un niño");
        }
        else if (edad > 12 && edad<18 ) 
        {
            Debug.Log("Eres un adolescente");
        }
        else if (edad >= 18 && edad < 25)
        {
            Debug.Log("Eres un adulto joven");
        }
        else if (edad >= 25 && edad < 60)
        {
            Debug.Log("Eres un adulto");
        }
        else if (edad >= 60)
        {
            Debug.Log("Eres un adulto mayor");
        }
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
*/