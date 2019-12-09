using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Timer : MonoBehaviour
{
    public float Min = 1;
    public float Max = 10;
    private float timer = 0;
    private int waitTime;
    public bool repeat = false;

    public UnityEvent onTimerComplete;

    private void Start()
    {
        System.Random NumberGenerator = new System.Random();
        waitTime = NumberGenerator.Next((int)Min, (int)Max);

 
    }
 
    private void Update()
    {
        if (repeat)
        {

            //InvokeRepeating("OnTimerComplete", 0, NumberGenerator.Next((int)Min, (int)Max));
            if (timer > waitTime)
            {
                
                System.Random NumberGenerator = new System.Random();
                OnTimerComplete();
                timer = 0;
                waitTime = NumberGenerator.Next((int)Min, (int)Max);
            }
        }
        else
        {
            System.Random NumberGenerator = new System.Random();
            Invoke("OnTimerComplete", NumberGenerator.Next((int)Min, (int)Max));
        }
        timer += Time.deltaTime;


    }

    private void OnTimerComplete()
    {
        Debug.Log("test");
        onTimerComplete.Invoke();

    }

}
