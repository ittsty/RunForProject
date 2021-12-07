using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PLAYER : MonoBehaviour
{
    public Text textbox;
    public Text textbox2 ;
    public Rigidbody2D rb;
    public Animator animationPlayer;
    public GameObject players;
    public int deathcount;

    public float speed = 3f;
    public float jump = 5f;
    public float timer;
    public float climbspeed;
    private float climb_velocity;
    private float gravity;
   
    public bool ground;
    public bool ladder;
    public bool con;
    void Start()
    {
        deathcount = PlayerPrefs.GetInt("Death");
        timer = PlayerPrefs.GetFloat("Timeset");
        textbox.text = timer.ToString();
        textbox2.text = deathcount.ToString();
        gravity = rb.gravityScale;
    }

    void Update()
    {
        //movement
        {
            if (ground == true||con == true||ladder==true)
            { 
                float h = Input.GetAxisRaw("Horizontal");
                rb.velocity = new Vector2(h * speed, rb.velocity.y);
                if (Input.GetKeyDown(KeyCode.Space) && ground == true && ladder==false)
                {
                    rb.velocity = Vector2.up * jump;
                }
                animationPlayer.SetBool("ground", ground);
                animationPlayer.SetFloat("speed", Mathf.Abs(Input.GetAxis("Horizontal")));

                if (Input.GetAxis("Horizontal") < -0.1f)
                {
                    transform.localScale = new Vector3(-1, 1, 1);
                }
                if (Input.GetAxis("Horizontal") > 0.1f)
                {
                    transform.localScale = new Vector3(1, 1, 1);
                }
            }
        }
        //Timer
        {
            int min = (int)timer / 60;
            int sec = (int)timer % 60;
            timer += Time.deltaTime;
            textbox.text = string.Format("{0:00}:{1:00}", min, sec);
            deathcount = PlayerPrefs.GetInt("Death");
            textbox2.text= deathcount.ToString();
            PlayerPrefs.SetFloat("Timeset",timer);
        }
        if (ladder)
        {
            rb.gravityScale = 0f;
            climb_velocity = climbspeed * Input.GetAxisRaw("Vertical");
            {            
                rb.velocity = new Vector2(rb.velocity.x, climb_velocity);
            }
        }
        if (!ladder)
        {
            rb.gravityScale = gravity;
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            ground = true;
        }
        if (collision.gameObject.tag == "platform")
        {
            transform.parent = collision.transform;
            ground = true;
        }
        if (collision.gameObject.tag == "wall") 
        {
            con = false;
        }
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            ground = false;
            con = true;
        }
        if (collision.gameObject.tag == "platform")
        {
            transform.parent = null ;
            ground = true;
        }
        if (collision.gameObject.tag == "wall") 
        {
            con = true;
        }
    }
}
