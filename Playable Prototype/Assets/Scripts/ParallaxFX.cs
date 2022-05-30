using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxFX : MonoBehaviour
{
    [SerializeField]
    private Camera cam;
    [SerializeField]
    private Transform player;

    Vector2 startPosition;
    float startZ;

    Vector2 movement => (Vector2)cam.transform.position - startPosition;

    float disFromPlayer => transform.position.z - player.position.z;
    float clippingPlane => (cam.transform.position.z + (disFromPlayer > 0 ? cam.farClipPlane : cam.nearClipPlane));

    float parallaxFactor => Mathf.Abs(disFromPlayer) / clippingPlane;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        startZ = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPos = startPosition + movement * parallaxFactor;
        transform.position = new Vector3(newPos.x + newPos.y, startZ);
    }
}
