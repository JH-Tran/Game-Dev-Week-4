using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    [SerializeField] private int i;
    public Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        i = 3;
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        Debug.Log(this.gameObject.name + ":" + i);
    }
}