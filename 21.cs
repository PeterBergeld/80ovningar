// // // en test function om ett tal är mindre än -10 || < +10
// // //ett meddelande ska skickas då


// // int userInput;

// // { 
// //     System.Console.WriteLine("Vilket tal väljer du");
// //     Console.ReadLine();


// // }

// // string userInput = Console.ReadLine();

// // int.TryParse(userInput, out int nummer);

// // if   (nummer < -10 ||  nummer  > 10 ) 
// // {
// //     System.Console.WriteLine("Du Skrev ett ogiltigt nummer");
// //     int.TryParse(userInput ,out int nummer);


// // }

// // else
// // {
// //     Console.WriteLine("Du skrev rätt nummer");
// //     Console.ReadLine = userinput;
// // }


// int tal  = 0;
// static void Kontrolleratal()
// {
//     System.Console.WriteLine(" Skriv ett tal");
//     Console.ReadLine();
//     int tal = int.TryParse(tal, out int tal);

//     if (tal < -10 || tal > 10)
//     {
//         System.Console.WriteLine("Du skrev ett ogiltigttal");
//     }
// }



using System.Diagnostics;
using System.Security.Cryptography;

static void KontrolleraTal()
{
    System.Console.WriteLine("Skriv ett tal");
    string input = Console.ReadLine(); // input av datatypen string sparas
    int.TryParse(input, out int tal);  //försöker omvandla texten till heltal
    
    if (tal < -10 || tal > 10) //om detta villkor är sant gör det som står i blocket
    {
    System.Console.WriteLine("Du skrev ett ogiltigt tal");
    }
    else
    {
        System.Console.WriteLine("Talet är giltigt");
    }
}
KontrolleraTal();