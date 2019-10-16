using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAdventure : MonoBehaviour
{
    private enum States
    {
        start,
        intro,
        delen,
        deelnee,
        deelja,
        leukgesprek
    }

    private States currentState = States.start;
    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnUserInput(string input)
    {
        if (currentState == States.start)
        {
            if (input == "start")
            {
                StartIntro();
            }else if (input == "1337")
            {
                Terminal.WriteLine("Jij bent leet!");
            }else if (input == "DSWE")
            {
                Terminal.WriteLine("U moet start typen om te beginnen mr van Wakeren");
            }
            else
            {
                Terminal.WriteLine("Je moet start typen om te beginnen joh!");
            }
        }else if (currentState == States.intro)
        {
            if (input == "verder")
            {
                GegevensDelen();
            }
        }
    }

    void StartIntro()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Het is vrijdagavond, en je ouders hebben een datenight");
        Terminal.WriteLine("Gelukkig is ook je zusje logeren bij haar vriendje");
        Terminal.WriteLine("Hierdoor kan je ongestoord de hele nacht gamen");
        Terminal.WriteLine("Typ VERDER om door te gaan");
        currentState = States.intro;
    }

    void GegevensDelen()
    {
        Terminal.WriteLine("Je krijgt de vraag van een andere speler om je Discord nickname te delen");
        Terminal.WriteLine("Wil je dit doen?");
        Terminal.WriteLine("Typ JA om te delen of NEE om niet te delen");
        currentState = States.delen;
    }
    void ShowMainMenu ()
    {
        Terminal.WriteLine("Welkom bij HorrorNite!");
        Terminal.WriteLine("Dit is gebasseerd op een waargebeurd verhaal.");
        Terminal.WriteLine("Het was een donkere, koude nacht.");
        Terminal.WriteLine("Zo een heerlijke nacht om Fortnite te doen!");
        Terminal.WriteLine("Typ START om te beginnen....");
    }
}
