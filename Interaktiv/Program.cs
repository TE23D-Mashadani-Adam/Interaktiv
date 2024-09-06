using System.Net.NetworkInformation;

while (true){

Handlingar.vevaBool = false;
Handlingar.gårPåToaBool = false;
Handlingar.springerBool = false;
Handlingar.äterÄppletBool = false;
Handlingar.öppnarDörrenBool = false;

Handlingar.victory = false;
Handlingar.gameover = false;


String ja = "ja";

Console.WriteLine("Välkommen till mitt interaktiva spel!, för att säga ja, skriv ja, annars skriv vad som helst för nej"+"\n");

Console.WriteLine("Du ser en dörr framför dig, gå du in, ja eller nej?");
string RumAnswer = Console.ReadLine().ToLower();
if(RumAnswer==ja){
    Handlingar.öppnarDörrenBool = true;
    Handlingar.öppnarDörren();
    
    string äppleAnswer = Console.ReadLine().ToLower();
    if(äppleAnswer==ja){
        Handlingar.äterÄppletBool = true;
        Handlingar.äterÄpplet();
        string answerToa = Console.ReadLine().ToLower();

        if(answerToa==ja){
            Handlingar.gårPåToaBool = true;
            Handlingar.gårPåToa();
        }else{
            Handlingar.gårPåToa();
        }

    }else{
        Handlingar.äterÄpplet();
        string springerAnswer = Console.ReadLine().ToLower();
        if(springerAnswer==ja){
            Handlingar.springerBool = true;
            Handlingar.springer();
            string vevaAnswer = Console.ReadLine().ToLower();
            if(vevaAnswer==ja){
                Handlingar.vevaBool = true;
                Handlingar.vevaMedKerem();
            }else{
                Handlingar.vevaMedKerem();
            }
        }else{
            Handlingar.springer();
        }
    }
}else{
    Handlingar.öppnarDörren();
}

if(Handlingar.gameover == true){
    Console.WriteLine("\n"+"Gameover! Tryck på enter för att starta om");
    Console.ReadLine();
}
if(Handlingar.victory == true){
    Console.WriteLine("\n"+"Grattis du vann! Tryck på enter för att starta om");
    Console.ReadLine();
}

}