HtmlGenerator myWebsite = new HtmlGenerator();
myWebsite.hTml();
myWebsite.h1();
myWebsite.main();
myWebsite.main2();


class HtmlGenerator
{
    public void hTml()
    {
        Console.WriteLine("<!DOCTYPE html>" + 
                          "\n<html>" +
                          "\n<body>");
    }

    public void h1()
    {
        Console.WriteLine("<h1> Välkomna </h1>");
    }

    public void main()
    {
        Console.WriteLine("<main>" +
                          "\n<p>Kurs om C#</p>" +
                          "\n<p>Kurs om Databaser</p>");
    }
    public void main2()
    {
        Console.WriteLine("</main>" +
                          "\n</body>" +
                          "\n</html");

    }
}
