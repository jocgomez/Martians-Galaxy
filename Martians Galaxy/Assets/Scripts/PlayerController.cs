using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float maxSpeed = 5f;
    public float speed = 20f;
    public bool ground;
    public float jumpPower = 6.5f;

    private Rigidbody2D rb2d;
    private Animator anim;
    private bool jump = false;
    private bool move = false;
    private bool girar = true;

    public AudioSource salto;


    // Use this for initialization
    void Start () {

        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        salto = GetComponent<AudioSource>();
	}

    // Update is called once per frame
    void Update() {
        anim.SetFloat("Speed", Mathf.Abs(rb2d.velocity.x));
        anim.SetBool("Ground", ground);

        if (Input.GetKeyDown(KeyCode.UpArrow) && ground)
        {
            jump = true;
            

        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            move = true;
        }
        else
        {
            move = false;
        }

        if (Input.GetKey(KeyCode.Mouse0))
        {
            anim.SetBool("Fire",true);
        }
        else
        {
            anim.SetBool("Fire", false);
        }
    }

    private void FixedUpdate()
    {
        if (move)
        {
            float h = Input.GetAxis("Horizontal");
            rb2d.AddForce(Vector2.right * speed * h);

            float limitedSpeed = Mathf.Clamp(rb2d.velocity.x, -maxSpeed, maxSpeed);
            rb2d.velocity = new Vector2(limitedSpeed, rb2d.velocity.y);

            if (h > 0.1f && girar == false)
            {
                transform.Rotate(0f, 180f, 0f);
                girar = true;
            }

            if (h < -0.1f && girar == true)
            {
                transform.Rotate(0f, 180f, 0f);
                girar = false;
            }
        }
        else
        {
            rb2d.velocity = new Vector2(0f, rb2d.velocity.y);
        }


        if (jump)
        {           
            rb2d.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
            jump = false;
            

        }

    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "ground")
        {
            ground = true;
        }        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            ground = false;
        }
    }
}
