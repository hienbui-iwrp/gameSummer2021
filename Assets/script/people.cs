using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class people : MonoBehaviour
{
    // Start is called before the first frame update
    public static List<people> peopleList = new List<people>();
    public bool beSick = false;
    public static List<people> getPeopleList()
    {
        return peopleList;
    }
    // Update is called once per frame
    void Update()
    {
        if (!beSick) peopleList.Add(this);
        else peopleList.Remove(this);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals("bat")) beSick = true;
    }
}
