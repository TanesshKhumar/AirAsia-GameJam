
using UnityEngine;

public class PlaneScript : MonoBehaviour
{
    [SerializeField] public bool isEndless = false;

    public bool isMoving = true;

    private Vector3 targetPos;
    public GameObject target;
    private Rigidbody2D rb;
    public float rotation;

    [SerializeField] private float moveSpeed = 2f;
    [SerializeField] private float roateSpeed = 1f;
    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
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
    }
}
