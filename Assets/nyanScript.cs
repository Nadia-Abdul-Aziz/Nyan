using UnityEngine;

public class nyanScript : MonoBehaviour
{
    //Define variables at the beginning

    public Rigidbody2D catBody; //storing the cat as a rigid body  
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // Kinda like setup in p5
    void Start()
    {
        
    }

    // Update is called once per frame
    // Like draw in p5
    void Update()
    {
        moveCat(catBody);
    }

    static void moveCat(Rigidbody2D catBody)
    {
        while (Input.GetKey(KeyCode.W) == true)
        {
            catBody.linearVelocityY = 1;
        }
        
    }
}
