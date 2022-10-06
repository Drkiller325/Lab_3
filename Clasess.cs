using System;
class ChessBoard
{
    public string BoardColor = "Brown";
}
class Black:ChessBoard
{
    public string OpponentColor = "black";
}
class White:ChessBoard
{
    public string PieceColor = "White";
}
abstract class ChessPiece:White
{
    public string position = "";
    public int count = 0;
    public void readers(string position,int count){
        this.count = count;
        this.position = position;
    }
    public abstract void move();
}
class King:ChessPiece
{
    public override void move()
    {
        Console.WriteLine("King moves one square in any direction");
    }
}
class Queen:ChessPiece
{
    public override void move()
    {
        Console.WriteLine("The Queen moves in all directions any number of squares");
    }
}
class Knight:ChessPiece
{
    public override void move()
    {
        Console.WriteLine("The Knight moves in an L shaped mannar in any direction");
    }
}
class Rook:ChessPiece
{
    public override void move()
    {
        Console.WriteLine("The Rook moves in a straight line by any number of squares");
    }
}
class Bishop:ChessPiece
{
    public override void move()
    {
        Console.WriteLine("The Bishop can move in an X shape mannar a.k.a diagonally on the same color");
    }
}
class Pawn:ChessPiece
{
    public override void move()
    {
        Console.WriteLine("The Pawn moves one square forword at a time and can atack diagonally by one square");
    }
}
