using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class MyAdventure : MonoBehaviour
{
    private enum States
    {
        start,
        intro1,
        intro2,
        delen,
        deelnee,
        deelja,
        leukgesprek,
        deeltadres,
        nacht,
        checksloten,
        slotenja,
        slotennee,
        denkramen,
        checkramen,
        ramenja,
        zoekzaklamp,
        zaklampslaapkamer,
        zaklampwoonkamer,
        xslaatraamin,
        watnu,
        seinburen,
        verstoppenbed,
        einde_politie,
        einde_dood
    }
    private States currentState = States.start;
    void Start()
    {
        ShowMainMenu();
    }

    void ShowMainMenu()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Welkom bij HorrorNite");
        Terminal.WriteLine("Dit is gebaseerd op een waargebeurd verhaal");
        Terminal.WriteLine("Typ start om te beginnen");
    }

    
    void OnUserInput(string input)
    {
        if (currentState == States.start)
        {
            if (input == "start")
            {
                currentState = States.intro1;
                StartIntro();
            }else if (input == "1337")
            {
                Terminal.WriteLine("Jij bent Leet!");
            }
            else
            {
                Terminal.WriteLine("Verkeerde invoer");
            }
        }else if (currentState == States.intro1)
        {
            if (input == "verder")
            {
                
            }
        }

        switch (currentState)
        {
            case States.start:
                if (input == "start")
                {
                    currentState = States.intro1;
                    StartIntro();
                }else if (input == "1337")
                {
                    Terminal.WriteLine("Jij bent Leet!");
                }
                else
                {
                    Terminal.WriteLine("Verkeerde invoer");
                }
                break;
            case States.intro1:
                if (input == "verder")
                {
                    currentState = States.intro2;
                    Intro2();
                }
                break;
        }
    }

    void StartIntro()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Het was een koude donkere nacht");
        Terminal.WriteLine("Een goede nacht om Fortnite te doen");
        Terminal.WriteLine("Typ verder om door te gaan");
    }

    void Intro2()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je komt een speler tegen die je skills bewonderd.");
        Terminal.WriteLine("Deze persoon zou graag je op discord willen toevoegen.");
        Terminal.WriteLine("Typ verder om door te gaan");
    }
}
