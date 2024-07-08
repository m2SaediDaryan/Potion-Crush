using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Node : MonoBehaviour
{
    //to detarmine can we use space for fill with the potion
    public bool IsUseable;
    public GameObject potion;
    public Node(bool _IsUseable, GameObject _potion)
    {
        IsUseable = _IsUseable;
        potion = _potion;
    }
}
