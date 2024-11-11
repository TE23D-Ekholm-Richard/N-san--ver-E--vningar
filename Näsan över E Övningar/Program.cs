// if(6>=3){
// Console.WriteLine("Hello world");

// }



// while(true){
//     Console.WriteLine("Skriv användarnamn");

// string name= Console.ReadLine();

// Console.WriteLine("Skriv lösenord");
// string lösenord = Console.ReadLine();


// if(name=="kalleanka" && lösenord=="12345"){

//     Console.WriteLine("Welcome");
//     break;
// }




// else
// {
//     Console.WriteLine("Wrong username or password");
// }


// Console.ReadLine();
// }
// Console.ReadLine();

// for(int i = 1; i<33 ; i++){
//     Console.WriteLine("HelloWorld!");
// }

// while(true){

// Console.WriteLine("Skriv in rätt lösenord");
// string lösenord = Console.ReadLine();

// if(lösenord == "sigma"){

//     Console.WriteLine("Välkommen");


// }

// else{
//     Console.WriteLine("Fel lösenord bozo");
// }




// Console.ReadLine();
// }

// for(int i = 0 ; i<6 ; i++){

// Console.WriteLine("Skriv ett tal");

// string tal = Console.ReadLine();

// int a = 0;

// bool success  = int.TryParse(tal, out a);

// if (a > 5 ){
// Console.WriteLine("Högre en 5!");
// }
// }


// while(true){
// Console.WriteLine("Skriv in en siffra");
// string nummer = Console.ReadLine();

// bool success = int.TryParse(nummer, out int i);

// if (success){
//     Console.WriteLine("Grattis");
//     break;
// }

// else{
//     Console.WriteLine("försök igen");
// }



// Console.ReadLine();
// }

while (true)
{

    Console.WriteLine("Skriv in en siffra det kan vara vilken som helst");
    string siffra = Console.ReadLine();


    bool success = int.TryParse(siffra, out int i);

    if (success == true)
    {
        if (i == 5)
        {
            Console.WriteLine("Gratiis");
            Console.ReadLine();
            break;

        }


        if (i > 5)
        {
            Console.WriteLine("lägre tal");
        }
        else
        {
            Console.WriteLine("högre tal");
        }
    }











    Console.WriteLine();
}