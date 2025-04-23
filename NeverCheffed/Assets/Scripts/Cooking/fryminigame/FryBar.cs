using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using System.Collections.Generic;

public class FryBar : MonoBehaviour
{

    public float ShrinkSpeed;
    public float maxSize;
    public float minSize = 0;
    public float waitTime;

    // Update is called once per frame
    public void actionPressed(InputAction.CallbackContext Context)
    {
        if (Context.performed)
        {
            StartCoroutine(ScaleUp());
        }
        else
        {
            
        }
    }

    IEnumerator ScaleUp()
    {
        float timer = 0;

        while (true)
        {

            while (maxSize > transform.localScale.x)
            {
                timer += Time.deltaTime;
                transform.localScale = new Vector3(1, 1 + Time.deltaTime * ShrinkSpeed, 1);
                yield return null;
            }

            yield return new WaitForSeconds(waitTime);

            timer = 0;
            while (1 < transform.localScale.x)
            {
                timer += Time.deltaTime;
                transform.localScale = new Vector3(1, 1 + Time.deltaTime * ShrinkSpeed, 1);
                yield return null;
            }

            timer = 0;
            yield return new WaitForSeconds(waitTime);
        }
    }

    IEnumerator ScaleDown()
    {
        float timer = 0;

        while (true)
        {

            while (minSize <= transform.localScale.x)
            {
                timer += Time.deltaTime;
                transform.localScale = new Vector3(1, 1 * Time.deltaTime * -ShrinkSpeed, 1);
                yield return null;
            }

            yield return new WaitForSeconds(waitTime);

            timer = 0;
            while (1 < transform.localScale.x)
            {
                timer += Time.deltaTime;
                transform.localScale = new Vector3(1, 1 * Time.deltaTime * -ShrinkSpeed, 1);
                yield return null;
            }

            timer = 0;
            yield return new WaitForSeconds(waitTime);
        }
    }
}
