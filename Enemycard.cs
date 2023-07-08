using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Enemy",menuName = "Enemies")]
public class Enemycard : ScriptableObject
{
    public string Name;
    public Sprite Fig;
    public int HP; //how much health it has
    public int Attack; // damage it can do
    public int Defense; // damage it will resist
    public float walkrad; //how far it can go
    public bool player; // whether you can control it (you can if true)


}
