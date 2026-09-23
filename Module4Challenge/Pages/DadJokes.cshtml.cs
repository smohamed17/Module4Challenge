using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Module4Challenge.Pages;

public class IndexModel : PageModel
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

    public bool ShowResults {get; set; } = false;

    public void OnGet()
    {
       Random rnd = new Random();
       int DadJokesDisplay = rnd.Next(DadJokes.Length);

    }

    public void OnPost(int JokesDisplay1, int JokesDisplay2)
    {
        ShowResults = true;
    }
}

