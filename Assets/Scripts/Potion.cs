using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : MonoBehaviour
{
    public PotionType potionType;
    public int Xindex;
    public int Yindex;
    public bool Ismatched;
    private Vector2 CurrentPos;
    private Vector2 TargetPos;
    public bool IsMoving;

    public Potion(int _x, int _y)
    {
        Xindex = _x;
        Yindex = _y;
    }
    public void SetIndicies(int _x, int _y)
    {
        Xindex = _x;
        Yindex = _y;
    }
}
public enum PotionType
{
    Red,
    Blue,
    Purple,
    Green,
    White
}
