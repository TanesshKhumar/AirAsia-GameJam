using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetScript : MonoBehaviour
{

    private int curTarget = 0;
    public int targetCount = 15;

    public List<Vector2> targetList;


    private bool active = false;
    public Button button;
    public int score;

    private void Awake()
    {
        button.onClick.AddListener(Click);




        targetList.Add(new Vector2(0, 0));

        for (int i = 0; i < targetCount; i++)
        {
            targetList.Add(Randomize(targetList[i]));
        }
        targetList.Add(new Vector2(0, 0));
        targetList.Add(new Vector2(0, 8));
        NextTarget();


        if (transform.position.y > 5)
        {
            //END
            //END
            //END
            //END
            //END
        }
    }
    public Vector2 Randomize(Vector2 b)
    {
        Vector2 a;
        do
        {
            a = new Vector2(Random.Range(-1.5f, 1.5f), Random.Range(-4f, 4f));
        } while (a.y - b.y > -3 && a.y - b.y < 3);

        return  a;
    }

    public void NextTarget()
    {
        transform.position = targetList[curTarget];
        curTarget++;
    }

    //FOR SCORE
    private void OnTriggerEnter2D(Collider2D collision)
    {
        active= true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (active)
        {
            Debug.Log("missed");
            active = false;
        }
    }
    private void Click()
    {
        if (active)
        {
            Debug.Log("hit");

            score++;
            active= false;
            NextTarget();
        }
    }
}
