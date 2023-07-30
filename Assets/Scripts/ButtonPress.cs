using UnityEngine;

public class ButtonPress : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    [SerializeField] public Sprite down, up;
    private void Awake()
    {
        spriteRenderer= GetComponent<SpriteRenderer>();
    }
    private void OnMouseDown()
    {
        spriteRenderer.sprite = down;
        GameObject.Find("Target").GetComponent<TargetScript>().Click();
    }
    private void OnMouseUp()
    {
        spriteRenderer.sprite = up;
        GameObject.Find("Target").GetComponent<TargetScript>().Release();
    }
}
