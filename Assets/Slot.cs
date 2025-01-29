using System;
using UnityEngine;

public class Slot : MonoBehaviour
{
    public int slotNum;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other){
        Debug.Log($"{other.name} enter slot {slotNum}");
    }
}
