using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Module4Challenge.Pages;

public class DadJokesModel : PageModel
{// we are using the array to see which dad joke will be displayed onto the webpage when generated.
    public string[] DadJokes =
    {
        "Why don't skeletons fight each other? They don't have the guts!", 
        "What did one wall say to the other wall? I'll meet you at the corner!",
        "Why did the coffee file a police report? It got mugged!",
        "I used to be a baker, but I couldn't make enough dough.",
        "I'm writing a book about glue, but I'm stuck on the first chapter.",
        "Stop looking for the perfect match; use a lighter.",
        "What state is known for its small drinks? Minnesota.",
        "If two vegetarians get in an argument, is it still called beef?",
        "I have a clean conscious—it's never been used.",
        "Did you hear about the guy who got hit in the head with a can of soda? He was lucky it was a soft drink.",
        "I went to buy some camouflage pants, but I couldn't find any.",
        "Why don't eggs tell jokes? They might crack up!",
        "I told my wife she should embrace her mistakes. She gave me a hug."
    };

     // this will display the current jokes on the screen. 
    public string[] CurrentJoke {get; set;} = new string[1]; // this is creating an new array for the list of jokes. 

    // this refers to the 2 jokes that will be display on the screen. 
    public int NumOfJokes {get; set; } = 2; 

    public bool ShowResults {get; set; } = false;

    public void OnGet() // this will generate an random joke from the list. 
    {
       RandomJoke();
    }

    public void RandomJoke() // using this void, will provide me with the forloop and while loop method.
    {
        CurrentJoke = new string[NumOfJokes];
        int jokecount = 0; 

        while (jokecount < NumOfJokes)
        {
            Random rnd = new();
            int dadJokeIndex = rnd.Next(DadJokes.Length);
            string jokeHere = DadJokes[dadJokeIndex];

            if (!CurrentJoke.Contains(jokeHere)) // if it doesn't exist it will not be added. 
            {
                CurrentJoke[jokecount] = jokeHere;
                jokecount++; // this will generate the two jokes. 
            }
        }
    }

    public void OnPost()
    {
        ShowResults = true;
        RandomJoke(); 
    }
}
