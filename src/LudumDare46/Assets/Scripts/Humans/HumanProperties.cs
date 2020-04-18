﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanProperties : MonoBehaviour
{

    public HealthStatusEnum status;
    public SexEnum sex;
    public int age;
    public float percentSpread = 0.30f;

    public void Infect(){
        status = HealthStatusEnum.infected;
        InfectionManager.Instance.AddNewInfected(this);
        gameObject.tag = "Infected";


        //WIP
        GetComponent<SpriteRenderer>().color = Color.green;
    }

    public void RollIfVirusSpread(){
        if(status == HealthStatusEnum.infected)
            return;

        if(Random.Range(0f,1f)<=percentSpread){
            Infect();
        }else{
            Debug.Log("LUCKY!!!");
        }
    }
}