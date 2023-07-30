using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetScript : MonoBehaviour
{
    [SerializeField] public bool isEndless = false;
    private int curTarget = 0;
    public int targetCount = 15;

    public List<Vector2> targetList;
    public List<int> targetType;
    [SerializeField] int oneTap = 30;
    [SerializeField] int twoTap = 60;
    [SerializeField] int hold = 100;
    private Animator animator;
    private bool clicked = false;


    private bool active = false;
    public int score;

    private void Awake()
    {
        animator = GetComponent<Animator>();


        if (!isEndless)
        {
            RandomTarget();
            targetList.Add(new Vector2(0, 0));

            for (int i = 0; i < targetCount; i++)
            {
                targetList.Add(Randomize(targetList[i]));
            }
            Vector2 a;
            do
            {
                a = new Vector2(Random.Range(-1.5f, 0), Random.Range(-4f, 4f));
            } while (a.y - targetList[targetCount].y > -3.5 && a.y - targetList[targetCount].y < 3.5);
            targetList.Add(a);
            targetList.Add(new Vector2(0, 0));
            targetList.Add(new Vector2(0, 8));
        }
        targetList.Add(new Vector2(0, 0));

        if (isEndless)
        {
            AddToTheList();
        }
        NextTarget();


        
    }
    private void Update()
    {
        if (isEndless)
        {
            if (targetList.Count - curTarget < 5)
            {
                
                AddToTheList();
            }
        }
        if (transform.position.y > 5)
        {
            Debug.Log(score);
            //IF WIN


            //IF LOSE


        }
    }
    private void AddToTheList()
    {
        Debug.Log('a');

        for (int j = 0; j < 10; j++)
        {
            int a = Random.Range(1, 101);
            if (a > 0 && a <= oneTap)
            {
                targetType.Add(1);
            }
            else if (a > oneTap && a <= twoTap)
            {
                targetType.Add(2);
            }
            else
            {
                targetType.Add(3);
                targetType.Add(4);
                j++;
            }

            
        }
        for (int k = 0; k < 10; k++)
        {
            targetList.Add(Randomize(targetList[k]));
        }
    }
    public void RandomTarget()
    {
        int i = 0;
        do
        {
            int a = Random.Range(1, 101);
            if (a > 0 && a <= oneTap)
            {
                targetType.Add(1);
                i++;
            }
            else if (a > oneTap && a <= twoTap)
            {
                targetType.Add(2);
                i++;
            }
            else
            {
                targetType.Add(3);
                targetType.Add(4);
                i += 2;
            }
        } while (i < targetCount + 5);
        
    }
    public Vector2 Randomize(Vector2 b)
    {
        Vector2 a;
        do
        {
            a = new Vector2(Random.Range(-1.5f, 1.5f), Random.Range(-3f, 4f));
        } while (a.y - b.y > -3 && a.y - b.y < 3);

        return  a;
    }

    public void NextTarget()
    {

        if (targetList[curTarget] != null)
        {
            animator.SetInteger("Animation", targetType[curTarget]);
            transform.position = targetList[curTarget];
            curTarget++;
        }
        
    }

    //FOR SCORE
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "plane")
            active= true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "plane")
        {
            if (active)
            {
                Debug.Log("missed");
                clicked = false;

                active = false;
            }
        }
        
    }
    public void Click()
    {
        if (active)
        {
            if (targetType[curTarget - 1] == 1)
            {
                Debug.Log("single hit");

                score++;
                active = false;
                NextTarget();

            }
            else if (targetType[curTarget - 1] == 2)
            {
                if (!clicked)
                {
                    Debug.Log("first hit");
                    clicked = true;

                }
                else if (clicked)
                {
                    Debug.Log("double hit");

                    clicked = false;
                    score++;
                    active = false;
                    NextTarget();

                }
            }
            else if (targetType[curTarget - 1] == 3)
            {
                Debug.Log("start hold");

                clicked = true;
                active = false;
                score++;
                NextTarget();

            }
        }
    }
    public void Release()
    {
        if (active)
        {
            if (targetType[curTarget - 1] == 4)
            {

                if (clicked == true)
                {
                    Debug.Log("end hold");
                    active= false;
                    score++;
                    NextTarget();


                }
            }
        }
        if (targetType[curTarget - 1] != 2)
        {
            clicked = false;

        }

    }
}
