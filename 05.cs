//Läsa in ett heltal motsvarande svenska kronor och 
//i dollar & pund. 

decimal kr = 600m; //int passar bättre för att det är ett heltal, 
//men decimal är i regel för pengar så bra.
decimal.TryParse(Console.ReadLine(), out kr);
decimal dollar = kr/6;
Console.WriteLine(dollar);
decimal pund = kr/10;
Console.WriteLine(pund);


