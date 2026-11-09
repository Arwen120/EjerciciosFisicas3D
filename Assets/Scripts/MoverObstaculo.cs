
using UnityEngine;

public class MoverObstaculo : MonoBehaviour
{
    public float velocidad = 2f;

    private Rigidbody rb;
    private bool activado = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") || collision.gameObject.name == "Esfera")
        {
            activado = true;

            Renderer renderer = GetComponent<Renderer>();

            if (renderer != null)
            {
                renderer.material.color = Color.red;
            }

            Debug.Log("¡La esfera ha alcanzado el obstáculo!");
        }
    }

    void FixedUpdate()
    {
        if (activado)
        {
            rb.MovePosition(rb.position + Vector3.forward * velocidad * Time.fixedDeltaTime);
        }
    }
}
