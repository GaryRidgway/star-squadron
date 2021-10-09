using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GenerateName()
    {
        string[] maleNames = new string[1] {"wally"};
        string[] femaleNames = new string[4] { "abby", "abigail", "adele", "adrian"};
        string[] lastNames = new string[5] { "abbott", "acosta", "adams", "adkins", "aguilar"};
        
        string FirstName;

        int rand = Random.Range(0,2);
        if (rand == 0)
        {
            FirstName = maleNames[Random.Range(0, maleNames.Length)];
        }
        else
        {
            FirstName = femaleNames[Random.Range(0, femaleNames.Length)];
        }

        Debug.Log(FirstName);
    }
}
