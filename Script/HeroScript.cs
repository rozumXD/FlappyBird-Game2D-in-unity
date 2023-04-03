using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeroScript : MonoBehaviour
{

    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicManager logic;
    public bool birdIsAlive = true;
    public HeroSounds sound;
    public float heroDeathZoneDown = -5;      
    public double heroDeathZoneUp = 5.7;
    public Vector3 currentRotation;
    public Vector3 anglesToRotate;

    // Start is called before the first frame update
    void Start()
    {
        logic.temp = true;
        gameObject.name = "Hero";
        //currentRotation = new Vector3(0, 0, 0);
        //myRigidbody.gravityScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion rotationZ = Quaternion.AngleAxis (currentRotation.z, new Vector3(0, 0, -15));
        Quaternion defRotationZ = Quaternion.AngleAxis (currentRotation.z * Time.deltaTime, new Vector3(0, 0, 0));

        if(Input.GetKeyDown(KeyCode.Space) && birdIsAlive) //jump
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
            this.transform.rotation = rotationZ;
            sound.playJumpSound();
        }

        if(Input.GetKeyUp(KeyCode.Space) && birdIsAlive)
        {
            this.transform.rotation =  defRotationZ;
        }

        if(Input.GetKeyDown(KeyCode.Space) && !birdIsAlive)  //zgon
        {
            logic.restartGame();
        }

        if(transform.position.y < heroDeathZoneDown || transform.position.y > heroDeathZoneUp)
        {
            logic.gameOver();      //if bird cross the borders
            Destroy(gameObject);
        }

    }

    public void destroyBird()
    {
        Destroy(gameObject);
        logic.gameOver();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        birdIsAlive = false;
        sound.playCrashSound();
        logic.gameOver();
    }

    
}
