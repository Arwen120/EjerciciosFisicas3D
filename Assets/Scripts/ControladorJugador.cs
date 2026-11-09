
using UnityEngine;

public class ControladorJugador : MonoBehaviour
{
    public float velocidad = 5f;

    private Rigidbody rb;
    private float movimientoHorizontal;
    private float movimientoVertical;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        movimientoHorizontal = Input.GetAxisRaw("Horizontal");
        movimientoVertical = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        Vector3 movimiento = new Vector3(
            movimientoHorizontal,
            0f,
            movimientoVertical
        ).normalized;

        Vector3 velocidadDeseada = movimiento * velocidad;

        Vector3 cambioVelocidad = new Vector3(
            velocidadDeseada.x - rb.linearVelocity.x,
            0f,
            velocidadDeseada.z - rb.linearVelocity.z
        );

        rb.AddForce(cambioVelocidad, ForceMode.VelocityChange);
    }
}
