using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move2 : MonoBehaviour
{
    private Animator anim;
    public AudioClip jumpsound;
    public AudioClip deadsound;
    AudioSource audiosource;
    public bool play_dead_sound;
    public bool fire_attack;
    public float forceValue = 2f;
    Rigidbody2D rbody2D;
    // Use this for initialization
    public bool jumpingCheck = false;

    public bool fallingCheck = false;
    public bool wallCheck = false;


    public float FallingSpeed;
    public float jumpforce;

//    public Animator MotionAnimator;
    public bool groundCheck = false;
    public bool jumptofallcheck = false;


    void Start()
    {
        rbody2D = this.GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();
        audiosource = GetComponent<AudioSource>();
        play_dead_sound = false;
        fire_attack = false;
    }
    // Update is called once per frame
    void Update()
    {
        float drix = Input.GetAxisRaw("Horizontal");
        Vector2 force2D = Vector2.zero;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.position += new Vector3(-0.1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.position += new Vector3(0.1f, 0, 0);
        }
        jumpUp();
        JumpToFall();
        FallingFunction();
        if (fire_attack == true)
        {
            rbody2D.AddForce(new Vector2(0f, jumpforce));
        }
        //animator

        if ((rbody2D.velocity.y) > 0)
        {
            anim.SetInteger("state", 2);
        }
        else if ((rbody2D.velocity.y) < 0)
        {
            anim.SetInteger("state", 3);
        }
        else if (drix != 0)
        {
            anim.SetInteger("state", 1);
        }
        else
        {
            anim.SetInteger("state", 0);
        }

        if (drix * this.transform.localScale.x < 0)
        {
            this.transform.localScale = new Vector3(this.transform.localScale.x * -1, this.transform.localScale.y, 0);
        }

        if (play_dead_sound == true)
        {
            audiosource.PlayOneShot(deadsound, 4.0f);
        }
    }

    void OpenParachute()
    {
        rbody2D.drag = 5;
    }

    void CloseParachute()
    {
        rbody2D.drag = 0;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground" /*|| collision.gameObject.tag == "Target"*/)
        {
            groundCheck = true;
            jumpingCheck = false;
            Debug.Log("ground!");
        }
        if (collision.gameObject.tag == "Target")
        {
            wallCheck = true;
            jumpingCheck = false;
            Debug.Log("wall!");
            OpenParachute();
         /*   
            if (Input.GetKey(KeyCode.Space) && wallCheck == true)
            {
                Debug.Log("right!");
                rbody2D.AddForce(Vector3.right * 100);
            }
        */
        }
        if (collision.gameObject.tag == "jumptrap")
        {
            rbody2D.AddForce(Vector3.up * 800);
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Target")
        {
            wallCheck = false;
            //groundCheck = false;
            CloseParachute();
        }
        if (collision.gameObject.tag == "ground" /*|| collision.gameObject.tag == "Target"*/)
        {
            groundCheck = false;
        }
    }

    void jumpUp()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && groundCheck == true /*&& crouching == false*/)
        {
            Debug.Log("start jump");
            jumpingCheck = true;
            rbody2D.AddForce(Vector3.up * 600/*jumpforce*/);
            audiosource.PlayOneShot(jumpsound, 5.0f);
        }
        else if (Input.GetKey(KeyCode.UpArrow) && wallCheck == true /*&& crouching == false*/)
        {
            Debug.Log("start walljump");
            jumpingCheck = true;
            rbody2D.AddForce(Vector3.up * 80/*jumpforce*/);
            rbody2D.AddForce(Vector3.right * 30/*jumpforce*/);
            audiosource.PlayOneShot(jumpsound, 5.0f);
        }
    }

    void JumpToFall()
    {
        FallingSpeed = rbody2D.velocity.y;
        if ((FallingSpeed <= 1 && groundCheck == false) || (FallingSpeed <= 1 && wallCheck == true))
        {
            jumptofallcheck = true;
            jumpingCheck = false;
        }
    }

    void FallingFunction()
    {
        if (FallingSpeed < 0 && groundCheck == false && jumptofallcheck == true)
        {
            fallingCheck = true;
        }
    }

}
