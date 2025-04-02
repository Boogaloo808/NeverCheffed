using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class anchorMotor : MonoBehaviour
{
    public int Speed = 5;
    public int tries = 3;
    Direction direction = Direction.clockwise;

    Transform anchor;
    GameObject currentDot;
    bool isRunning = false;
    public int number;
    public TMPro.TextMeshProUGUI text;

    public Transform theWholeThing;
    public SpriteRenderer bg;
    public AudioSource sound;
    public AudioClip hit, miss, fail, success;
    Color color = Color.black;
    Vector2 theWholeThingAnchor;
    float shake;

    void Start()
    {
        theWholeThingAnchor = theWholeThing.position;
        number = Random.Range(5, 16);
        anchor = GameObject.FindGameObjectWithTag("anchor").transform;
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
                tries--;
                color = Color.red;
                if (tries <= 0)
                {
                    Debug.Log("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
                    StartCoroutine(nameof(DotFade));

                }
                Debug.Log("you fucked up");
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
        Destroy(theWholeThing.gameObject);
    }
}

public enum Direction
{
    clockwise = 1,
    anticlockwise= -1,
}
