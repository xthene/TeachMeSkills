using Shapes;

Square greenSquare = new Square(5, "green");
Square blueSquare = new Square(2, "blue");
Square lightBlueSquare = new Square(15, "light blue");

greenSquare.GetInfo();
blueSquare.GetInfo();
lightBlueSquare.GetInfo();

greenSquare = new Square(blueSquare.sideLength * 3, "green");

greenSquare.GetInfo();
blueSquare.GetInfo();
lightBlueSquare.GetInfo();