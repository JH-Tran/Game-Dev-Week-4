using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    [SerializeField] private int i;
    public Renderer rend;
    [SerializeField] private int randomNumber;

    // Start is called before the first frame update
    void Start()
    {
        randomNumber = Random.Range(200,251);
        i = 3;
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        Debug.Log(gameObject.name + ":" + i);
        if (gameObject.tag.Equals("Red") && i == 100)
            gameObject.SetActive(false);
        else if (gameObject.tag.Equals("Blue") && i == randomNumber)
            rend.enabled = false;
    }
}
