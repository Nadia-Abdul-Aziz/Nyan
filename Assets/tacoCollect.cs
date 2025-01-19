using UnityEngine;
using UnityEngine.UI;

public class tacoCollect : MonoBehaviour
{
    public int tacoCount;
    public Text tacoText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tacoText.text = "Tacos Eaten: " + tacoCount.ToString();
    }
}
