using UnityEngine;

public class PlayerControl : MonoBehaviour
{ 
[SerializeField]
    private Rigidbody2D _rb2d;
[SerializeField]
private float _fuerzaSalto;
[SerializeField]
private Vector2 direccionSalto = new Vector2();
void Start()
{

}

// Update is called once per frame
void Update()
{
    if (Input.GetKeyDown(KeyCode.RightArrow))
    {
        _rb2d.AddForce(new Vector2(100,10 * _fuerzaSalto));
    }

    if (Input.GetKeyDown(KeyCode.LeftArrow))
    {
        _rb2d.AddForce(new Vector2(-100,10 * _fuerzaSalto));
    }

    if (Input.GetKeyDown(KeyCode.Space))
    {
        _rb2d.AddForce(new Vector2(0,10)* _fuerzaSalto);
    }
}
}
