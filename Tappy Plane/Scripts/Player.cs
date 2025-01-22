using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Player : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    //identify array of sprites used in game
    public Sprite[] sprites;
    private int spriteIndex;
    private Vector3 direction;
    [SerializeField] private AudioClip crashClip;

    private AudioSource audioSource;

    public float force = 5f;

    public float gravity = -9.8f;

    //awake is called automatically by unity it will search for the componet on the game object
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnEnable()
    {
        Vector3  position = transform.position;
        position.y = 0; position.z = 0;
        transform.position = position;
        direction = Vector3.zero;
    }
    private void Start()
    {
        InvokeRepeating(nameof(AnimateSprite), 0.15f, 0.15f);
        audioSource = GetComponent<AudioSource>();
    }
    //this is for the movement of the player applying gravity and which keyboard click will move the character.
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            direction = Vector3.up * force;
        }
        direction.y += gravity * Time.deltaTime;
        transform.position += direction * Time.deltaTime;
    }
    private void AnimateSprite() 
    {
        spriteIndex++;
        if (spriteIndex >= sprites.Length)
        {
            spriteIndex = 0;
        }
        spriteRenderer.sprite = sprites[spriteIndex];
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            FindAnyObjectByType<GameManager>().GameOver();
            audioSource.clip = crashClip;
            audioSource.Play();
        }
        else if (other.gameObject.tag == "Scoring") 
        {
            FindAnyObjectByType<GameManager>().IncreaseScore();
        }
    }
}