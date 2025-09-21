using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour {
    [Header("Inscribed")]

    public GameObject applePrefab;
    public GameObject rottenApplePrefab;

    public float speed = 8f;

    public float leftAndRightEdge = 24f;

    public float changeDirChance = 0.02f;

    public float appleDropDelay = 1f;
    public float rottenDropDelay = 6.7f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("DropApple", 2f);
        Invoke("DropRottenApple", 10f);
    }

    void DropApple()
    {
        GameObject apple = Instantiate<GameObject>(applePrefab);
        apple.transform.position = transform.position;
        Invoke("DropApple", appleDropDelay);
    }

    void DropRottenApple()
    {
        GameObject rottenApple = Instantiate<GameObject>(rottenApplePrefab);
        rottenApple.transform.position = transform.position;
        Invoke("DropRottenApple", rottenDropDelay);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed);
        } 

        else if (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed);
        } 
    }

    private void FixedUpdate()
    {
       if (Random.value < changeDirChance)
        {
            speed *= -1;
        }
    }
}
