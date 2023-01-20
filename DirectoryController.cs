using WebshopLabb;

internal class DirectoryController
{
    private IUI io;
    private IDAO filmsDAO;

    public DirectoryController(IUI io, IDAO filmsDAO)
    {
        this.io = io;
        this.filmsDAO = filmsDAO;
    }

    public void Start()
    {
        io.Print("Lägg till en film");


        List<FilmsODM> films = filmsDAO.ReadAll();

        for (int i = 0; i < films.Count; i++)
        {
            io.Print(films[i].Title); io.Print(films[i].Director); io.Print(films[i].Genre); io.Print(films[i].Price.ToString());
        }
    }
}