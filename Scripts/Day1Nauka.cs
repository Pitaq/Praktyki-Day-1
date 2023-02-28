using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day1Nauka : MonoBehaviour
{
    private int currentAge = 30;
    public int adddedAge = 1;
    public float numberPi = 3.14f;
    public string secondName = "Psikut";
    public bool isAuthor = true;    
    void Start()
    {
        int characterLevel = 32;
        int nextSkillLevel = GenerateCharacter("The Witcher", characterLevel);
        Debug.Log(nextSkillLevel);
        Debug.Log(GenerateCharacter("Faye", characterLevel));




        GenerateCharacter("The Witcher", characterLevel);
        ComputerAge();
        Debug.Log($"W komentarzu lub gdziekolwiek w ciągu znaków tak zwanych interpolacją ciągu można dodać zmienną, tak jak nazwisko {secondName}");
        //Debug.Log(numberPi * secondName) to był eksperyment, powinno wywalić błąd co w rzeczywistości się stało. Ergo; nie można mnożyć dwóch innych typów zmiennych

    }
    public int GenerateCharacter(string name, int level)
    {
        Debug.LogFormat("Postać: {0} - Poziom: {1}", name, level);
        return level + 5;



    }

    void ComputerAge()
    {
        Debug.Log(currentAge + adddedAge);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
