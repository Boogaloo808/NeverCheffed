using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class anchorMotor : MonoBehaviour
{
    public Ticket Ticket;

    public int Speed = 5;
    public int tries = 3;
    Direction direction = Direction.clockwise;

    Transform anchor;
    GameObject currentDot;
    [SerializeField]bool isRunning = false;
    public int number;
    public TMPro.TextMeshPro text;
    public PlayerInput playerInput;
    public PlayerController PC;
    public GameObject Lock;

    public Transform theWholeThing;
    public SpriteRenderer bg;
    public AudioSource sound;
    public AudioClip hit, miss;
    Color color = Color.black;
    Vector2 theWholeThingAnchor;
    float shake;

    public void startMG()
    {
        Lock.SetActive(true);
        theWholeThingAnchor = theWholeThing.position;
        number = Random.Range(5, 16);
        anchor = GameObject.FindGameObjectWithTag("anchor").transform;
        isRunning = true;
        Debug.Log("Start running");
    }
    // Update is called once per frame
    void Update()
    {
        text.text = number.ToString();
        theWholeThing.transform.position = theWholeThingAnchor + (Random.insideUnitCircle * shake);
        shake *= 0.98f;
        bg.color = color;
        color = Color.Lerp(color, Color.black, 0.02f);
        if (isRunning)
        {
            Debug.Log("Running");
            transform.RotateAround(anchor.position, Vector3.forward, Speed * Time.deltaTime * -(int)direction);
        }
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        currentDot = other.gameObject;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        currentDot = null;
    }


    void ChangeDirection()
    {
        switch (direction)
        {
            case Direction.clockwise:
                direction = Direction.anticlockwise;
                break;
            case Direction.anticlockwise:
                direction = Direction.clockwise;
                break;
        }
    }

    public void Press(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            if (!isRunning)
            {
                isRunning = true;
                return;
            }
            ChangeDirection();

            if (currentDot != null)
            {
                sound.clip = hit;
                sound.Play();
                currentDot.transform.position = Random.insideUnitCircle.normalized * 1.65f;
                currentDot.transform.position =  new Vector2(currentDot.transform.position.x + 0.09f, currentDot.transform.position.y + 1.05f);
                number--;
                if (number <= 0)
                {
                    Debug.Log("YIPPIEEEEEEEEE");
                    StartCoroutine(nameof(DotFade));
                }
            }
            else
            {
                sound.clip = miss;
                sound.Play();
                shake = 2;
                color = Color.red;
                Debug.Log("you messed up");
            }
        }
    }

    IEnumerator DotFade()
    {
        float alpha = 1;

        SpriteRenderer[] everything = theWholeThing.GetComponentsInChildren<SpriteRenderer>();

        while (alpha > 0)
        {
            alpha -= Time.deltaTime;
            foreach (var thing in everything)
            {
                Color color = thing.color;
                color.a = alpha;
                thing.color = color;
            }
            Color textColor = text.color;
            textColor.a = alpha;
            text.color = textColor;
            yield return null;
        }

        PC.UsingCuttingStation = false;
        PC.frozen = false;
        Debug.Log("Dot fade");
        isRunning = false;
    }
}

public enum Direction
{
    clockwise = 1,
    anticlockwise= -1,
}
