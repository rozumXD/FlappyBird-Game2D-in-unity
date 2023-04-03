using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public LogicManager logic; 
    public PipeMoveSpeed pipeMoveSpeed;
    public PipeSpawner pipeSpawner;
    public HeroSounds sound;
    
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
        //pipeMoveSpeed = GameObject.FindGameObjectWithTag("Spawner").GetComponent<PipeMoveSpeed>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 3)
        {
            Debug.Log("Score added!");
            logic.addScore(1);
            logic.difficulty(1);
        }

       // sound.playScoreSound();
    }
   

}
