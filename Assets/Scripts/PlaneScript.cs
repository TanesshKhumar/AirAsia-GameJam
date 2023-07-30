
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PlaneScript : MonoBehaviour
{
    [SerializeField] public bool isEndless = false;

    public bool isMoving = true;

    private Vector3 targetPos;
    public GameObject target;
    private Rigidbody2D rb;
    public float rotation;

    [SerializeField] public float moveSpeed = 2f;
    [SerializeField] private float roateSpeed = 1f;

    [SerializeField] private int health = 5;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
      
    }

    // Update is called once per frame
    void Update()
    {
        if (isMoving)
        {
            rb.velocity = transform.up * moveSpeed;
        }
        else
        {
            rb.velocity = Vector3.zero;
        }
        targetPos = Camera.main.WorldToScreenPoint(target.transform.position);
        Orientate();
        rb.rotation = Mathf.SmoothDamp(rb.rotation, rotation, ref t, roateSpeed);


    }
    float t = 0;
    public bool calculate = true;
    float angle = 85f;
    public void Orientate()
    {
        targetPos.z = 5.23f;

        Vector3 objectPos = Camera.main.WorldToScreenPoint(transform.position);
        targetPos.x = targetPos.x - objectPos.x;
        targetPos.y = targetPos.y - objectPos.y;

        angle = Mathf.Atan2(targetPos.y, targetPos.x) * Mathf.Rad2Deg;
        rotation = angle - 90f;

    }
    public float time;
    private void FixedUpdate()
    {
        time += Time.deltaTime;
        if (isEndless)
        {
            if (time < 120)
            {
                moveSpeed= 4;
                roateSpeed= 0.3f;
            }
            else if (time < 180)
            {
                moveSpeed = 5.2f;
                roateSpeed = 0.2f;
            }
            else if (time < 240)
            {
                moveSpeed = 6.7f;
                roateSpeed = 0.1f;
            }
            else
            {
                moveSpeed = 9;
                roateSpeed = 0.05f;
            }
        }

        if (transform.position.y > 7)
        {
            moveSpeed = 0;
            GameObject.Find("-UI-").transform.GetChild(2).gameObject.SetActive(true); FindAnyObjectByType<AudioManager>().Play("win");
        }
    }
    public void TakeDamage()
    {
        health--;
        switch (health)
        {
            case 0: 
                moveSpeed = 0; 
                GetComponent<SpriteRenderer>().enabled = false;
                transform.GetChild(0).GetComponent<SpriteRenderer>().enabled=false;
                GameObject.Find("Target").GetComponent<SpriteRenderer>().enabled = false; 
                GameObject.Find("-UI-").transform.GetChild(3).gameObject.SetActive(true); 
                //FindAnyObjectByType<AudioManager>().Play("lose"); 
                break;
            case 1: transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color(0.19f, 0.19f, 0.19f); break;
            case 2: transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color(0.02f, 0.09f, 0.09f); break;
            case 3: transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color(0.6f, 0.14f, 0.14f); break;
            case 4: transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color(0.75f, 0.09f, 0.09f); break;
            default: break;
        }
    }
}
