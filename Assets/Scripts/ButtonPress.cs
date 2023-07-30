using UnityEngine;

public class ButtonPress : MonoBehaviour
{
    private void OnMouseDown()
    {
        GameObject.Find("Target").GetComponent<TargetScript>().Click();
    }
    private void OnMouseUp()
    {
        GameObject.Find("Target").GetComponent<TargetScript>().Release();
    }
}
