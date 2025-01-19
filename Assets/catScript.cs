using UnityEngine;

public class catScript : MonoBehaviour
{
    public Rigidbody2D catBody;

    float moveStrength = 5;

    public tacoCollect tc;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) == true)
        {
            catBody.linearVelocity = Vector2.up * moveStrength;
        }

        if (Input.GetKeyDown(KeyCode.S) == true)
        {
            catBody.linearVelocity = Vector2.down * moveStrength;
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Taco"))
        {
            Destroy(other.gameObject);

            tc.tacoCount++;
        }
    }
}
