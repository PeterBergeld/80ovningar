Console.WriteLine("Ange ett försäljningssumma"); 

decimal grundlön = 8000m;       
decimal provision = 0.09m;
decimal försäljningssumma; 
 

decimal.TryParse(Console.ReadLine(), out försäljningssumma); 
decimal provisionsbelopp = försäljningssumma * provision;

decimal totalön = provisionsbelopp + grundlön; 

Console.WriteLine(totalön);