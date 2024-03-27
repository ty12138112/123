using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanManager : MonoBehaviour
{
    public GameObject human;
    public float value;
    public Vector3 sizeChange;

    public void MoveRight()
    {
        value = value + 1;
        human.transform.position = new Vector3(value-195.919f, 98.364f, 283.423f);
    }

    public void Reset()
    {
        human.transform.position = new Vector3(-195.919f, 98.364f, 283.423f);
        human.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        human.transform.localScale = new Vector3(1, 1, 1);
    }

    public void RotateLeft()
    {
        human.transform.Rotate(0f, 20f, 0f);
    }

    public void Grow()
    {
        human.transform.localScale += sizeChange;
    }
  
    public void GetSmall()
    {
        human.transform.localScale -= sizeChange;
    }



}
