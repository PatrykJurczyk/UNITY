using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTarget : MonoBehaviour
{

    public GameObject firstPoint;
    public GameObject secondPoint;
    private GameObject target;

    private void Start()
    {
        GameObject start;
        GameObject end;
        if (firstPoint.transform.position.x < secondPoint.transform.position.x)
        {
            target = firstPoint;
        }
        else
        {
            target = secondPoint;
        }
    }

    void Update()
    {
        float newX = transform.position.x;
        if (transform.position.x < target.transform.position.x) newX += 1 * Time.deltaTime;
        else newX -= 1 * Time.deltaTime;
        transform.position = new Vector3(newX, transform.position.y, transform.position.z);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameObject start;
            GameObject end;
            if (firstPoint.transform.position.x < secondPoint.transform.position.x)
            {
                start = firstPoint;
                end = secondPoint;
            }
            else
            {
                start = secondPoint;
                end = firstPoint;
            }
            if (collision.gameObject.transform.position.x >= start.transform.position.x && collision.gameObject.transform.position.x <= end.transform.position.x) target = collision.gameObject;
        }
        else
        {
            GameObject start;
            GameObject end;
            if(firstPoint.transform.position.x < secondPoint.transform.position.x)
            {
                start = firstPoint;
                end = secondPoint;
            }
            else
            {
                start = secondPoint;
                end = firstPoint;
            }
            if (transform.position.x <= start.transform.position.x) target = end;
            if (transform.position.x >= end.transform.position.x) target = start;
        }
    }
}
