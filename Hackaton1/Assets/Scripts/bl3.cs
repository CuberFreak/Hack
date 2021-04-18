using UnityEngine;


[RequireComponent(typeof(BoxCollider2D))]



public class bl3: MonoBehaviour
{
    private Vector3 screenPoint;
    private Vector3 offset;
    public GameObject other;
    public GameObject player;
    public static bool locked;
    void OnMouseDown()
    {

        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }
    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        transform.position = curPosition;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (player.tag == other.name)
        {
            Debug.Log("Игрок вошёл в тригер");
            locked = true;
        }
    }
}