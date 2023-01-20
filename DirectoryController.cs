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

    FilmsODM CreateFilm()
    {
        return new FilmsODM { Title = io.UserInput(), Director = io.UserInput(), Genre = io.UserInput(), Price = int.Parse(io.UserInput()) };
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