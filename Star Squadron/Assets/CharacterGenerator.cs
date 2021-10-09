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
    public void GenerateNPC()
    {
        string[] FirstNameList = new string[13] {"Wally", "Nyssa", "Xena", "Varina", "Geneva", "Astrid", "Fae", "Phoebe", "Ethan", "Alan", "Shae", "Harper", "Jace"};
        string[] TitleList = new string[7] {"the Destroyer", "the Wise", "the III", "the Blind", "the Friend", "the Bitch ASS", "the Lesser"};

        NPC npc = new NPC();
        npc.setFirstName(FirstNameList[Random.Range(0, FirstNameList.Length)]);
        npc.setTitle(TitleList[Random.Range(0, TitleList.Length)]);

        Debug.Log(npc.toString());
    }
}
