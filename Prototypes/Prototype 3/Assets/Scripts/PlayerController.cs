/*
* Piper Abbott-Phillips
* PlayerController.cs
* Prototype 3, Assignment 4
* Script is in charge of playing sound and particle effects, as well as controlling player movement. Allows player to jump using an Impulse force
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float jumpForce;
    public bool isOnGround = true;
    public ForceMode forceMode;
    public bool gameOver = false;
    public float gravityModifier;
    public Animator playerAnimator;
    public ParticleSystem explosionParticle;
    public ParticleSystem dirtParticle;
    public AudioClip jumpSound;
    public AudioClip crashSound;
    public AudioSource playerAudio;

    void Start()
    {
        //set a refrence to rigidbody comp
        rb = GetComponent<Rigidbody>();
        forceMode = ForceMode.Impulse;
        //set a reference to our animator component
        playerAnimator = GetComponent<Animator>();
        //set reference to audio source comp
        playerAudio = GetComponent<AudioSource>();
        //start running anim on start
        playerAnimator.SetFloat("Speed_f", 1.5f);
        //gravitiy mod
        if (Physics.gravity.y > -10)
        {
            Physics.gravity *= gravityModifier;
        }
     
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        {
            rb.AddForce(Vector3.up * jumpForce, forceMode);
            isOnGround = false;
            //set trig to play jump anim
            playerAnimator.SetTrigger("Jump_trig");
            //stop dirt particle while in the air
            dirtParticle.Stop();
           //play jump sfx
            playerAudio.PlayOneShot(jumpSound, 1.0f);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
            //play dirt particle when on ground
            dirtParticle.Play();
        }
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Game Over! ");
            gameOver = true;
            //play death anim
            playerAnimator.SetBool("Death_b", true);
            playerAnimator.SetInteger("DeathType_int", 1);
            //play explosion particle
            explosionParticle.Play();
            //play crash sfx
            playerAudio.PlayOneShot(crashSound, 1.0f);
        }
    }
}
