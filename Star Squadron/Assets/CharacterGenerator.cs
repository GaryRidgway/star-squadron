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
        string[] FirstNameList = new string[1] {"Wally", "Nyssa", "Xena", "Varina", "Geneva", "Astrid", "Fae", "Phoebe", "Ethan", "Alan", "Shae", "Harper", "Jace"};
        string[] TitleList = new string[5] {"the Destroyer", "the Wise", "the III", "the Blind", "the Friend", "the Bitch ASS", "the Lesser"};

        string FirstName;

        FirstName = FirstNameList[Random.Range(0, FirstNameList.Length)];
        NameTitle = TitleList[Random.Range(0, TitleList.Length)];

        string mercenaryName = FirstName + " " + NameTitle;

        Debug.Log(mercenaryName);
    }
}
