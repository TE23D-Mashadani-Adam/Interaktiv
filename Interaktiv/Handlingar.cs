public class Handlingar{

    public static bool öppnarDörrenBool = false;
    public static bool äterÄppletBool = false;
    public static bool gårPåToaBool = false;
    public static bool springerBool = false;

    public static bool vevaBool = false;

    public static string öppnarDörrenString = "Du ser en äpple frmaför dig, äter du den, ja eller nej?";
     public static string äterÄppletString = "Du får ont i magen, går du på toa eller inte, ja eller nej?";
    public  static string gårPåToaString = "Du går på toa, du bli bättre, grattis, du överlevde!";
    public static string springerString = "Du ser Kerem framför dig, vevar du eller inte, ja eller nej?";
    public static string vevaString = "Du vevar med Kerem, han ger dig en box i ansiktet och du är knockad!";

    public static bool gameover = false;
    public static bool victory = false;





    public static void öppnarDörren(){
        if (öppnarDörrenBool){
            Console.WriteLine(öppnarDörrenString);
        }else{
            Console.WriteLine("Du är en fegis, gameover!");
            gameover = true;
        }
    }
    public static void äterÄpplet(){
        if (äterÄppletBool){
            Console.WriteLine(äterÄppletString);
        }else{
            Console.WriteLine("Du ser att äpplet är förgiftat, springer du, ja eller nej?");
        }
    }

    public static void gårPåToa(){
        if (gårPåToaBool){
            Console.WriteLine(gårPåToaString);
            victory = true;
        }else{
            Console.WriteLine("Din mage exploderar, du dör!");
            gameover = true;
        }
    }

    public static void springer(){
        if (springerBool){
            Console.WriteLine(springerString);
        }else{
            Console.WriteLine("Du sitter kvar i rummet för 5 månader och du dör av hunger till slut!");
            gameover = true;
        }
    }

    public static void vevaMedKerem(){
        if (vevaBool){
            Console.WriteLine(vevaString);
            gameover = true;
        }else{
            Console.WriteLine("Du springer iväg och hinner ut från huset, grattis du vann!!");
            victory = true;
        }
    }
}