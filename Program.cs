

using WebshopLabb;

IUI io;
IDAO filmsDAO;

io = new TextIO();
filmsDAO = new MongoDAO("Webshop", "mongodb+srv://iths123:iths123@clusterone.lft8vp1.mongodb.net/?retryWrites=true&w=majority");

DirectoryController filmController = new DirectoryController(io, filmsDAO); 
filmController.Start();