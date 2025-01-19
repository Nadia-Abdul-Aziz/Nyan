using UnityEngine;

public class gringoTaco : MonoBehaviour
{

    public GameObject Taco;

    public float spawnRate = 1;

    private float timer = 0;

    public float yDisplacement = 5;

    public float yMin;

    public float yMax;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnTaco();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnTaco();
            timer = 0;
        }

    }

    void spawnTaco()
    {
        yMax = transform.position.y + yDisplacement;
        yMin = transform.position.y - yDisplacement;

        Instantiate(Taco, new Vector3(transform.position.x, Random.Range(yMin, yMax), 0), transform.rotation);
    }
}