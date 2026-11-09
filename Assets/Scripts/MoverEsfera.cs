
using UnityEngine;

public class MoverEsfera : MonoBehaviour
{
    public Transform objetivo;
    public float velocidad = 3f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (objetivo == null)
            return;

        Vector3 direccion = objetivo.position - rb.position;
        direccion.y = 0f;

        if (direccion.magnitude > 0.1f)
        {
            Vector3 movimiento = direccion.normalized * velocidad;
            rb.MovePosition(rb.position + movimiento * Time.fixedDeltaTime);
        }
    }
}

