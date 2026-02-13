using UnityEngine;
using System.Collections.Generic;

public class Zoo : MonoBehaviour
{
    public List<string> animals;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public class Animal
    {
        public string type;
        public string name;
        public int age;
        public Color colour;
        public float size;
        public string sex;

        public Animal(string inType, string inName, int inAge)
        {
            type = inType;
            name = inName;
            age = inAge;
        }
    }
}
