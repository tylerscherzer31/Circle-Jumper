
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public SpriteRenderer sr;

    public Color colorCyan;
    public Color colorYellow;
    public Color colorMagenta;
    public Color colorPink;

    public string currentColor;
    public float jumpForce = 10f;

    private void Start()
    {
        SetRandomColor();

    }

    void Update()
    {
        if (Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * jumpForce;

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Cyan")
        {

        }

    }

    void SetRandomColor()
    {
        int index = Random.Range(0, 3);
            switch (index)
            {
            case 0:
                currentColor = "Cyan";
                sr.color = colorCyan;
                break;
            case 1:
                currentColor = "Yellow";
                sr.color = colorYellow;
                break;
            case 2:
                currentColor = "Magenta";
                sr.color = colorMagenta;
                break;
            case 3:
                currentColor = "Pink";
                sr.color = colorPink;
                break;
            }
    }
}
