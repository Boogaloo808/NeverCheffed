using System.Collections;
using UnityEngine;

public class cameraManager : MonoBehaviour
{
    Camera cam;
    public Transform player;
    public float distance;
    public float zoom = 5;
    public float zoomSpeed = 0.01f;
    Vector3 position;
    public float roomCenter;
    public bool roomCamera = false;
    bool fullyZoomed = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        position = transform.position;
        position.y = zoom - 5;

        if (!roomCamera)
        {
            if (fullyZoomed)
            {
                if (player.position.x - position.x > distance)
                {
                    position += Vector3.right * (player.position.x - position.x - distance);
                }
                else if (player.position.x - position.x < -distance)
                {
                    position += Vector3.right * (player.position.x - position.x + distance);
                }
            }
            else
            {
                position.x = Mathf.Lerp(position.x, player.position.x, zoomSpeed * 3);
            }
        }
        else
        {
            position.x = Mathf.Lerp(position.x, roomCenter, zoomSpeed * 2);
        }

        cam.orthographicSize = zoom;

        transform.position = position;
    }

    public void RoomZoom(float center, float zoom)
    {
        StopAllCoroutines();
        roomCamera = true;
        roomCenter = center;
        StartCoroutine(SmoothZoom(zoom));
    }
    public void CookZoom(float zoom)
    {
        StopAllCoroutines();
        roomCamera = false;
        StartCoroutine(SmoothZoom(zoom));
    }
    IEnumerator SmoothZoom(float goal)
    {
        while (Mathf.Abs(zoom - goal) > 0.02f)
        {
            fullyZoomed = false;
            zoom = Mathf.Lerp(zoom, goal, zoomSpeed);
            yield return null;
        }
        zoom = goal;
        fullyZoomed = true;
        yield break;
    }
}
