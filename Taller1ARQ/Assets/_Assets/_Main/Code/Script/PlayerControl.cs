using UnityEngine;

public class PlayerControl : MonoBehaviour
{ 
[SerializeField]
    private Rigidbody2D _rb2d;
[SerializeField]
private float _fuerzaSalto;
[SerializeField]
private Vector2 direccionSalto = new Vector2(100,10);
void Start()
{

}

// Update is called once per frame
void Update()
{
    if (Input.GetKeyDown(KeyCode.D))
    {
        _rb2d.AddForce(direccionSalto * _fuerzaSalto);
    }

    if (Input.GetKey(KeyCode.A))
    {
        _rb2d.AddForce(new Vector2(-100,10 * _fuerzaSalto));
    }

    if (Input.GetKeyDown(KeyCode.W))
    {
        _rb2d.AddForce(new Vector2(0,10)* _fuerzaSalto);
    }
}
}
